using DataTransfer.Concrete;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KYSProjectApi.Services.Token
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        // private readonly IUserDetailRepo _userDetailRepo;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
            // _userDetailRepo = userDetailRepo;
        }

        private readonly HashSet<string> _blacklistedTokens = new HashSet<string>();

        public void AddToBlacklist(string token)
        => _blacklistedTokens.Add(token);

        public bool IsTokenBlacklisted(string token)
        => _blacklistedTokens.Contains(token);


        public async Task<string> GenerateTokenAsync(string email)
        {
            var claim = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Token:Issuer"],
                audience: _configuration["Token:Audience"],
                claims: claim,
                expires: DateTime.Now.AddHours(1),
                notBefore: DateTime.Now,
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return await Task.FromResult(tokenString);
        }

        public bool ValidateTokenAsync(string token)
        {
            try
            {
                if (IsTokenBlacklisted(token))
                    return false;
                
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true, // Token süresinin kontrol edilmesini sağlar
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _configuration["Token:Issuer"],
                    ValidAudience = _configuration["Token:Audience"],
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]))
                };

                // Token'ı doğrulayın
                SecurityToken validatedToken;
                var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);

                // Token geçerli ve süresi dolmamışsa
                return validatedToken != null;
            }
            catch (SecurityTokenExpiredException)
            {
                // Token süresi dolmuşsa
                return false;
            }
            catch (SecurityTokenInvalidIssuerException)
            {
                // Token geçersiz bir issuer içeriyorsa
                return false;
            }
            catch (SecurityTokenInvalidAudienceException)
            {
                // Token geçersiz bir audience içeriyorsa
                return false;
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                // Token imzası geçersizse
                return false;
            }
            catch
            {
                // Token doğrulama sırasında başka bir hata oluşursa
                return false;
            }
        }

        public async Task<UserForLoginDto> GetUserFromTokenAsync(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _configuration["Token:Issuer"],
                    ValidAudience = _configuration["Token:Audience"],
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]))
                };

                var principal =
                    tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);

                // Token geçerli ve doğrulanmışsa, claims'ten kullanıcı bilgilerini al
                var userDetailDto = new UserForLoginDto
                (
                    principal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value, null, null
                );

                return await Task.FromResult(userDetailDto);
            }
            catch
            {
                // Token geçerli değilse veya doğrulama sırasında bir hata oluştuysa
                return null;
            }
        }

        public string GetEmailFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            // "sub" claim türü altında e-posta adresini al
            var emailClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub);

            return emailClaim?.Value; // E-posta adresini döndür
        }
    }
}