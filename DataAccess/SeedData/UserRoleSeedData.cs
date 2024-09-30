using Entities.Consts;
using Entities.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class UserRoleSeedData : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder.HasData(
               new UserRole
               {
                   UserRoleCode = 1,
                   RoleDescription = "Admin"
               },
               new UserRole
               {
                   UserRoleCode = 2,
                   RoleDescription = "Yönetici"
               },
               new UserRole
               {
                   UserRoleCode = 3,
                   RoleDescription = "Kullanici"
               }
           );

        }
    }
}
