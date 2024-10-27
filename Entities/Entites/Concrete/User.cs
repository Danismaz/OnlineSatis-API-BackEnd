using Entities.Entites.Abctract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites.Concrete
{
    public class User : BaseEntity
    {
        [Key]
        [Required]
        public Int64 UserCode { get; set; }
        [Required]
        public Int64 UserRoleCode { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        [Phone]
        public string MobilePhone { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required] public bool TwoFactorEnabled { get; set; } = false;

        [ForeignKey("UserRoleCode")]
        public UserRole UserRole { get; set; }
        public UserDetail UserDetail { get; set; }

    }
}
