using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "User",
                newName: "MobilePhone");

            migrationBuilder.RenameIndex(
                name: "IX_User_MobileNumber",
                table: "User",
                newName: "IX_User_MobilePhone");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MobilePhone",
                table: "User",
                newName: "MobileNumber");

            migrationBuilder.RenameIndex(
                name: "IX_User_MobilePhone",
                table: "User",
                newName: "IX_User_MobileNumber");

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
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 18, 8, 40, 826, DateTimeKind.Local).AddTicks(1307));

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
    }
}
