using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeCode",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleCode",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "DailyForeignCurrencyPrice");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserJob");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "ForeignCurrency");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_RoleCode",
                table: "UserRole");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "RoleCode",
                table: "UserRole");

            migrationBuilder.RenameColumn(
                name: "UserTypeCode",
                table: "User",
                newName: "UserRoleCode");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserTypeCode",
                table: "User",
                newName: "IX_User_UserRoleCode");

            migrationBuilder.AlterColumn<long>(
                name: "UserCode",
                table: "UserRole",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "RoleDescription",
                table: "UserRole",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(8640), new byte[] { 241, 26, 98, 132, 177, 65, 254, 61, 25, 131, 85, 79, 40, 122, 234, 237, 142, 10, 30, 101, 190, 12, 35, 90, 63, 70, 13, 177, 206, 204, 24, 68, 41, 225, 36, 131, 180, 179, 254, 70, 79, 13, 121, 152, 160, 118, 123, 170, 130, 200, 190, 108, 114, 174, 223, 250, 122, 207, 7, 128, 128, 156, 55, 111 }, new byte[] { 190, 156, 148, 79, 171, 228, 165, 58, 137, 240, 49, 187, 64, 215, 87, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(8650), new byte[] { 241, 26, 98, 132, 177, 65, 254, 61, 25, 131, 85, 79, 40, 122, 234, 237, 142, 10, 30, 101, 190, 12, 35, 90, 63, 70, 13, 177, 206, 204, 24, 68, 41, 225, 36, 131, 180, 179, 254, 70, 79, 13, 121, 152, 160, 118, 123, 170, 130, 200, 190, 108, 114, 174, 223, 250, 122, 207, 7, 128, 128, 156, 55, 111 }, new byte[] { 190, 156, 148, 79, 171, 228, 165, 58, 137, 240, 49, 187, 64, 215, 87, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(8650), new byte[] { 241, 26, 98, 132, 177, 65, 254, 61, 25, 131, 85, 79, 40, 122, 234, 237, 142, 10, 30, 101, 190, 12, 35, 90, 63, 70, 13, 177, 206, 204, 24, 68, 41, 225, 36, 131, 180, 179, 254, 70, 79, 13, 121, 152, 160, 118, 123, 170, 130, 200, 190, 108, 114, 174, 223, 250, 122, 207, 7, 128, 128, 156, 55, 111 }, new byte[] { 190, 156, 148, 79, 171, 228, 165, 58, 137, 240, 49, 187, 64, 215, 87, 11 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserRoleCode" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(8660), new byte[] { 241, 26, 98, 132, 177, 65, 254, 61, 25, 131, 85, 79, 40, 122, 234, 237, 142, 10, 30, 101, 190, 12, 35, 90, 63, 70, 13, 177, 206, 204, 24, 68, 41, 225, 36, 131, 180, 179, 254, 70, 79, 13, 121, 152, 160, 118, 123, 170, 130, 200, 190, 108, 114, 174, 223, 250, 122, 207, 7, 128, 128, 156, 55, 111 }, new byte[] { 190, 156, 148, 79, 171, 228, 165, 58, 137, 240, 49, 187, 64, 215, 87, 11 }, 3L });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserRoleCode" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(8660), new byte[] { 241, 26, 98, 132, 177, 65, 254, 61, 25, 131, 85, 79, 40, 122, 234, 237, 142, 10, 30, 101, 190, 12, 35, 90, 63, 70, 13, 177, 206, 204, 24, 68, 41, 225, 36, 131, 180, 179, 254, 70, 79, 13, 121, 152, 160, 118, 123, 170, 130, 200, 190, 108, 114, 174, 223, 250, 122, 207, 7, 128, 128, 156, 55, 111 }, new byte[] { 190, 156, 148, 79, 171, 228, 165, 58, 137, 240, 49, 187, 64, 215, 87, 11 }, 3L });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "RoleDescription", "UserCode" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7770), "Admin", null });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "RoleDescription", "UserCode" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7780), "Yönetici", null });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "RoleDescription", "UserCode" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 30, 1, 772, DateTimeKind.Local).AddTicks(7780), "Kullanici", null });

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_UserRoleCode",
                table: "User",
                column: "UserRoleCode",
                principalTable: "UserRole",
                principalColumn: "UserRoleCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole",
                column: "UserCode",
                principalTable: "User",
                principalColumn: "UserCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_UserRoleCode",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "RoleDescription",
                table: "UserRole");

            migrationBuilder.RenameColumn(
                name: "UserRoleCode",
                table: "User",
                newName: "UserTypeCode");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserRoleCode",
                table: "User",
                newName: "IX_User_UserTypeCode");

            migrationBuilder.AlterColumn<long>(
                name: "UserCode",
                table: "UserRole",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleCode",
                table: "UserRole",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    AuthorizedPerson = table.Column<string>(type: "text", nullable: true),
                    CompanyEmail = table.Column<string>(type: "text", nullable: true),
                    CompanyName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CompanyPhone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IdentityNumber = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TaxId = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyCode);
                    table.ForeignKey(
                        name: "FK_Company_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForeignCurrency",
                columns: table => new
                {
                    ForeignCurrencyCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ForeignCurrencyLongName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignCurrency", x => x.ForeignCurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    JobDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    JobName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    JobPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobCode);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    MachineCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MachineName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.MachineCode);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleCode = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RoleDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleCode);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UserTypeCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserTypeDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    UserTypeName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UserTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "DailyForeignCurrencyPrice",
                columns: table => new
                {
                    DailyForeignCurrencyPriceCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ForeignCurrencyCode = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ForeignCurrencyPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyForeignCurrencyPrice", x => x.DailyForeignCurrencyPriceCode);
                    table.ForeignKey(
                        name: "FK_DailyForeignCurrencyPrice_ForeignCurrency_ForeignCurrencyCo~",
                        column: x => x.ForeignCurrencyCode,
                        principalTable: "ForeignCurrency",
                        principalColumn: "ForeignCurrencyCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserJob",
                columns: table => new
                {
                    UserJobCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobCode = table.Column<long>(type: "bigint", nullable: false),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    JobPriceWithSpecialDiscount = table.Column<decimal>(type: "numeric", nullable: true),
                    Piece = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJob", x => x.UserJobCode);
                    table.ForeignKey(
                        name: "FK_UserJob_Job_JobCode",
                        column: x => x.JobCode,
                        principalTable: "Job",
                        principalColumn: "JobCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserJob_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyCode", "AuthorizedPerson", "CompanyEmail", "CompanyName", "CompanyPhone", "CreatedDate", "DeletedDate", "IdentityNumber", "Status", "TaxId", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, "Ahmet Yılmaz", "info@kirtasiyemerkezi.com", "Kırtasiye Merkezi", "+905551234567", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(6930), null, "98765432101", 1, "12345678901", null, 101L },
                    { 2L, "Mehmet Demir", "info@ofismalzemeleri.com", "Ofis Malzemeleri", "+905551234568", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(6970), null, "98765432102", 1, "12345678902", null, 102L },
                    { 3L, "Ayşe Kaya", "info@kirtasiyedunyasi.com", "Kırtasiye Dünyası", "+905551234569", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(6970), null, "98765432103", 1, "12345678903", null, 103L },
                    { 4L, "Ali Çelik", "info@ofismerkezi.com", "Ofis Merkezi", "+905551234570", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(6970), null, "98765432104", 1, "12345678904", null, 104L },
                    { 5L, "Fatma Yurt", "info@kirtasiyevi.com", "Kırtasiye Evi", "+905551234571", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(6970), null, "98765432105", 1, "12345678905", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "ForeignCurrency",
                columns: new[] { "ForeignCurrencyCode", "CreatedDate", "DeletedDate", "ForeignCurrencyLongName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7160), null, "Amerikan Doları", 1, null },
                    { 102L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7170), null, "Euro", 1, null },
                    { 103L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7170), null, "İngiliz Sterlini", 1, null },
                    { 104L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7170), null, "İsviçre Frangı", 1, null },
                    { 105L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7170), null, "Japon Yeni", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobCode", "CreatedDate", "DeletedDate", "JobDescription", "JobName", "JobPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7220), null, "Ofis temizliği", "Temizlik", 150.00m, 1, null },
                    { 2L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7220), null, "Kargo gönderimi", "Kargo", 50.00m, 1, null },
                    { 3L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7230), null, "Boya işçilik hizmeti", "Boya", 200.00m, 1, null },
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7230), null, "Ekipman montajı", "Montaj", 100.00m, 1, null },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7230), null, "Bakım ve onarım", "Bakım", 80.00m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "MachineCode", "CreatedDate", "DeletedDate", "MachineName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7280), null, "Yazıcı", 1, null },
                    { 2L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7290), null, "Faks Makinesi", 1, null },
                    { 3L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7290), null, "Kopya Makinesi", 1, null },
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7290), null, "Laminatör", 1, null },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7290), null, "Zımba Makinesi", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "ACCOUNTANT", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7350), null, "Muhasebeci", 1, null },
                    { "ADMIN", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7340), null, "Sistem yöneticisi", 1, null },
                    { "MANAGER", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7340), null, "Yönetici", 1, null },
                    { "STAFF", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7340), null, "Personel", 1, null },
                    { "SUPPORT", new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7350), null, "Destek personeli", 1, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8230), new byte[] { 234, 208, 22, 155, 85, 131, 250, 48, 28, 232, 95, 38, 175, 124, 205, 162, 124, 149, 45, 246, 1, 106, 74, 59, 85, 53, 68, 105, 101, 40, 65, 206, 208, 68, 191, 114, 183, 183, 28, 87, 119, 139, 132, 197, 61, 157, 228, 231, 90, 92, 179, 150, 247, 74, 177, 148, 231, 74, 181, 213, 60, 186, 110, 219 }, new byte[] { 87, 11, 47, 234, 86, 178, 45, 108, 99, 216, 132, 253, 72, 216, 79, 172 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8230), new byte[] { 234, 208, 22, 155, 85, 131, 250, 48, 28, 232, 95, 38, 175, 124, 205, 162, 124, 149, 45, 246, 1, 106, 74, 59, 85, 53, 68, 105, 101, 40, 65, 206, 208, 68, 191, 114, 183, 183, 28, 87, 119, 139, 132, 197, 61, 157, 228, 231, 90, 92, 179, 150, 247, 74, 177, 148, 231, 74, 181, 213, 60, 186, 110, 219 }, new byte[] { 87, 11, 47, 234, 86, 178, 45, 108, 99, 216, 132, 253, 72, 216, 79, 172 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8230), new byte[] { 234, 208, 22, 155, 85, 131, 250, 48, 28, 232, 95, 38, 175, 124, 205, 162, 124, 149, 45, 246, 1, 106, 74, 59, 85, 53, 68, 105, 101, 40, 65, 206, 208, 68, 191, 114, 183, 183, 28, 87, 119, 139, 132, 197, 61, 157, 228, 231, 90, 92, 179, 150, 247, 74, 177, 148, 231, 74, 181, 213, 60, 186, 110, 219 }, new byte[] { 87, 11, 47, 234, 86, 178, 45, 108, 99, 216, 132, 253, 72, 216, 79, 172 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserTypeCode" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8240), new byte[] { 234, 208, 22, 155, 85, 131, 250, 48, 28, 232, 95, 38, 175, 124, 205, 162, 124, 149, 45, 246, 1, 106, 74, 59, 85, 53, 68, 105, 101, 40, 65, 206, 208, 68, 191, 114, 183, 183, 28, 87, 119, 139, 132, 197, 61, 157, 228, 231, 90, 92, 179, 150, 247, 74, 177, 148, 231, 74, 181, 213, 60, 186, 110, 219 }, new byte[] { 87, 11, 47, 234, 86, 178, 45, 108, 99, 216, 132, 253, 72, 216, 79, 172 }, 4L });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt", "UserTypeCode" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8240), new byte[] { 234, 208, 22, 155, 85, 131, 250, 48, 28, 232, 95, 38, 175, 124, 205, 162, 124, 149, 45, 246, 1, 106, 74, 59, 85, 53, 68, 105, 101, 40, 65, 206, 208, 68, 191, 114, 183, 183, 28, 87, 119, 139, 132, 197, 61, 157, 228, 231, 90, 92, 179, 150, 247, 74, 177, 148, 231, 74, 181, 213, 60, 186, 110, 219 }, new byte[] { 87, 11, 47, 234, 86, 178, 45, 108, 99, 216, 132, 253, 72, 216, 79, 172 }, 5L });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "RoleCode", "UserCode" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7580), "ADMIN", 101L });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "RoleCode", "UserCode" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7580), "MANAGER", 102L });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "RoleCode", "UserCode" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7580), "STAFF", 103L });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeCode", "CreatedDate", "DeletedDate", "Status", "UpdatedDate", "UserTypeDescription", "UserTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8300), null, 1, null, "Sistem yöneticisi", "Admin" },
                    { 2L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8300), null, 1, null, "Yönetici", "Manager" },
                    { 3L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8310), null, 1, null, "Personel", "Staff" },
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8310), null, 1, null, "Muhasebeci", "Accountant" },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(8310), null, 1, null, "Destek personeli", "Support" }
                });

            migrationBuilder.InsertData(
                table: "DailyForeignCurrencyPrice",
                columns: new[] { "DailyForeignCurrencyPriceCode", "CreatedDate", "Date", "DeletedDate", "ForeignCurrencyCode", "ForeignCurrencyPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7100), null, 101L, 18.25m, 1, null },
                    { 2L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7100), null, 102L, 7.55m, 1, null },
                    { 3L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), null, 103L, 12.45m, 1, null },
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), null, 104L, 0.85m, 1, null },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7110), null, 105L, 1.50m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserJob",
                columns: new[] { "UserJobCode", "CreatedDate", "Date", "DeletedDate", "JobCode", "JobPriceWithSpecialDiscount", "Piece", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7470), null, 1L, 135.00m, 10, 1, null, 101L },
                    { 2L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7480), null, 2L, 45.00m, 5, 1, null, 102L },
                    { 3L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7480), null, 3L, 180.00m, 2, 1, null, 103L },
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7490), null, 4L, 90.00m, 7, 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7490), null, 5L, 70.00m, 15, 1, null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleCode", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 4L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7580), null, "ACCOUNTANT", 1, null, 104L },
                    { 5L, new DateTime(2024, 8, 27, 15, 7, 44, 871, DateTimeKind.Local).AddTicks(7580), null, "SUPPORT", 1, null, 105L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleCode",
                table: "UserRole",
                column: "RoleCode");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AuthorizedPerson",
                table: "Company",
                column: "AuthorizedPerson",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_IdentityNumber",
                table: "Company",
                column: "IdentityNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_TaxId",
                table: "Company",
                column: "TaxId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserCode",
                table: "Company",
                column: "UserCode");

            migrationBuilder.CreateIndex(
                name: "IX_DailyForeignCurrencyPrice_ForeignCurrencyCode",
                table: "DailyForeignCurrencyPrice",
                column: "ForeignCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignCurrency_ForeignCurrencyCode",
                table: "ForeignCurrency",
                column: "ForeignCurrencyCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleCode",
                table: "Role",
                column: "RoleCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserJob_JobCode",
                table: "UserJob",
                column: "JobCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserJob_UserCode",
                table: "UserJob",
                column: "UserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeCode",
                table: "User",
                column: "UserTypeCode",
                principalTable: "UserType",
                principalColumn: "UserTypeCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleCode",
                table: "UserRole",
                column: "RoleCode",
                principalTable: "Role",
                principalColumn: "RoleCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole",
                column: "UserCode",
                principalTable: "User",
                principalColumn: "UserCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
