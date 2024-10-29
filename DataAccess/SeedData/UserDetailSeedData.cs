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
    public class UserDetailSeedData : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {

            builder.HasData(
                new UserDetail
                {
                    UserDetailCode = 102,
                    UserCode = 1002,
                    Name = "yavuz bugra",
                    Surname = "alkan",
                    IdentityNumber = "98765432555",
                    MobilePhone = "+905321391090",
                    Email = "yavuzbugraalkan@gmail.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 101,
                    UserCode = 1001,
                    Name = "ismail",
                    Surname = "danışmaz",
                    IdentityNumber = "98765432333",
                    MobilePhone = "+905321391095",
                    Email = "danismazismail@gmail.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 1,
                    UserCode = 101,
                    Name = "Ahmet",
                    Surname = "Yılmaz",
                    IdentityNumber = "98765432101",
                    MobilePhone = "+905551234567",
                    Email = "ahmet.yilmaz@kirtasiyemerkezi.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 2,
                    UserCode = 102,
                    Name = "Mehmet",
                    Surname = "Demir",
                    IdentityNumber = "98765432102",
                    MobilePhone = "+905551234568",
                    Email = "mehmet.demir@ofismalzemeleri.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 3,
                    UserCode = 103,
                    Name = "Ayşe",
                    Surname = "Kaya",
                    IdentityNumber = "98765432103",
                    MobilePhone = "+905551234569",
                    Email = "ayse.kaya@kirtasiyedunyasi.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 4,
                    UserCode = 104,
                    Name = "Ali",
                    Surname = "Çelik",
                    IdentityNumber = "98765432104",
                    MobilePhone = "+905551234570",
                    Email = "ali.celik@ofismerkezi.com",
                    BirthDate = new DateTime(1990, 6, 10)
                },
                new UserDetail
                {
                    UserDetailCode = 5,
                    UserCode = 105,
                    Name = "Fatma",
                    Surname = "Yurt",
                    IdentityNumber = "98765432105",
                    MobilePhone = "+905551234571",
                    Email = "fatma.yurt@kirtasiyevi.com",
                    BirthDate = new DateTime(1990, 6, 10)
                }
            );

        }
    }
}
