using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUniqueColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4046), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6431), new byte[] { 221, 124, 97, 98, 61, 65, 119, 207, 111, 27, 32, 168, 191, 105, 232, 199, 181, 122, 99, 52, 14, 216, 83, 184, 188, 137, 139, 225, 43, 62, 255, 154, 26, 161, 199, 24, 144, 221, 116, 117, 250, 99, 120, 61, 195, 181, 147, 56, 169, 165, 34, 166, 154, 146, 146, 28, 192, 58, 98, 48, 215, 112, 49, 152 }, new byte[] { 34, 225, 56, 105, 242, 187, 71, 110, 122, 169, 168, 251, 220, 184, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6433), new byte[] { 221, 124, 97, 98, 61, 65, 119, 207, 111, 27, 32, 168, 191, 105, 232, 199, 181, 122, 99, 52, 14, 216, 83, 184, 188, 137, 139, 225, 43, 62, 255, 154, 26, 161, 199, 24, 144, 221, 116, 117, 250, 99, 120, 61, 195, 181, 147, 56, 169, 165, 34, 166, 154, 146, 146, 28, 192, 58, 98, 48, 215, 112, 49, 152 }, new byte[] { 34, 225, 56, 105, 242, 187, 71, 110, 122, 169, 168, 251, 220, 184, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6434), new byte[] { 221, 124, 97, 98, 61, 65, 119, 207, 111, 27, 32, 168, 191, 105, 232, 199, 181, 122, 99, 52, 14, 216, 83, 184, 188, 137, 139, 225, 43, 62, 255, 154, 26, 161, 199, 24, 144, 221, 116, 117, 250, 99, 120, 61, 195, 181, 147, 56, 169, 165, 34, 166, 154, 146, 146, 28, 192, 58, 98, 48, 215, 112, 49, 152 }, new byte[] { 34, 225, 56, 105, 242, 187, 71, 110, 122, 169, 168, 251, 220, 184, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6436), new byte[] { 221, 124, 97, 98, 61, 65, 119, 207, 111, 27, 32, 168, 191, 105, 232, 199, 181, 122, 99, 52, 14, 216, 83, 184, 188, 137, 139, 225, 43, 62, 255, 154, 26, 161, 199, 24, 144, 221, 116, 117, 250, 99, 120, 61, 195, 181, 147, 56, 169, 165, 34, 166, 154, 146, 146, 28, 192, 58, 98, 48, 215, 112, 49, 152 }, new byte[] { 34, 225, 56, 105, 242, 187, 71, 110, 122, 169, 168, 251, 220, 184, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6437), new byte[] { 221, 124, 97, 98, 61, 65, 119, 207, 111, 27, 32, 168, 191, 105, 232, 199, 181, 122, 99, 52, 14, 216, 83, 184, 188, 137, 139, 225, 43, 62, 255, 154, 26, 161, 199, 24, 144, 221, 116, 117, 250, 99, 120, 61, 195, 181, 147, 56, 169, 165, 34, 166, 154, 146, 146, 28, 192, 58, 98, 48, 215, 112, 49, 152 }, new byte[] { 34, 225, 56, 105, 242, 187, 71, 110, 122, 169, 168, 251, 220, 184, 40, 205 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 9, 44, 311, DateTimeKind.Local).AddTicks(6599));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5796), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9287), new byte[] { 197, 252, 254, 28, 192, 43, 78, 150, 147, 164, 122, 127, 151, 34, 66, 40, 138, 83, 8, 26, 96, 221, 102, 68, 128, 226, 213, 239, 80, 210, 243, 110, 212, 108, 78, 226, 96, 204, 66, 19, 158, 121, 20, 111, 100, 177, 96, 169, 10, 7, 18, 117, 216, 43, 250, 25, 68, 231, 166, 46, 140, 47, 232, 204 }, new byte[] { 159, 19, 213, 19, 120, 132, 221, 160, 183, 125, 104, 100, 86, 236, 104, 14 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9292), new byte[] { 197, 252, 254, 28, 192, 43, 78, 150, 147, 164, 122, 127, 151, 34, 66, 40, 138, 83, 8, 26, 96, 221, 102, 68, 128, 226, 213, 239, 80, 210, 243, 110, 212, 108, 78, 226, 96, 204, 66, 19, 158, 121, 20, 111, 100, 177, 96, 169, 10, 7, 18, 117, 216, 43, 250, 25, 68, 231, 166, 46, 140, 47, 232, 204 }, new byte[] { 159, 19, 213, 19, 120, 132, 221, 160, 183, 125, 104, 100, 86, 236, 104, 14 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9294), new byte[] { 197, 252, 254, 28, 192, 43, 78, 150, 147, 164, 122, 127, 151, 34, 66, 40, 138, 83, 8, 26, 96, 221, 102, 68, 128, 226, 213, 239, 80, 210, 243, 110, 212, 108, 78, 226, 96, 204, 66, 19, 158, 121, 20, 111, 100, 177, 96, 169, 10, 7, 18, 117, 216, 43, 250, 25, 68, 231, 166, 46, 140, 47, 232, 204 }, new byte[] { 159, 19, 213, 19, 120, 132, 221, 160, 183, 125, 104, 100, 86, 236, 104, 14 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9296), new byte[] { 197, 252, 254, 28, 192, 43, 78, 150, 147, 164, 122, 127, 151, 34, 66, 40, 138, 83, 8, 26, 96, 221, 102, 68, 128, 226, 213, 239, 80, 210, 243, 110, 212, 108, 78, 226, 96, 204, 66, 19, 158, 121, 20, 111, 100, 177, 96, 169, 10, 7, 18, 117, 216, 43, 250, 25, 68, 231, 166, 46, 140, 47, 232, 204 }, new byte[] { 159, 19, 213, 19, 120, 132, 221, 160, 183, 125, 104, 100, 86, 236, 104, 14 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9298), new byte[] { 197, 252, 254, 28, 192, 43, 78, 150, 147, 164, 122, 127, 151, 34, 66, 40, 138, 83, 8, 26, 96, 221, 102, 68, 128, 226, 213, 239, 80, 210, 243, 110, 212, 108, 78, 226, 96, 204, 66, 19, 158, 121, 20, 111, 100, 177, 96, 169, 10, 7, 18, 117, 216, 43, 250, 25, 68, 231, 166, 46, 140, 47, 232, 204 }, new byte[] { 159, 19, 213, 19, 120, 132, 221, 160, 183, 125, 104, 100, 86, 236, 104, 14 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 12, 53, 23, 505, DateTimeKind.Local).AddTicks(9557));
        }
    }
}
