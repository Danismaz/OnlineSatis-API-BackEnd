using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForeignCurrency",
                columns: table => new
                {
                    ForeignCurrencyCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ForeignCurrencyLongName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                    JobName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    JobDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    JobPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                    MachineName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                    RoleDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                    UserTypeName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UserTypeDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                    ForeignCurrencyPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                name: "User",
                columns: table => new
                {
                    UserCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserTypeCode = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserCode);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeCode",
                        column: x => x.UserTypeCode,
                        principalTable: "UserType",
                        principalColumn: "UserTypeCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    TaxId = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    AuthorizedPerson = table.Column<string>(type: "text", nullable: true),
                    IdentityNumber = table.Column<string>(type: "text", nullable: true),
                    CompanyEmail = table.Column<string>(type: "text", nullable: true),
                    CompanyPhone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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
                name: "UserDetail",
                columns: table => new
                {
                    UserDetailCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IdentityNumber = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    MobilePhone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.UserDetailCode);
                    table.ForeignKey(
                        name: "FK_UserDetail_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserJob",
                columns: table => new
                {
                    UserJobCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    JobCode = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Piece = table.Column<int>(type: "integer", nullable: false),
                    JobPriceWithSpecialDiscount = table.Column<decimal>(type: "numeric", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    RoleCode = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleCode);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleCode",
                        column: x => x.RoleCode,
                        principalTable: "Role",
                        principalColumn: "RoleCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ForeignCurrency",
                columns: new[] { "ForeignCurrencyCode", "CreatedDate", "DeletedDate", "ForeignCurrencyLongName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8303), null, "Amerikan Doları", 1, null },
                    { 102L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8304), null, "Euro", 1, null },
                    { 103L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8305), null, "İngiliz Sterlini", 1, null },
                    { 104L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8306), null, "İsviçre Frangı", 1, null },
                    { 105L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8307), null, "Japon Yeni", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "JobCode", "CreatedDate", "DeletedDate", "JobDescription", "JobName", "JobPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8479), null, "Ofis temizliği", "Temizlik", 150.00m, 1, null },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8483), null, "Kargo gönderimi", "Kargo", 50.00m, 1, null },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8484), null, "Boya işçilik hizmeti", "Boya", 200.00m, 1, null },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8485), null, "Ekipman montajı", "Montaj", 100.00m, 1, null },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8486), null, "Bakım ve onarım", "Bakım", 80.00m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "MachineCode", "CreatedDate", "DeletedDate", "MachineName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8589), null, "Yazıcı", 1, null },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8590), null, "Faks Makinesi", 1, null },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8591), null, "Kopya Makinesi", 1, null },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8591), null, "Laminatör", 1, null },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8592), null, "Zımba Makinesi", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "ACCOUNTANT", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8714), null, "Muhasebeci", 1, null },
                    { "ADMIN", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8711), null, "Sistem yöneticisi", 1, null },
                    { "MANAGER", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8712), null, "Yönetici", 1, null },
                    { "STAFF", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8713), null, "Personel", 1, null },
                    { "SUPPORT", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8714), null, "Destek personeli", 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeCode", "CreatedDate", "DeletedDate", "Status", "UpdatedDate", "UserTypeDescription", "UserTypeName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9271), null, 1, null, "Sistem yöneticisi", "Admin" },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9273), null, 1, null, "Yönetici", "Manager" },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9274), null, 1, null, "Personel", "Staff" },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9275), null, 1, null, "Muhasebeci", "Accountant" },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9276), null, 1, null, "Destek personeli", "Support" }
                });

            migrationBuilder.InsertData(
                table: "DailyForeignCurrencyPrice",
                columns: new[] { "DailyForeignCurrencyPriceCode", "CreatedDate", "Date", "DeletedDate", "ForeignCurrencyCode", "ForeignCurrencyPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8175), null, 101L, 18.25m, 1, null },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8177), null, 102L, 7.55m, 1, null },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8179), null, 103L, 12.45m, 1, null },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8181), null, 104L, 0.85m, 1, null },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8182), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8183), null, 105L, 1.50m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobileNumber", "Status", "UpdatedDate", "UserTypeCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9162), null, "john.doe@example.com", "+905551234567", 1, null, 1L },
                    { 102L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9163), null, "jane.doe@example.com", "+905551234568", 1, null, 2L },
                    { 103L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9164), null, "alice.smith@example.com", "+905551234569", 1, null, 3L },
                    { 104L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9165), null, "bob.johnson@example.com", "+905551234570", 1, null, 4L },
                    { 105L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9166), null, "carol.davis@example.com", "+905551234571", 1, null, 5L }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyCode", "AuthorizedPerson", "CompanyEmail", "CompanyName", "CompanyPhone", "CreatedDate", "DeletedDate", "IdentityNumber", "Status", "TaxId", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, "Ahmet Yılmaz", "info@kirtasiyemerkezi.com", "Kırtasiye Merkezi", "+905551234567", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7924), null, "98765432101", 1, "12345678901", null, 101L },
                    { 2L, "Mehmet Demir", "info@ofismalzemeleri.com", "Ofis Malzemeleri", "+905551234568", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7938), null, "98765432102", 1, "12345678902", null, 102L },
                    { 3L, "Ayşe Kaya", "info@kirtasiyedunyasi.com", "Kırtasiye Dünyası", "+905551234569", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7939), null, "98765432103", 1, "12345678903", null, 103L },
                    { 4L, "Ali Çelik", "info@ofismerkezi.com", "Ofis Merkezi", "+905551234570", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7940), null, "98765432104", 1, "12345678904", null, 104L },
                    { 5L, "Fatma Yurt", "info@kirtasiyevi.com", "Kırtasiye Evi", "+905551234571", new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(7942), null, "98765432105", 1, "12345678905", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8828), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8830), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8832), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8833), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8835), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserJob",
                columns: new[] { "UserJobCode", "CreatedDate", "Date", "DeletedDate", "JobCode", "JobPriceWithSpecialDiscount", "Piece", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8941), null, 1L, 135.00m, 10, 1, null, 101L },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8944), null, 2L, 45.00m, 5, 1, null, 102L },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8946), null, 3L, 180.00m, 2, 1, null, 103L },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8948), null, 4L, 90.00m, 7, 1, null, 104L },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8950), new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(8950), null, 5L, 70.00m, 15, 1, null, 105L }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleCode", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9057), null, "ADMIN", 1, null, 101L },
                    { 2L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9058), null, "MANAGER", 1, null, 102L },
                    { 3L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9059), null, "STAFF", 1, null, 103L },
                    { 4L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9060), null, "ACCOUNTANT", 1, null, 104L },
                    { 5L, new DateTime(2024, 7, 25, 20, 7, 13, 792, DateTimeKind.Local).AddTicks(9061), null, "SUPPORT", 1, null, 105L }
                });

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
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MobileNumber",
                table: "User",
                column: "MobileNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeCode",
                table: "User",
                column: "UserTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_Email",
                table: "UserDetail",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_IdentityNumber",
                table: "UserDetail",
                column: "IdentityNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_UserCode",
                table: "UserDetail",
                column: "UserCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserJob_JobCode",
                table: "UserJob",
                column: "JobCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserJob_UserCode",
                table: "UserJob",
                column: "UserCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleCode",
                table: "UserRole",
                column: "RoleCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserCode",
                table: "UserRole",
                column: "UserCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "DailyForeignCurrencyPrice");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserJob");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "ForeignCurrency");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
