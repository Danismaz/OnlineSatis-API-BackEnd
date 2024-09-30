using Entities.Entites.Abctract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites.Concrete
{
    public class UserRole : BaseEntity
    {
        [Key]
        [Required]
        public Int64 UserRoleCode { get; set; }
        [MinLength(5)]
        [MaxLength(250)]
        public string? RoleDescription { get; set; }

        public ICollection<User> Users { get; set; }
        
    }
}
