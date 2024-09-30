using DataTransfer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Concrete
{
    public class UserForCreateDto : BaseDto
    {
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Int64 UserTypeCode { get; set; }
        public string MobilePhone { get; set; }
    }
}
