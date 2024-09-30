using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    CategoryDescription = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryCode);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    ShipperCode = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShipperName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DeliveryTime = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.ShipperCode);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ShipperCode = table.Column<int>(type: "integer", nullable: false),
                    UserCode = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderCode);
                    table.ForeignKey(
                        name: "FK_Order_Shipper_ShipperCode",
                        column: x => x.ShipperCode,
                        principalTable: "Shipper",
                        principalColumn: "ShipperCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    OrderCode = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailCode);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderCode",
                        column: x => x.OrderCode,
                        principalTable: "Order",
                        principalColumn: "OrderCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    OrderDetailCode = table.Column<long>(type: "bigint", nullable: true),
                    ShipperCode = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductCode);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "CategoryCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_OrderDetail_OrderDetailCode",
                        column: x => x.OrderDetailCode,
                        principalTable: "OrderDetail",
                        principalColumn: "OrderDetailCode");
                    table.ForeignKey(
                        name: "FK_Product_Shipper_ShipperCode",
                        column: x => x.ShipperCode,
                        principalTable: "Shipper",
                        principalColumn: "ShipperCode");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserRoleCode = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    MobilePhone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserCode);
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
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                name: "UserRole",
                columns: table => new
                {
                    UserRoleCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    UserCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleCode);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryCode", "CategoryDescription", "CategoryName", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, "Farklı türde kalemler.", "Kalemler", new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4361), null, 1, null },
                    { 2L, "Çeşitli defter türleri.", "Defterler", new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4363), null, 1, null },
                    { 3L, "Ofis için gerekli malzemeler.", "Ofis Malzemeleri", new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4364), null, 1, null },
                    { 4L, "Resim ve sanat malzemeleri.", "Sanat Malzemeleri", new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4365), null, 1, null },
                    { 5L, "Farklı tür yapıştırıcılar.", "Yapıştırıcılar", new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4366), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(4082), null, "Admin", 1, null, null },
                    { 2L, new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(4085), null, "Yönetici", 1, null, null },
                    { 3L, new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(4086), null, "Kullanici", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductCode", "CategoryCode", "CreatedDate", "DeletedDate", "OrderDetailCode", "ProductName", "ProductPrice", "ShipperCode", "Status", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4456), null, null, "Kurşun Kalem", 40m, null, 1, 100, null },
                    { 2L, 1L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4463), null, null, "Mavi Renkli Kalem", 80m, null, 1, 80, null },
                    { 3L, 1L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4464), null, null, "Kırmızı Jel Kalem", 90m, null, 1, 60, null },
                    { 4L, 1L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4465), null, null, "Siyah Mürekkep Kalem", 100m, null, 1, 40, null },
                    { 5L, 1L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4466), null, null, "Renkli Silgi", 25m, null, 1, 120, null },
                    { 6L, 2L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4467), null, null, "A5 Kırmızı Defter", 150m, null, 1, 200, null },
                    { 7L, 2L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4468), null, null, "A4 Beyaz Defter", 85m, null, 1, 150, null },
                    { 8L, 2L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4469), null, null, "Kareli Defter", 120m, null, 1, 100, null },
                    { 9L, 2L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4470), null, null, "Çizgili Defter", 120m, null, 1, 90, null },
                    { 10L, 2L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4471), null, null, "Sert Kapaklı Defter", 160m, null, 1, 50, null },
                    { 11L, 3L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4473), null, null, "Zımba Makinesi", 90m, null, 1, 30, null },
                    { 12L, 3L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4474), null, null, "Bant Dispenseri", 45m, null, 1, 70, null },
                    { 13L, 3L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4475), null, null, "Makas", 55m, null, 1, 40, null },
                    { 14L, 3L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4476), null, null, "Post-it Notlar", 75m, null, 1, 200, null },
                    { 15L, 3L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4477), null, null, "Kalemtraş", 20m, null, 1, 100, null },
                    { 16L, 4L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4478), null, null, "Akrilik Boya Seti", 165m, null, 1, 20, null },
                    { 17L, 4L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4479), null, null, "Su Renkleri Seti", 145m, null, 1, 30, null },
                    { 18L, 4L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4480), null, null, "Fırça Seti", 110m, null, 1, 25, null },
                    { 19L, 4L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4481), null, null, "Çizim Defteri", 85m, null, 1, 40, null },
                    { 20L, 4L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4482), null, null, "Sanat Paleti", 55m, null, 1, 50, null },
                    { 21L, 5L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4484), null, null, "Sıvı Yapıştırıcı", 35m, null, 1, 60, null },
                    { 22L, 5L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4485), null, null, "Bantlı Yapıştırıcı", 30m, null, 1, 90, null },
                    { 23L, 5L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4486), null, null, "Hot Melt Yapıştırıcı", 80m, null, 1, 30, null },
                    { 24L, 5L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4487), null, null, "Yapıştırıcı Stik", 75m, null, 1, 120, null },
                    { 25L, 5L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4488), null, null, "Modeller İçin Yapıştırıcı", 55m, null, 1, 40, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "TwoFactorEnabled", "UpdatedDate", "UserRoleCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4122), null, "john.doe@example.com", "+905551234567", new byte[] { 203, 245, 125, 216, 48, 215, 206, 163, 22, 181, 122, 102, 51, 28, 9, 190, 16, 236, 240, 1, 202, 54, 86, 216, 180, 105, 116, 205, 87, 236, 244, 246, 151, 9, 243, 97, 241, 221, 173, 34, 153, 33, 95, 111, 183, 94, 250, 182, 143, 107, 117, 123, 154, 128, 252, 155, 156, 0, 3, 133, 12, 74, 223, 15 }, new byte[] { 155, 140, 238, 112, 77, 92, 169, 94, 4, 92, 95, 249, 125, 0, 254, 120 }, 1, false, null, 1L },
                    { 102L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4133), null, "jane.doe@example.com", "+905551234568", new byte[] { 203, 245, 125, 216, 48, 215, 206, 163, 22, 181, 122, 102, 51, 28, 9, 190, 16, 236, 240, 1, 202, 54, 86, 216, 180, 105, 116, 205, 87, 236, 244, 246, 151, 9, 243, 97, 241, 221, 173, 34, 153, 33, 95, 111, 183, 94, 250, 182, 143, 107, 117, 123, 154, 128, 252, 155, 156, 0, 3, 133, 12, 74, 223, 15 }, new byte[] { 155, 140, 238, 112, 77, 92, 169, 94, 4, 92, 95, 249, 125, 0, 254, 120 }, 1, false, null, 2L },
                    { 103L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4135), null, "alice.smith@example.com", "+905551234569", new byte[] { 203, 245, 125, 216, 48, 215, 206, 163, 22, 181, 122, 102, 51, 28, 9, 190, 16, 236, 240, 1, 202, 54, 86, 216, 180, 105, 116, 205, 87, 236, 244, 246, 151, 9, 243, 97, 241, 221, 173, 34, 153, 33, 95, 111, 183, 94, 250, 182, 143, 107, 117, 123, 154, 128, 252, 155, 156, 0, 3, 133, 12, 74, 223, 15 }, new byte[] { 155, 140, 238, 112, 77, 92, 169, 94, 4, 92, 95, 249, 125, 0, 254, 120 }, 1, false, null, 3L },
                    { 104L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4136), null, "bob.johnson@example.com", "+905551234570", new byte[] { 203, 245, 125, 216, 48, 215, 206, 163, 22, 181, 122, 102, 51, 28, 9, 190, 16, 236, 240, 1, 202, 54, 86, 216, 180, 105, 116, 205, 87, 236, 244, 246, 151, 9, 243, 97, 241, 221, 173, 34, 153, 33, 95, 111, 183, 94, 250, 182, 143, 107, 117, 123, 154, 128, 252, 155, 156, 0, 3, 133, 12, 74, 223, 15 }, new byte[] { 155, 140, 238, 112, 77, 92, 169, 94, 4, 92, 95, 249, 125, 0, 254, 120 }, 1, false, null, 3L },
                    { 105L, new DateTime(2024, 9, 30, 19, 15, 52, 397, DateTimeKind.Local).AddTicks(4137), null, "carol.davis@example.com", "+905551234571", new byte[] { 203, 245, 125, 216, 48, 215, 206, 163, 22, 181, 122, 102, 51, 28, 9, 190, 16, 236, 240, 1, 202, 54, 86, 216, 180, 105, 116, 205, 87, 236, 244, 246, 151, 9, 243, 97, 241, 221, 173, 34, 153, 33, 95, 111, 183, 94, 250, 182, 143, 107, 117, 123, 154, 128, 252, 155, 156, 0, 3, 133, 12, 74, 223, 15 }, new byte[] { 155, 140, 238, 112, 77, 92, 169, 94, 4, 92, 95, 249, 125, 0, 254, 120 }, 1, false, null, 3L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(3841), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(3863), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(3865), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(3896), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 19, 15, 52, 396, DateTimeKind.Local).AddTicks(3897), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipperCode",
                table: "Order",
                column: "ShipperCode");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserCode",
                table: "Order",
                column: "UserCode");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderCode",
                table: "OrderDetail",
                column: "OrderCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryCode",
                table: "Product",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderDetailCode",
                table: "Product",
                column: "OrderDetailCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShipperCode",
                table: "Product",
                column: "ShipperCode");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MobilePhone",
                table: "User",
                column: "MobilePhone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRoleCode",
                table: "User",
                column: "UserRoleCode");

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
                name: "IX_UserRole_UserCode",
                table: "UserRole",
                column: "UserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserCode",
                table: "Order",
                column: "UserCode",
                principalTable: "User",
                principalColumn: "UserCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_UserRoleCode",
                table: "User",
                column: "UserRoleCode",
                principalTable: "UserRole",
                principalColumn: "UserRoleCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserCode",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
