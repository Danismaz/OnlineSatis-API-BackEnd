using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class Teslim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "ShipperCode",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7150), new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7150), new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7150), new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7160), new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7160), new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 } });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "TwoFactorEnabled", "UpdatedDate", "UserRoleCode" },
                values: new object[,]
                {
                    { 1001L, new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7140), null, "danismazismail@gmail.com", "+905321391095", new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 }, 1, false, null, 3L },
                    { 1002L, new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(7130), null, "yavuzbugraalkan@gmail.com", "+905321391090", new byte[] { 240, 148, 174, 173, 140, 245, 98, 17, 74, 71, 245, 170, 243, 19, 147, 144, 166, 89, 27, 130, 36, 69, 166, 96, 12, 0, 154, 153, 136, 85, 98, 138, 121, 224, 73, 161, 148, 95, 28, 89, 227, 7, 120, 242, 203, 45, 69, 236, 222, 170, 59, 104, 62, 245, 197, 200, 34, 126, 32, 17, 80, 58, 58, 64 }, new byte[] { 213, 50, 226, 102, 215, 128, 135, 66, 96, 115, 33, 83, 11, 146, 91, 74 }, 1, false, null, 1L }
                });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6080), null, "danismazismail@gmail.com", "98765432333", "+905321391095", "ismail", 1, "danışmaz", null, 1001L },
                    { 102L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 20, 1, 19, 359, DateTimeKind.Local).AddTicks(6040), null, "yavuzbugraalkan@gmail.com", "98765432555", "+905321391090", "yavuz bugra", 1, "alkan", null, 1002L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 1002L);

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
    }
}
