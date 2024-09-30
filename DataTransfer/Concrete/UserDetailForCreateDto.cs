using DataTransfer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Concrete
{
    public class UserDetailForCreateDto : BaseDto
    {
        public Int64 UserCode { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
