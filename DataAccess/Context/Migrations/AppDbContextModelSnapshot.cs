﻿// <auto-generated />
using System;
using DataAccess.Context.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.Property<long>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserRoleCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserCode");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("MobilePhone")
                        .IsUnique();

                    b.HasIndex("UserRoleCode");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserCode = 101L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7100),
                            Email = "john.doe@example.com",
                            MobilePhone = "+905551234567",
                            PasswordHash = new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 },
                            PasswordSalt = new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 },
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserRoleCode = 1L
                        },
                        new
                        {
                            UserCode = 102L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110),
                            Email = "jane.doe@example.com",
                            MobilePhone = "+905551234568",
                            PasswordHash = new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 },
                            PasswordSalt = new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 },
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserRoleCode = 2L
                        },
                        new
                        {
                            UserCode = 103L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110),
                            Email = "alice.smith@example.com",
                            MobilePhone = "+905551234569",
                            PasswordHash = new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 },
                            PasswordSalt = new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 },
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserRoleCode = 3L
                        },
                        new
                        {
                            UserCode = 104L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110),
                            Email = "bob.johnson@example.com",
                            MobilePhone = "+905551234570",
                            PasswordHash = new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 },
                            PasswordSalt = new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 },
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserRoleCode = 3L
                        },
                        new
                        {
                            UserCode = 105L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110),
                            Email = "carol.davis@example.com",
                            MobilePhone = "+905551234571",
                            PasswordHash = new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 },
                            PasswordSalt = new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 },
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserRoleCode = 3L
                        });
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserDetail", b =>
                {
                    b.Property<long>("UserDetailCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserDetailCode"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserDetailCode");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("UserCode")
                        .IsUnique();

                    b.ToTable("UserDetail");

                    b.HasData(
                        new
                        {
                            UserDetailCode = 1L,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6320),
                            Email = "ahmet.yilmaz@kirtasiyemerkezi.com",
                            IdentityNumber = "98765432101",
                            MobilePhone = "+905551234567",
                            Name = "Ahmet",
                            Status = 1,
                            Surname = "Yılmaz",
                            UserCode = 101L
                        },
                        new
                        {
                            UserDetailCode = 2L,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350),
                            Email = "mehmet.demir@ofismalzemeleri.com",
                            IdentityNumber = "98765432102",
                            MobilePhone = "+905551234568",
                            Name = "Mehmet",
                            Status = 1,
                            Surname = "Demir",
                            UserCode = 102L
                        },
                        new
                        {
                            UserDetailCode = 3L,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350),
                            Email = "ayse.kaya@kirtasiyedunyasi.com",
                            IdentityNumber = "98765432103",
                            MobilePhone = "+905551234569",
                            Name = "Ayşe",
                            Status = 1,
                            Surname = "Kaya",
                            UserCode = 103L
                        },
                        new
                        {
                            UserDetailCode = 4L,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360),
                            Email = "ali.celik@ofismerkezi.com",
                            IdentityNumber = "98765432104",
                            MobilePhone = "+905551234570",
                            Name = "Ali",
                            Status = 1,
                            Surname = "Çelik",
                            UserCode = 104L
                        },
                        new
                        {
                            UserDetailCode = 5L,
                            BirthDate = new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360),
                            Email = "fatma.yurt@kirtasiyevi.com",
                            IdentityNumber = "98765432105",
                            MobilePhone = "+905551234571",
                            Name = "Fatma",
                            Status = 1,
                            Surname = "Yurt",
                            UserCode = 105L
                        });
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserRole", b =>
                {
                    b.Property<long>("UserRoleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserRoleCode"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RoleDescription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("UserCode")
                        .HasColumnType("bigint");

                    b.HasKey("UserRoleCode");

                    b.HasIndex("UserCode");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserRoleCode = 1L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460),
                            RoleDescription = "Admin",
                            Status = 1
                        },
                        new
                        {
                            UserRoleCode = 2L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460),
                            RoleDescription = "Yönetici",
                            Status = 1
                        },
                        new
                        {
                            UserRoleCode = 3L,
                            CreatedDate = new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460),
                            RoleDescription = "Kullanici",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserDetail", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("Entities.Entites.Concrete.UserDetail", "UserCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserRole", b =>
                {
                    b.HasOne("Entities.Entites.Concrete.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserCode");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.User", b =>
                {
                    b.Navigation("UserDetail")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Entities.Entites.Concrete.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}