using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class UserTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_UserCode",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "UserCode",
                table: "UserRole");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4050), new byte[] { 167, 166, 187, 223, 23, 173, 220, 47, 30, 165, 32, 6, 181, 80, 148, 37, 86, 195, 197, 111, 119, 80, 223, 113, 94, 254, 149, 244, 137, 130, 151, 156, 187, 81, 77, 141, 107, 154, 214, 195, 159, 73, 128, 77, 173, 21, 170, 144, 198, 178, 165, 41, 8, 64, 100, 89, 227, 192, 48, 170, 240, 129, 248, 229 }, new byte[] { 173, 229, 153, 42, 60, 171, 120, 249, 48, 255, 95, 2, 67, 191, 197, 240 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4060), new byte[] { 167, 166, 187, 223, 23, 173, 220, 47, 30, 165, 32, 6, 181, 80, 148, 37, 86, 195, 197, 111, 119, 80, 223, 113, 94, 254, 149, 244, 137, 130, 151, 156, 187, 81, 77, 141, 107, 154, 214, 195, 159, 73, 128, 77, 173, 21, 170, 144, 198, 178, 165, 41, 8, 64, 100, 89, 227, 192, 48, 170, 240, 129, 248, 229 }, new byte[] { 173, 229, 153, 42, 60, 171, 120, 249, 48, 255, 95, 2, 67, 191, 197, 240 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4060), new byte[] { 167, 166, 187, 223, 23, 173, 220, 47, 30, 165, 32, 6, 181, 80, 148, 37, 86, 195, 197, 111, 119, 80, 223, 113, 94, 254, 149, 244, 137, 130, 151, 156, 187, 81, 77, 141, 107, 154, 214, 195, 159, 73, 128, 77, 173, 21, 170, 144, 198, 178, 165, 41, 8, 64, 100, 89, 227, 192, 48, 170, 240, 129, 248, 229 }, new byte[] { 173, 229, 153, 42, 60, 171, 120, 249, 48, 255, 95, 2, 67, 191, 197, 240 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4070), new byte[] { 167, 166, 187, 223, 23, 173, 220, 47, 30, 165, 32, 6, 181, 80, 148, 37, 86, 195, 197, 111, 119, 80, 223, 113, 94, 254, 149, 244, 137, 130, 151, 156, 187, 81, 77, 141, 107, 154, 214, 195, 159, 73, 128, 77, 173, 21, 170, 144, 198, 178, 165, 41, 8, 64, 100, 89, 227, 192, 48, 170, 240, 129, 248, 229 }, new byte[] { 173, 229, 153, 42, 60, 171, 120, 249, 48, 255, 95, 2, 67, 191, 197, 240 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(4070), new byte[] { 167, 166, 187, 223, 23, 173, 220, 47, 30, 165, 32, 6, 181, 80, 148, 37, 86, 195, 197, 111, 119, 80, 223, 113, 94, 254, 149, 244, 137, 130, 151, 156, 187, 81, 77, 141, 107, 154, 214, 195, 159, 73, 128, 77, 173, 21, 170, 144, 198, 178, 165, 41, 8, 64, 100, 89, 227, 192, 48, 170, 240, 129, 248, 229 }, new byte[] { 173, 229, 153, 42, 60, 171, 120, 249, 48, 255, 95, 2, 67, 191, 197, 240 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 16, 15, 31, 282, DateTimeKind.Local).AddTicks(3170));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserCode",
                table: "UserRole",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5320), new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5340), new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UserCode" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UserCode" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "UserCode" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserCode",
                table: "UserRole",
                column: "UserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole",
                column: "UserCode",
                principalTable: "User",
                principalColumn: "UserCode");
        }
    }
}
