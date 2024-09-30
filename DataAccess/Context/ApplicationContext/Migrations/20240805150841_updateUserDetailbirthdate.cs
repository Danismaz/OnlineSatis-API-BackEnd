using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUserDetailbirthdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "UserDetail",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 825, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 825, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 825, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 825, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 825, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(301), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(305), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3165), new byte[] { 87, 244, 234, 164, 37, 207, 7, 211, 129, 163, 221, 8, 132, 119, 127, 29, 87, 208, 38, 96, 17, 80, 142, 224, 184, 68, 155, 173, 220, 38, 11, 68, 248, 190, 243, 246, 236, 174, 210, 39, 82, 12, 122, 121, 4, 69, 135, 21, 90, 88, 182, 136, 217, 116, 28, 203, 87, 151, 168, 132, 1, 242, 126, 31 }, new byte[] { 74, 173, 150, 99, 226, 116, 6, 160, 51, 120, 81, 50, 36, 251, 226, 146 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3168), new byte[] { 87, 244, 234, 164, 37, 207, 7, 211, 129, 163, 221, 8, 132, 119, 127, 29, 87, 208, 38, 96, 17, 80, 142, 224, 184, 68, 155, 173, 220, 38, 11, 68, 248, 190, 243, 246, 236, 174, 210, 39, 82, 12, 122, 121, 4, 69, 135, 21, 90, 88, 182, 136, 217, 116, 28, 203, 87, 151, 168, 132, 1, 242, 126, 31 }, new byte[] { 74, 173, 150, 99, 226, 116, 6, 160, 51, 120, 81, 50, 36, 251, 226, 146 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3170), new byte[] { 87, 244, 234, 164, 37, 207, 7, 211, 129, 163, 221, 8, 132, 119, 127, 29, 87, 208, 38, 96, 17, 80, 142, 224, 184, 68, 155, 173, 220, 38, 11, 68, 248, 190, 243, 246, 236, 174, 210, 39, 82, 12, 122, 121, 4, 69, 135, 21, 90, 88, 182, 136, 217, 116, 28, 203, 87, 151, 168, 132, 1, 242, 126, 31 }, new byte[] { 74, 173, 150, 99, 226, 116, 6, 160, 51, 120, 81, 50, 36, 251, 226, 146 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3171), new byte[] { 87, 244, 234, 164, 37, 207, 7, 211, 129, 163, 221, 8, 132, 119, 127, 29, 87, 208, 38, 96, 17, 80, 142, 224, 184, 68, 155, 173, 220, 38, 11, 68, 248, 190, 243, 246, 236, 174, 210, 39, 82, 12, 122, 121, 4, 69, 135, 21, 90, 88, 182, 136, 217, 116, 28, 203, 87, 151, 168, 132, 1, 242, 126, 31 }, new byte[] { 74, 173, 150, 99, 226, 116, 6, 160, 51, 120, 81, 50, 36, 251, 226, 146 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3172), new byte[] { 87, 244, 234, 164, 37, 207, 7, 211, 129, 163, 221, 8, 132, 119, 127, 29, 87, 208, 38, 96, 17, 80, 142, 224, 184, 68, 155, 173, 220, 38, 11, 68, 248, 190, 243, 246, 236, 174, 210, 39, 82, 12, 122, 121, 4, 69, 135, 21, 90, 88, 182, 136, 217, 116, 28, 203, 87, 151, 168, 132, 1, 242, 126, 31 }, new byte[] { 74, 173, 150, 99, 226, 116, 6, 160, 51, 120, 81, 50, 36, 251, 226, 146 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1447), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1452), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1457), new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(3348));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "UserDetail");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8800), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8808), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1142), new byte[] { 153, 243, 233, 97, 34, 173, 206, 77, 112, 23, 239, 31, 61, 103, 194, 88, 188, 172, 100, 9, 118, 13, 220, 72, 217, 179, 183, 212, 76, 202, 240, 165, 101, 107, 244, 87, 47, 146, 208, 58, 229, 48, 86, 66, 154, 158, 94, 201, 156, 195, 158, 205, 221, 129, 59, 63, 68, 85, 202, 224, 252, 170, 243, 5 }, new byte[] { 170, 220, 126, 19, 42, 210, 110, 30, 33, 55, 185, 11, 10, 254, 110, 116 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1144), new byte[] { 153, 243, 233, 97, 34, 173, 206, 77, 112, 23, 239, 31, 61, 103, 194, 88, 188, 172, 100, 9, 118, 13, 220, 72, 217, 179, 183, 212, 76, 202, 240, 165, 101, 107, 244, 87, 47, 146, 208, 58, 229, 48, 86, 66, 154, 158, 94, 201, 156, 195, 158, 205, 221, 129, 59, 63, 68, 85, 202, 224, 252, 170, 243, 5 }, new byte[] { 170, 220, 126, 19, 42, 210, 110, 30, 33, 55, 185, 11, 10, 254, 110, 116 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1146), new byte[] { 153, 243, 233, 97, 34, 173, 206, 77, 112, 23, 239, 31, 61, 103, 194, 88, 188, 172, 100, 9, 118, 13, 220, 72, 217, 179, 183, 212, 76, 202, 240, 165, 101, 107, 244, 87, 47, 146, 208, 58, 229, 48, 86, 66, 154, 158, 94, 201, 156, 195, 158, 205, 221, 129, 59, 63, 68, 85, 202, 224, 252, 170, 243, 5 }, new byte[] { 170, 220, 126, 19, 42, 210, 110, 30, 33, 55, 185, 11, 10, 254, 110, 116 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1147), new byte[] { 153, 243, 233, 97, 34, 173, 206, 77, 112, 23, 239, 31, 61, 103, 194, 88, 188, 172, 100, 9, 118, 13, 220, 72, 217, 179, 183, 212, 76, 202, 240, 165, 101, 107, 244, 87, 47, 146, 208, 58, 229, 48, 86, 66, 154, 158, 94, 201, 156, 195, 158, 205, 221, 129, 59, 63, 68, 85, 202, 224, 252, 170, 243, 5 }, new byte[] { 170, 220, 126, 19, 42, 210, 110, 30, 33, 55, 185, 11, 10, 254, 110, 116 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1148), new byte[] { 153, 243, 233, 97, 34, 173, 206, 77, 112, 23, 239, 31, 61, 103, 194, 88, 188, 172, 100, 9, 118, 13, 220, 72, 217, 179, 183, 212, 76, 202, 240, 165, 101, 107, 244, 87, 47, 146, 208, 58, 229, 48, 86, 66, 154, 158, 94, 201, 156, 195, 158, 205, 221, 129, 59, 63, 68, 85, 202, 224, 252, 170, 243, 5 }, new byte[] { 170, 220, 126, 19, 42, 210, 110, 30, 33, 55, 185, 11, 10, 254, 110, 116 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9895), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9905), new DateTime(2024, 8, 5, 16, 57, 36, 860, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 16, 57, 36, 861, DateTimeKind.Local).AddTicks(1363));
        }
    }
}
