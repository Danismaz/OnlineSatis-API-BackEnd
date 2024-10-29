using DataTransfer.Abstract;
using Entities.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Concrete
{
    public class LoginDto : BaseDto
    {
        public string Email { get; init; }
        public string Password { get; init; }
        public bool TwoFactorEnabled { get; init; }
        public Int64 UserRoleCode { get; set; }
    }
}
