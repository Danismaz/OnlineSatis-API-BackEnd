using Entities.Entites.Abctract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites.Concrete
{
    public class UserDetail : BaseEntity
    {
        [Key]
        [Required]
        public Int64 UserDetailCode { get; set; }
        [Required]
        public Int64 UserCode { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Surname { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string IdentityNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        [Phone]
        public string MobilePhone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public User User { get; set; }
    }
}
