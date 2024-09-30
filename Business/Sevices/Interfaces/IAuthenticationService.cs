using DataTransfer.Concrete;
using Entities.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Sevices.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> ValidateUser(LoginDto model);

        //Task<bool> Login(LoginDto model);

    }
}
