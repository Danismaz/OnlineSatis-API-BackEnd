using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT",
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5430), new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5432), new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5434), new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5435), new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5436), new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
