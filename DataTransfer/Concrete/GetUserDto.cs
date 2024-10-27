using DataTransfer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Concrete
{
    public class GetUserDto : BaseDto
    {
        public Int64 UserCode { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Int64 UserRoleCode { get; set; }
    }
}
