using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDatass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForeignCurrency",
                columns: new[] { "ForeignCurrencyCode", "CreatedDate", "DeletedDate", "ForeignCurrencyLongName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2655), null, "Amerikan Doları", 1, null },
                    { 102L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2656), null, "Euro", 1, null },
                    { 103L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2657), null, "İngiliz Sterlini", 1, null },
                    { 104L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2658), null, "İsviçre Frangı", 1, null },
                    { 105L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2659), null, "Japon Yeni", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobCode", "CreatedDate", "DeletedDate", "JobDescription", "JobName", "JobPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2779), null, "Ofis temizliği", "Temizlik", 150.00m, 1, null },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2781), null, "Kargo gönderimi", "Kargo", 50.00m, 1, null },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2782), null, "Boya işçilik hizmeti", "Boya", 200.00m, 1, null },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2783), null, "Ekipman montajı", "Montaj", 100.00m, 1, null },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2788), null, "Bakım ve onarım", "Bakım", 80.00m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "MachineCode", "CreatedDate", "DeletedDate", "MachineName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2933), null, "Yazıcı", 1, null },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2935), null, "Faks Makinesi", 1, null },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2936), null, "Kopya Makinesi", 1, null },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2937), null, "Laminatör", 1, null },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2938), null, "Zımba Makinesi", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "ACCOUNTANT", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3134), null, "Muhasebeci", 1, null },
                    { "ADMIN", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3131), null, "Sistem yöneticisi", 1, null },
                    { "MANAGER", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3132), null, "Yönetici", 1, null },
                    { "STAFF", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3133), null, "Personel", 1, null },
                    { "SUPPORT", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3135), null, "Destek personeli", 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeCode", "CreatedDate", "DeletedDate", "Status", "UpdatedDate", "UserTypeDescription", "UserTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5466), null, 1, null, "Sistem yöneticisi", "Admin" },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5468), null, 1, null, "Yönetici", "Manager" },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5468), null, 1, null, "Personel", "Staff" },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5469), null, 1, null, "Muhasebeci", "Accountant" },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5470), null, 1, null, "Destek personeli", "Support" }
                });

            migrationBuilder.InsertData(
                table: "DailyForeignCurrencyPrice",
                columns: new[] { "DailyForeignCurrencyPriceCode", "CreatedDate", "Date", "DeletedDate", "ForeignCurrencyCode", "ForeignCurrencyPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2526), null, 101L, 18.25m, 1, null },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2528), null, 102L, 7.55m, 1, null },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2530), null, 103L, 12.45m, 1, null },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2532), null, 104L, 0.85m, 1, null },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2534), null, 105L, 1.50m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate", "UserTypeCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5250), null, "john.doe@example.com", "+905551234567", new byte[] { 157, 134, 32, 68, 83, 57, 96, 47, 219, 147, 81, 254, 27, 168, 228, 2, 243, 75, 224, 212, 169, 212, 209, 228, 48, 204, 91, 86, 152, 153, 56, 99, 27, 75, 171, 184, 45, 232, 79, 199, 32, 250, 55, 178, 158, 147, 80, 236, 153, 58, 91, 238, 179, 146, 93, 174, 174, 242, 36, 91, 13, 215, 98, 40 }, new byte[] { 203, 200, 163, 170, 61, 57, 113, 134, 179, 31, 117, 222, 60, 8, 221, 215 }, 1, null, 1L },
                    { 102L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5253), null, "jane.doe@example.com", "+905551234568", new byte[] { 157, 134, 32, 68, 83, 57, 96, 47, 219, 147, 81, 254, 27, 168, 228, 2, 243, 75, 224, 212, 169, 212, 209, 228, 48, 204, 91, 86, 152, 153, 56, 99, 27, 75, 171, 184, 45, 232, 79, 199, 32, 250, 55, 178, 158, 147, 80, 236, 153, 58, 91, 238, 179, 146, 93, 174, 174, 242, 36, 91, 13, 215, 98, 40 }, new byte[] { 203, 200, 163, 170, 61, 57, 113, 134, 179, 31, 117, 222, 60, 8, 221, 215 }, 1, null, 2L },
                    { 103L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5255), null, "alice.smith@example.com", "+905551234569", new byte[] { 157, 134, 32, 68, 83, 57, 96, 47, 219, 147, 81, 254, 27, 168, 228, 2, 243, 75, 224, 212, 169, 212, 209, 228, 48, 204, 91, 86, 152, 153, 56, 99, 27, 75, 171, 184, 45, 232, 79, 199, 32, 250, 55, 178, 158, 147, 80, 236, 153, 58, 91, 238, 179, 146, 93, 174, 174, 242, 36, 91, 13, 215, 98, 40 }, new byte[] { 203, 200, 163, 170, 61, 57, 113, 134, 179, 31, 117, 222, 60, 8, 221, 215 }, 1, null, 3L },
                    { 104L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5256), null, "bob.johnson@example.com", "+905551234570", new byte[] { 157, 134, 32, 68, 83, 57, 96, 47, 219, 147, 81, 254, 27, 168, 228, 2, 243, 75, 224, 212, 169, 212, 209, 228, 48, 204, 91, 86, 152, 153, 56, 99, 27, 75, 171, 184, 45, 232, 79, 199, 32, 250, 55, 178, 158, 147, 80, 236, 153, 58, 91, 238, 179, 146, 93, 174, 174, 242, 36, 91, 13, 215, 98, 40 }, new byte[] { 203, 200, 163, 170, 61, 57, 113, 134, 179, 31, 117, 222, 60, 8, 221, 215 }, 1, null, 4L },
                    { 105L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(5258), null, "carol.davis@example.com", "+905551234571", new byte[] { 157, 134, 32, 68, 83, 57, 96, 47, 219, 147, 81, 254, 27, 168, 228, 2, 243, 75, 224, 212, 169, 212, 209, 228, 48, 204, 91, 86, 152, 153, 56, 99, 27, 75, 171, 184, 45, 232, 79, 199, 32, 250, 55, 178, 158, 147, 80, 236, 153, 58, 91, 238, 179, 146, 93, 174, 174, 242, 36, 91, 13, 215, 98, 40 }, new byte[] { 203, 200, 163, 170, 61, 57, 113, 134, 179, 31, 117, 222, 60, 8, 221, 215 }, 1, null, 5L }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyCode", "AuthorizedPerson", "CompanyEmail", "CompanyName", "CompanyPhone", "CreatedDate", "DeletedDate", "IdentityNumber", "Status", "TaxId", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, "Ahmet Yılmaz", "info@kirtasiyemerkezi.com", "Kırtasiye Merkezi", "+905551234567", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2123), null, "98765432101", 1, "12345678901", null, 101L },
                    { 2L, "Mehmet Demir", "info@ofismalzemeleri.com", "Ofis Malzemeleri", "+905551234568", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2138), null, "98765432102", 1, "12345678902", null, 102L },
                    { 3L, "Ayşe Kaya", "info@kirtasiyedunyasi.com", "Kırtasiye Dünyası", "+905551234569", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2139), null, "98765432103", 1, "12345678903", null, 103L },
                    { 4L, "Ali Çelik", "info@ofismerkezi.com", "Ofis Merkezi", "+905551234570", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2141), null, "98765432104", 1, "12345678904", null, 104L },
                    { 5L, "Fatma Yurt", "info@kirtasiyevi.com", "Kırtasiye Evi", "+905551234571", new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(2142), null, "98765432105", 1, "12345678905", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3272), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3281), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3283), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3285), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3287), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserJob",
                columns: new[] { "UserJobCode", "CreatedDate", "Date", "DeletedDate", "JobCode", "JobPriceWithSpecialDiscount", "Piece", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3435), null, 1L, 135.00m, 10, 1, null, 101L },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3438), null, 2L, 45.00m, 5, 1, null, 102L },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3440), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3441), null, 3L, 180.00m, 2, 1, null, 103L },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3443), null, 4L, 90.00m, 7, 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3445), null, 5L, 70.00m, 15, 1, null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleCode", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3568), null, "ADMIN", 1, null, 101L },
                    { 2L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3569), null, "MANAGER", 1, null, 102L },
                    { 3L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3570), null, "STAFF", 1, null, 103L },
                    { 4L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3571), null, "ACCOUNTANT", 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 12, 22, 37, 33, 233, DateTimeKind.Local).AddTicks(3572), null, "SUPPORT", 1, null, 105L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
