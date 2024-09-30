using DataAccess.Repositories.Concrete;
using Entities.Consts;
using Entities.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            var cryptographyProcessor = new CryptographyProcessorRepo(null);

            var salt = cryptographyProcessor.CreateSalt();
            var hash = cryptographyProcessor.GenerateHash("123", salt);

            builder.HasData(
                new User
                {
                    UserCode = 101,
                    Email = "john.doe@example.com",
                    MobilePhone = "+905551234567",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    UserRoleCode = 1,
                    TwoFactorEnabled = false

                },
                new User
                {
                    UserCode = 102,
                    Email = "jane.doe@example.com",
                    MobilePhone = "+905551234568",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    UserRoleCode = 2,
                    TwoFactorEnabled = false

                },
                new User
                {
                    UserCode = 103,
                    Email = "alice.smith@example.com",
                    MobilePhone = "+905551234569",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    UserRoleCode = 3
                },
                new User
                {
                    UserCode = 104,
                    Email = "bob.johnson@example.com",
                    MobilePhone = "+905551234570",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    UserRoleCode = 3,
                    TwoFactorEnabled = false
                },
                new User
                {
                    UserCode = 105,
                    Email = "carol.davis@example.com",
                    MobilePhone = "+905551234571",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    UserRoleCode = 3,
                    TwoFactorEnabled = false
                }
            );
        }
    }
}