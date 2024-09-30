using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
