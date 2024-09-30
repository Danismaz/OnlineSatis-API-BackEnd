using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateUniqueColumnss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
