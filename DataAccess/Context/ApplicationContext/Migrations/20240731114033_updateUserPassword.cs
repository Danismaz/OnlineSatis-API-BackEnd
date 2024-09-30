using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUserPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "User",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "User",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6784), new byte[] { 220, 33, 54, 240, 49, 55, 20, 95, 53, 11, 128, 57, 236, 30, 192, 235, 128, 120, 0, 48, 195, 219, 109, 61, 227, 174, 60, 215, 161, 124, 228, 16, 0, 235, 111, 116, 219, 129, 3, 220, 1, 4, 219, 206, 249, 247, 142, 121 }, new byte[] { 231, 78, 56, 244, 33, 68, 231, 192, 58, 224, 30, 59, 224, 77, 118, 3, 174, 185, 240, 13, 129, 11, 157, 196 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6805), new byte[] { 220, 33, 54, 240, 49, 55, 20, 95, 53, 11, 128, 57, 236, 30, 192, 235, 128, 120, 0, 48, 195, 219, 109, 61, 227, 174, 60, 215, 161, 124, 228, 16, 0, 235, 111, 116, 219, 129, 3, 220, 1, 4, 219, 206, 249, 247, 142, 121 }, new byte[] { 231, 78, 56, 244, 33, 68, 231, 192, 58, 224, 30, 59, 224, 77, 118, 3, 174, 185, 240, 13, 129, 11, 157, 196 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6810), new byte[] { 220, 33, 54, 240, 49, 55, 20, 95, 53, 11, 128, 57, 236, 30, 192, 235, 128, 120, 0, 48, 195, 219, 109, 61, 227, 174, 60, 215, 161, 124, 228, 16, 0, 235, 111, 116, 219, 129, 3, 220, 1, 4, 219, 206, 249, 247, 142, 121 }, new byte[] { 231, 78, 56, 244, 33, 68, 231, 192, 58, 224, 30, 59, 224, 77, 118, 3, 174, 185, 240, 13, 129, 11, 157, 196 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6815), new byte[] { 220, 33, 54, 240, 49, 55, 20, 95, 53, 11, 128, 57, 236, 30, 192, 235, 128, 120, 0, 48, 195, 219, 109, 61, 227, 174, 60, 215, 161, 124, 228, 16, 0, 235, 111, 116, 219, 129, 3, 220, 1, 4, 219, 206, 249, 247, 142, 121 }, new byte[] { 231, 78, 56, 244, 33, 68, 231, 192, 58, 224, 30, 59, 224, 77, 118, 3, 174, 185, 240, 13, 129, 11, 157, 196 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6820), new byte[] { 220, 33, 54, 240, 49, 55, 20, 95, 53, 11, 128, 57, 236, 30, 192, 235, 128, 120, 0, 48, 195, 219, 109, 61, 227, 174, 60, 215, 161, 124, 228, 16, 0, 235, 111, 116, 219, 129, 3, 220, 1, 4, 219, 206, 249, 247, 142, 121 }, new byte[] { 231, 78, 56, 244, 33, 68, 231, 192, 58, 224, 30, 59, 224, 77, 118, 3, 174, 185, 240, 13, 129, 11, 157, 196 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6301), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6307), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6316), new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 31, 14, 40, 32, 820, DateTimeKind.Local).AddTicks(7007));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8182), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8950), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9276));
        }
    }
}
