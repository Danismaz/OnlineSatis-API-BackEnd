using DataTransfer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Concrete
{
    public class UserForGetUserCodeDto : BaseDto
    {
        public Int64 UserCode { get; set; }
    }
}
