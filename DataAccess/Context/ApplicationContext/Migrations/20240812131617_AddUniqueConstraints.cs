using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 280, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1400), new byte[] { 197, 2, 108, 207, 142, 53, 39, 93, 180, 11, 123, 137, 61, 231, 122, 28, 216, 18, 238, 87, 7, 22, 240, 82, 235, 120, 34, 163, 174, 180, 86, 91, 73, 129, 35, 84, 108, 231, 113, 87, 111, 81, 255, 96, 233, 212, 132, 191, 212, 8, 190, 184, 51, 155, 177, 30, 47, 131, 244, 180, 176, 233, 73, 0 }, new byte[] { 241, 34, 201, 249, 221, 47, 99, 90, 170, 14, 155, 22, 96, 233, 56, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1402), new byte[] { 197, 2, 108, 207, 142, 53, 39, 93, 180, 11, 123, 137, 61, 231, 122, 28, 216, 18, 238, 87, 7, 22, 240, 82, 235, 120, 34, 163, 174, 180, 86, 91, 73, 129, 35, 84, 108, 231, 113, 87, 111, 81, 255, 96, 233, 212, 132, 191, 212, 8, 190, 184, 51, 155, 177, 30, 47, 131, 244, 180, 176, 233, 73, 0 }, new byte[] { 241, 34, 201, 249, 221, 47, 99, 90, 170, 14, 155, 22, 96, 233, 56, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1404), new byte[] { 197, 2, 108, 207, 142, 53, 39, 93, 180, 11, 123, 137, 61, 231, 122, 28, 216, 18, 238, 87, 7, 22, 240, 82, 235, 120, 34, 163, 174, 180, 86, 91, 73, 129, 35, 84, 108, 231, 113, 87, 111, 81, 255, 96, 233, 212, 132, 191, 212, 8, 190, 184, 51, 155, 177, 30, 47, 131, 244, 180, 176, 233, 73, 0 }, new byte[] { 241, 34, 201, 249, 221, 47, 99, 90, 170, 14, 155, 22, 96, 233, 56, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1405), new byte[] { 197, 2, 108, 207, 142, 53, 39, 93, 180, 11, 123, 137, 61, 231, 122, 28, 216, 18, 238, 87, 7, 22, 240, 82, 235, 120, 34, 163, 174, 180, 86, 91, 73, 129, 35, 84, 108, 231, 113, 87, 111, 81, 255, 96, 233, 212, 132, 191, 212, 8, 190, 184, 51, 155, 177, 30, 47, 131, 244, 180, 176, 233, 73, 0 }, new byte[] { 241, 34, 201, 249, 221, 47, 99, 90, 170, 14, 155, 22, 96, 233, 56, 222 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1406), new byte[] { 197, 2, 108, 207, 142, 53, 39, 93, 180, 11, 123, 137, 61, 231, 122, 28, 216, 18, 238, 87, 7, 22, 240, 82, 235, 120, 34, 163, 174, 180, 86, 91, 73, 129, 35, 84, 108, 231, 113, 87, 111, 81, 255, 96, 233, 212, 132, 191, 212, 8, 190, 184, 51, 155, 177, 30, 47, 131, 244, 180, 176, 233, 73, 0 }, new byte[] { 241, 34, 201, 249, 221, 47, 99, 90, 170, 14, 155, 22, 96, 233, 56, 222 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 16, 17, 281, DateTimeKind.Local).AddTicks(1576));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4006), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6474), new byte[] { 47, 157, 215, 85, 46, 248, 58, 190, 8, 76, 96, 143, 64, 23, 229, 138, 89, 219, 135, 75, 223, 66, 240, 221, 144, 128, 85, 243, 0, 68, 246, 102, 101, 17, 12, 124, 124, 177, 12, 168, 45, 208, 27, 212, 145, 213, 140, 74, 215, 22, 46, 241, 159, 195, 32, 218, 247, 102, 44, 24, 232, 111, 120, 22 }, new byte[] { 191, 237, 104, 212, 106, 168, 129, 252, 203, 166, 11, 153, 22, 51, 191, 102 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6479), new byte[] { 47, 157, 215, 85, 46, 248, 58, 190, 8, 76, 96, 143, 64, 23, 229, 138, 89, 219, 135, 75, 223, 66, 240, 221, 144, 128, 85, 243, 0, 68, 246, 102, 101, 17, 12, 124, 124, 177, 12, 168, 45, 208, 27, 212, 145, 213, 140, 74, 215, 22, 46, 241, 159, 195, 32, 218, 247, 102, 44, 24, 232, 111, 120, 22 }, new byte[] { 191, 237, 104, 212, 106, 168, 129, 252, 203, 166, 11, 153, 22, 51, 191, 102 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6481), new byte[] { 47, 157, 215, 85, 46, 248, 58, 190, 8, 76, 96, 143, 64, 23, 229, 138, 89, 219, 135, 75, 223, 66, 240, 221, 144, 128, 85, 243, 0, 68, 246, 102, 101, 17, 12, 124, 124, 177, 12, 168, 45, 208, 27, 212, 145, 213, 140, 74, 215, 22, 46, 241, 159, 195, 32, 218, 247, 102, 44, 24, 232, 111, 120, 22 }, new byte[] { 191, 237, 104, 212, 106, 168, 129, 252, 203, 166, 11, 153, 22, 51, 191, 102 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6482), new byte[] { 47, 157, 215, 85, 46, 248, 58, 190, 8, 76, 96, 143, 64, 23, 229, 138, 89, 219, 135, 75, 223, 66, 240, 221, 144, 128, 85, 243, 0, 68, 246, 102, 101, 17, 12, 124, 124, 177, 12, 168, 45, 208, 27, 212, 145, 213, 140, 74, 215, 22, 46, 241, 159, 195, 32, 218, 247, 102, 44, 24, 232, 111, 120, 22 }, new byte[] { 191, 237, 104, 212, 106, 168, 129, 252, 203, 166, 11, 153, 22, 51, 191, 102 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6483), new byte[] { 47, 157, 215, 85, 46, 248, 58, 190, 8, 76, 96, 143, 64, 23, 229, 138, 89, 219, 135, 75, 223, 66, 240, 221, 144, 128, 85, 243, 0, 68, 246, 102, 101, 17, 12, 124, 124, 177, 12, 168, 45, 208, 27, 212, 145, 213, 140, 74, 215, 22, 46, 241, 159, 195, 32, 218, 247, 102, 44, 24, 232, 111, 120, 22 }, new byte[] { 191, 237, 104, 212, 106, 168, 129, 252, 203, 166, 11, 153, 22, 51, 191, 102 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5138), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 13, 36, 851, DateTimeKind.Local).AddTicks(6662));
        }
    }
}
