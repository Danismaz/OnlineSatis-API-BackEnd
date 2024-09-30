using AutoMapper;
using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using NLog;
using System.Net;
using System.Transactions;

namespace Business.Sevices.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ICryptographyProcessor _cryptography;
        private readonly IUserService _userService;

        public AuthenticationService(ICryptographyProcessor cryptography, IUserService userService)
        {
            _cryptography = cryptography;
            _userService = userService;
        }
        //public async Task<bool> Login(LoginDto model)
        //{
        //   var email = await _userService.AnyAsync(x=> x.Email.Equals(model.Email));
        //    if (email)
        //    {
        //       var password = await _cryptography.AreEqualAsync(model.Email,model.Password);
        //        if (password)
        //            return true;
        //        return false;
        //    }
        //    return false;
        //}

        public async Task<bool> ValidateUser(LoginDto model)
        {
            var dto = await _userService.GetByEmailAsync<LoginDto>(x=> x.Email == model.Email);
            if (dto.Email is not null)
            {
                var password = await _cryptography.AreEqualAsync(model.Email, model.Password);
                if (password)
                    return true;
                return false;
            }
            return false;
        }
    }
}
