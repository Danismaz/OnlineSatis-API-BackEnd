using Business.Responce;
using DataTransfer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ControllerService.Account
{
    public class LoginService
    {
        //public async Task<IAction> LoginService(LoginVm model) 
        //{
        //    if (model is null)
        //    {
        //        return NotFound(new Responce<string>
        //        {
        //            StatusCode = 404,
        //            Message = "Geçersiz istek. Model null.",
        //            Data = null
        //        });
        //    }

        //    if (!ModelState.IsValid)
        //        return UnprocessableEntity(ModelState);

        //    var userVm = await _userService.GetByEmailAsync<LoginDto>(x => x.Email == model.Email && x.Status != Entities.Consts.Status.Passive);
        //    if (userVm is null)
        //    {
        //        return NotFound(new Responce<string>
        //        {
        //            StatusCode = 404,
        //            Message = $"Bu {model.Email}'e sahip kullanıcı bulunamadı. Lütfen kayıt olunuz.",
        //            Data = null
        //        });
        //    }

        //    var result = await _cryptography.AreEqualAsync(model.Email, model.Password);
        //    if (!result)
        //    {
        //        return Unauthorized(new Responce<string>
        //        {
        //            StatusCode = 401,
        //            Message = "Geçersiz kimlik bilgileri",
        //            Data = null
        //        });
        //    }

        //    // Kullanıcıyı doğruladıktan sonra token oluştur
        //    var token = await _tokenService.GenerateTokenAsync(model.Email);

        //    // Token'ı istemciye döndür
        //    return Ok(new Responce<string>
        //    {
        //        StatusCode = 200,
        //        Message = "Giriş başarılı",
        //        Data = token
        //    });
        //}
    }
}
