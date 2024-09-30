using DataAccess.SeedData;
using Entities.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context.ApplicationContext
{
    public class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        
        public DbSet<User> User { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<UserRole> UserRole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Email) // Benzersiz olmasını istediğiniz property
            .IsUnique(true); // Benzersiz kılma
            modelBuilder.Entity<User>()
                .HasIndex(u=> u.MobilePhone)
                .IsUnique(true);
            modelBuilder.Entity<UserDetail>()
                .HasIndex(ud => ud.IdentityNumber)
                .IsUnique(true);
            modelBuilder.Entity<UserDetail>()
                .HasIndex(ud => ud.Email)
                .IsUnique(true);
            

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserRole)
                .WithMany(ut => ut.Users)
                .HasForeignKey(u => u.UserRoleCode);

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserDetail)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserDetail>(ud => ud.UserCode);


            
            modelBuilder.ApplyConfiguration(new UserDetailSeedData());
            modelBuilder.ApplyConfiguration(new UserRoleSeedData());
            modelBuilder.ApplyConfiguration(new UserSeedData());

            base.OnModelCreating(modelBuilder);
        }

    }
}
