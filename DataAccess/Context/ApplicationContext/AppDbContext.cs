﻿using DataAccess.SeedData;
using Entities.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

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
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shipper> Shipper { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Email) // Benzersiz olmasını istediğiniz property
            .IsUnique(true); // Benzersiz kılma
            modelBuilder.Entity<User>()
                .HasIndex(u => u.MobilePhone)
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
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryCode);


            modelBuilder.ApplyConfiguration(new UserDetailSeedData());
            modelBuilder.ApplyConfiguration(new UserRoleSeedData());
            modelBuilder.ApplyConfiguration(new UserSeedData());
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new ProductSeedData());
            modelBuilder.ApplyConfiguration(new ShipperSeedData());

            base.OnModelCreating(modelBuilder);
        }

    }
}
