using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Business.ActionFilters;
using Business.Responce;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using KYSProjectApi.Models;
using KYSProjectApi.Services.TCKimlikService;
using KYSProjectApi.Services.Token;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Auth
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(
        IUserService userService,
        ICryptographyProcessor cryptography,
        ITokenService tokenService,
        IMapper mapper,
        ITCKimlikService tcService,
        IEmailService emailService,
        IUserDetailService userDetailService,
        ITwoFactorAuthService twoFactorAuthService)
        : ControllerBase
    {
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginVm model)
        {
            var userDto = await userService.GetByEmailAsync<LoginDto?>(x =>
                x.Email == model.Email && x.Status != Entities.Consts.Status.Passive);
            if (userDto is null)
            {
                return NotFound(new Response<string>
                {
                    StatusCode = 404,
                    Message = $"Bu {model.Email}'e sahip kullanıcı bulunamadı. Lütfen kayıt olunuz.",
                    Data = null
                });
            }

            var result = await cryptography.AreEqualAsync(model.Email, model.Password);
            if (!result)
            {
                return Unauthorized(new Response<string>
                {
                    StatusCode = 401,
                    Message = "Geçersiz kimlik bilgileri",
                    Data = null
                });
            }

            if (userDto.TwoFactorEnabled)
            {
                // İki faktörlü doğrulama kodunu gönder
                await twoFactorAuthService.SendVerificationCodeAsync(userDto.Email);
                return Ok(new
                {
                    TwoFactorRequired = true,
                    Message = "Doğrulama kodu gönderildi.",
                    userDto.Email, // E-posta adresini de döndür
                    Data = "" // Data özelliği, burada `null` olabilir
                });
            }

            // Kullanıcıyı doğruladıktan sonra token oluştur
            var token = await tokenService.GenerateTokenAsync(model.Email);

            // Token'ı istemciye döndür
            return Ok(new Response<string>
            {
                StatusCode = 200,
                Message = "Giriş başarılı",
                Data = token
            });
        }


        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegisterVm model)
        {
            try
            {
                var salt = cryptography.CreateSalt();
                var userRegister = new UserForRegisterDto
                {
                    Email = model.Email,
                    Surname = model.Surname,
                    Name = model.Name,
                    BirthDate = model.BirthDate,
                    IdentityNumber = model.IdentityNumber,
                    MobilePhone = model.MobilePhone,
                    PasswordSalt = salt,
                    PasswordHash = cryptography.GenerateHash(model.Password, salt),
                    UserRoleCode = 3
                };

                //Kullanıcı Zaten Kayıtlı mı
                var userEmail = await userDetailService.AnyAsync(x => x.Email == model.Email);
                if (userEmail)
                    return StatusCode(409, "Girmiş olduğunuz mail sistemde zaten kayıtlı. Giriş yapınız.");
                var userTc = await userDetailService.AnyAsync(x => x.IdentityNumber == model.IdentityNumber);
                if (userTc)
                    return StatusCode(409,
                        "Girmiş olduğunuz TC kimlik numarası sistemde zaten kayıtlı. Giriş yapınız.");
                var userTel = await userDetailService.AnyAsync(x => x.MobilePhone == model.MobilePhone);
                if (userTel)
                    return StatusCode(409, "Girmiş olduğunuz telefon numarası sistemde zaten kayıtlı. Giriş yapınız.");

                // TC Kimlik Doğrulama
                var isValid = await tcService.VerifyTcKimlikNoAsync(model.IdentityNumber, model.Name, model.Surname,
                    model.BirthDate);
                if (!isValid)
                    return BadRequest(new { Message = "TC Kimlik numarası doğrulanamadı." });

                var resultUser = await userService.AddAsync(userRegister);
                if (!resultUser)
                    return BadRequest(new { Message = "Kullanıcı eklenemedi. Tekrar Deneyiniz." });

                var addedUser =
                    await userService.GetByEmailAsync<UserForGetUserCodeDto>(x => x.Email == userRegister.Email);

                userRegister.UserCode = addedUser.UserCode;

                var resultUserDetail = await userDetailService.AddAsync(userRegister);
                if (!resultUserDetail)
                    return BadRequest(new { Message = "Kullanıcı eklenemedi. Tekrar Deneyiniz." });
                
                await emailService.SendWelcomeEmail(mapper.Map<UserForRegisterModel>(model));

                return Ok(new { Message = "Kullanıcı başarılı bir şekilde kayıt edildi. Giriş yapabilirsiniz." });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(UserForChangePasswordVm model)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrWhiteSpace(token))
            {
                return NotFound(new Response<string>
                {
                    StatusCode = 404,
                    Message = "Token request'de bulunamadı.",
                    Data = null,
                        
                });
            }
            
            var isValidToken = tokenService.ValidateTokenAsync(token);
            if (!isValidToken)
                return Unauthorized(new Response<string>
                {
                    StatusCode = 401,
                    Message = "Geçersiz token",
                    Data = token
                });
            var tokenEmail = tokenService.GetEmailFromToken(token);
            if (string.IsNullOrEmpty(tokenEmail))
                return NotFound(new Response<string>
                {
                    StatusCode = 404,
                    Message = $"Bu {model.Email}'e sahip kullanıcı bulunamadı. Geçersiz token.",
                    Data = token
                });
            if (tokenEmail != model.Email)
                return Unauthorized(new Response<string>
                {
                    StatusCode = 401,
                    Message = "Geçersiz kimlik bilgileri içeren token.",
                    Data = token
                });

            var oldPasswordResult = await cryptography.AreEqualAsync(model.Email, model.OldPassword);
            if (!oldPasswordResult)
                return BadRequest("Eski şifre geçersiz.");

            // var changePasswordDto = _mapper.Map<UserForChangePasswordDto>(model);

            var userDto = await userService.GetByEmailAsync<GetUserDto>(x => x.Email == model.Email);

            var newSalt = cryptography.CreateSalt();
            var newHash = cryptography.GenerateHash(model.NewPassword, newSalt);

            userDto.PasswordSalt = newSalt;
            userDto.PasswordHash = newHash;

            var result = await userService.UpdateAsync(userDto);

            if (!result)
                return BadRequest(new { Message = "Şifre değiştirilemedi." });

            return Ok(new { token, Message = "Şifre başarılı bir şekilde değiştirildi." });
        }


        [HttpPost("logout")]
        public IActionResult Logout([FromBody] string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest(new { message = "Token gerekli." });
            }

            tokenService.AddToBlacklist(token);

            return Ok(new { message = "Çıkış başarılı" });
        }

        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordVm model)
        {
            // E-posta adresinin geçerli olup olmadığını kontrol et
            if (string.IsNullOrEmpty(model.Email) || !new EmailAddressAttribute().IsValid(model.Email))
            {
                return BadRequest("Geçersiz e-posta adresi.");
            }

            // Kullanıcıyı e-posta adresi ile bul
            var user = await userService.GetByEmailAsync<GetUserDto?>(x => x.Email == model.Email);
            if (user == null)
            {
                return NotFound(new { message = "E-posta adresi bulunamadı." });
            }

            // Geçici bir token oluştur
            var token = await tokenService.GenerateTokenAsync(user.Email);

            // E-posta ile token gönder
            await emailService.SendPasswordResetEmail(model.Email, token);

            return Ok(new { message = "Şifre sıfırlama linki e-postanıza gönderildi." });
        }


        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(UserForResetPasswordVm model)
        {
            // Gelen Authorization başlığından token'ı al
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrWhiteSpace(token))
            {
                return NotFound(new Response<string>
                {
                    StatusCode = 404,
                    Message = "Token request'de bulunamadı.",
                    Data = null,
                        
                });
            }
            
            // Token'ın geçerli olup olmadığını kontrol et
            var isValidToken = tokenService.ValidateTokenAsync(token);
            if (!isValidToken)
            {
                return Unauthorized(new Response<string>
                {
                    StatusCode = 401,
                    Message = "Geçersiz token",
                    Data = token
                });
            }

            // Token'dan e-posta adresini al
            var tokenEmail = tokenService.GetEmailFromToken(token);
            if (string.IsNullOrEmpty(tokenEmail))
            {
                return NotFound(new Response<string>
                {
                    StatusCode = 404,
                    Message = $"Bu e-posta adresine sahip kullanıcı bulunamadı. Geçersiz token.",
                    Data = token
                });
            }

            var userDetailDto = await userDetailService.GetByEmailAsync<UserDetailDto?>(x => x.Email == tokenEmail);
            if (userDetailDto == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            // Kullanıcıyı e-posta adresi ile bul
            var userDto = await userService.GetByEmailAsync<GetUserDto?>(x => x.Email == tokenEmail);
            if (userDto == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            // Kullanıcı adını ve soyadını kontrol et
            if (!userDetailDto.Name.Equals(model.Name, StringComparison.OrdinalIgnoreCase) ||
                !userDetailDto.Surname.Equals(model.Surname, StringComparison.OrdinalIgnoreCase))
            {
                return Unauthorized("Ad veya soyad hatalı.");
            }

            // Yeni salt ve hash oluştur
            var newSalt = cryptography.CreateSalt();
            var newHash = cryptography.GenerateHash(model.NewPassword, newSalt);

            // Kullanıcının şifre ve salt değerlerini güncelle
            userDto.PasswordSalt = newSalt;
            userDto.PasswordHash = newHash;

            // Kullanıcıyı güncelle
            var result = await userService.UpdateAsync(userDto);
            if (!result)
            {
                return BadRequest(new { Message = "Şifre sıfırlanamadı." });
            }

            return Ok(new { Message = "Şifre başarılı bir şekilde sıfırlandı." });
        }


        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost("Verify2FACode")]
        public async Task<IActionResult> Verify2FaCode([FromBody] Verify2FACodeVm model)
        {
            var isValid = twoFactorAuthService.ValidateCode(model.Email, model.Code);
            if (isValid)
            {
                // Kod doğru ve geçerli, token oluşturulabilir veya kullanıcı doğrulama işlemi tamamlanabilir
                var token = await tokenService.GenerateTokenAsync(model.Email);

                return Ok(new Response<string>
                {
                    StatusCode = 200,
                    Message = "Doğrulama başarılı.",
                    Data = token
                });
            }

            // Kod yanlış veya süresi dolmuş
            return BadRequest(new Response<string>
            {
                StatusCode = 400,
                Message = "Geçersiz veya süresi dolmuş doğrulama kodu.",
                Data = null
            });
        }

        [HttpPost("SendVerificationCodeAsync")]
        public async Task<IActionResult> SendVerificationCodeAsync([FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest(new { message = "Kullanıcı Maili gerekli." });
            }
            await twoFactorAuthService.SendVerificationCodeAsync(email);
            return Ok(new
            {
                TwoFactorRequired = true,
                Message = "Doğrulama kodu gönderildi.",
                Email = email, // E-posta adresini de döndür
                Data = "" // Data özelliği, burada `null` olabilir
            });
        }
        
    }
}