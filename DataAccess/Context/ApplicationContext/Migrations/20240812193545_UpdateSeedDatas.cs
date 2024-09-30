using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "CompanyCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DailyForeignCurrencyPrice",
                keyColumn: "DailyForeignCurrencyPriceCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "MachineCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserJob",
                keyColumn: "UserJobCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ForeignCurrency",
                keyColumn: "ForeignCurrencyCode",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "JobCode",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ACCOUNTANT");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "ADMIN");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "MANAGER");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "STAFF");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleCode",
                keyValue: "SUPPORT");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeCode",
                keyValue: 5L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForeignCurrency",
                columns: new[] { "ForeignCurrencyCode", "CreatedDate", "DeletedDate", "ForeignCurrencyLongName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3263), null, "Amerikan Doları", 1, null },
                    { 102L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3264), null, "Euro", 1, null },
                    { 103L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3265), null, "İngiliz Sterlini", 1, null },
                    { 104L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3266), null, "İsviçre Frangı", 1, null },
                    { 105L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3267), null, "Japon Yeni", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobCode", "CreatedDate", "DeletedDate", "JobDescription", "JobName", "JobPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3514), null, "Ofis temizliği", "Temizlik", 150.00m, 1, null },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3517), null, "Kargo gönderimi", "Kargo", 50.00m, 1, null },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3518), null, "Boya işçilik hizmeti", "Boya", 200.00m, 1, null },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3519), null, "Ekipman montajı", "Montaj", 100.00m, 1, null },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3528), null, "Bakım ve onarım", "Bakım", 80.00m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "MachineCode", "CreatedDate", "DeletedDate", "MachineName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3722), null, "Yazıcı", 1, null },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3724), null, "Faks Makinesi", 1, null },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3725), null, "Kopya Makinesi", 1, null },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3726), null, "Laminatör", 1, null },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3727), null, "Zımba Makinesi", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "ACCOUNTANT", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3858), null, "Muhasebeci", 1, null },
                    { "ADMIN", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3855), null, "Sistem yöneticisi", 1, null },
                    { "MANAGER", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3856), null, "Yönetici", 1, null },
                    { "STAFF", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3857), null, "Personel", 1, null },
                    { "SUPPORT", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3859), null, "Destek personeli", 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeCode", "CreatedDate", "DeletedDate", "Status", "UpdatedDate", "UserTypeDescription", "UserTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5632), null, 1, null, "Sistem yöneticisi", "Admin" },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5634), null, 1, null, "Yönetici", "Manager" },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5635), null, 1, null, "Personel", "Staff" },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5636), null, 1, null, "Muhasebeci", "Accountant" },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5637), null, 1, null, "Destek personeli", "Support" }
                });

            migrationBuilder.InsertData(
                table: "DailyForeignCurrencyPrice",
                columns: new[] { "DailyForeignCurrencyPriceCode", "CreatedDate", "Date", "DeletedDate", "ForeignCurrencyCode", "ForeignCurrencyPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3110), null, 101L, 18.25m, 1, null },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3112), null, 102L, 7.55m, 1, null },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3114), null, 103L, 12.45m, 1, null },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3116), null, 104L, 0.85m, 1, null },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3118), null, 105L, 1.50m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate", "UserTypeCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5430), null, "john.doe@example.com", "+905551234567", new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 }, 1, null, 1L },
                    { 102L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5432), null, "jane.doe@example.com", "+905551234568", new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 }, 1, null, 2L },
                    { 103L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5434), null, "alice.smith@example.com", "+905551234569", new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 }, 1, null, 3L },
                    { 104L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5435), null, "bob.johnson@example.com", "+905551234570", new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 }, 1, null, 4L },
                    { 105L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(5436), null, "carol.davis@example.com", "+905551234571", new byte[] { 172, 206, 15, 169, 168, 144, 38, 241, 114, 197, 125, 2, 46, 136, 198, 190, 216, 114, 162, 110, 159, 77, 224, 24, 237, 80, 205, 83, 141, 74, 70, 0, 172, 204, 157, 193, 246, 37, 176, 154, 251, 146, 138, 181, 168, 137, 124, 76, 142, 130, 228, 194, 101, 46, 104, 104, 174, 129, 158, 194, 166, 12, 231, 51 }, new byte[] { 116, 194, 78, 191, 67, 181, 250, 172, 29, 110, 226, 6, 73, 172, 202, 30 }, 1, null, 5L }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyCode", "AuthorizedPerson", "CompanyEmail", "CompanyName", "CompanyPhone", "CreatedDate", "DeletedDate", "IdentityNumber", "Status", "TaxId", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, "Ahmet Yılmaz", "info@kirtasiyemerkezi.com", "Kırtasiye Merkezi", "+905551234567", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2743), null, "98765432101", 1, "12345678901", null, 101L },
                    { 2L, "Mehmet Demir", "info@ofismalzemeleri.com", "Ofis Malzemeleri", "+905551234568", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2764), null, "98765432102", 1, "12345678902", null, 102L },
                    { 3L, "Ayşe Kaya", "info@kirtasiyedunyasi.com", "Kırtasiye Dünyası", "+905551234569", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2766), null, "98765432103", 1, "12345678903", null, 103L },
                    { 4L, "Ali Çelik", "info@ofismerkezi.com", "Ofis Merkezi", "+905551234570", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2767), null, "98765432104", 1, "12345678904", null, 104L },
                    { 5L, "Fatma Yurt", "info@kirtasiyevi.com", "Kırtasiye Evi", "+905551234571", new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(2769), null, "98765432105", 1, "12345678905", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3985), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3993), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3995), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3996), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(3998), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserJob",
                columns: new[] { "UserJobCode", "CreatedDate", "Date", "DeletedDate", "JobCode", "JobPriceWithSpecialDiscount", "Piece", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4140), null, 1L, 135.00m, 10, 1, null, 101L },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4144), null, 2L, 45.00m, 5, 1, null, 102L },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4147), null, 3L, 180.00m, 2, 1, null, 103L },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4149), null, 4L, 90.00m, 7, 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4151), null, 5L, 70.00m, 15, 1, null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleCode", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4321), null, "ADMIN", 1, null, 101L },
                    { 2L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4326), null, "MANAGER", 1, null, 102L },
                    { 3L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4327), null, "STAFF", 1, null, 103L },
                    { 4L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4328), null, "ACCOUNTANT", 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 12, 16, 42, 30, 673, DateTimeKind.Local).AddTicks(4329), null, "SUPPORT", 1, null, 105L }
                });
        }
    }
}
