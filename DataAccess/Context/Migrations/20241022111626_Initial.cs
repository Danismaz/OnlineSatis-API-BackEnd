using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Product",
                columns: table => new
                {
                    ProductCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_Product_Shipper_ShipperCode",
                        column: x => x.ShipperCode,
                        principalTable: "Shipper",
                        principalColumn: "ShipperCode");
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
                    ProductCode = table.Column<long>(type: "bigint", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Product",
                        principalColumn: "ProductCode",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1L, "Farklı türde kalemler.", "Kalemler", new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460), null, 1, null },
                    { 2L, "Çeşitli defter türleri.", "Defterler", new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460), null, 1, null },
                    { 3L, "Ofis için gerekli malzemeler.", "Ofis Malzemeleri", new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5460), null, 1, null },
                    { 4L, "Resim ve sanat malzemeleri.", "Sanat Malzemeleri", new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5470), null, 1, null },
                    { 5L, "Farklı tür yapıştırıcılar.", "Yapıştırıcılar", new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5470), null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "ShipperCode", "CreatedDate", "DeletedDate", "DeliveryTime", "Price", "ShipperName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5830), null, "1-2 gün", 15.99m, "Aras Kargo", 1, null },
                    { 2, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840), null, "2-3 gün", 12.50m, "Yurtiçi Kargo", 1, null },
                    { 3, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840), null, "1 gün", 20.00m, "Kolay Gelsin", 1, null },
                    { 4, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5840), null, "3-5 days", 10.75m, "MNG Kargo", 1, null },
                    { 5, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5850), null, "5-7 gün", 25.00m, "Ptt Kargo", 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null, "Admin", 1, null, null },
                    { 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null, "Yönetici", 1, null, null },
                    { 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4350), null, "Kullanici", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductCode", "CategoryCode", "CreatedDate", "DeletedDate", "ProductName", "ProductPrice", "ShipperCode", "Status", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5560), null, "Kurşun Kalem", 40m, null, 1, 100, null },
                    { 2L, 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5560), null, "Mavi Renkli Kalem", 80m, null, 1, 80, null },
                    { 3L, 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570), null, "Kırmızı Jel Kalem", 90m, null, 1, 60, null },
                    { 4L, 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570), null, "Siyah Mürekkep Kalem", 100m, null, 1, 40, null },
                    { 5L, 1L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5570), null, "Renkli Silgi", 25m, null, 1, 120, null },
                    { 6L, 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5580), null, "A5 Kırmızı Defter", 150m, null, 1, 200, null },
                    { 7L, 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5580), null, "A4 Beyaz Defter", 85m, null, 1, 150, null },
                    { 8L, 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590), null, "Kareli Defter", 120m, null, 1, 100, null },
                    { 9L, 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590), null, "Çizgili Defter", 120m, null, 1, 90, null },
                    { 10L, 2L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590), null, "Sert Kapaklı Defter", 160m, null, 1, 50, null },
                    { 11L, 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5590), null, "Zımba Makinesi", 90m, null, 1, 30, null },
                    { 12L, 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600), null, "Bant Dispenseri", 45m, null, 1, 70, null },
                    { 13L, 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600), null, "Makas", 55m, null, 1, 40, null },
                    { 14L, 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5600), null, "Post-it Notlar", 75m, null, 1, 200, null },
                    { 15L, 3L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610), null, "Kalemtraş", 20m, null, 1, 100, null },
                    { 16L, 4L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610), null, "Akrilik Boya Seti", 165m, null, 1, 20, null },
                    { 17L, 4L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610), null, "Su Renkleri Seti", 145m, null, 1, 30, null },
                    { 18L, 4L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5610), null, "Fırça Seti", 110m, null, 1, 25, null },
                    { 19L, 4L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620), null, "Çizim Defteri", 85m, null, 1, 40, null },
                    { 20L, 4L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620), null, "Sanat Paleti", 55m, null, 1, 50, null },
                    { 21L, 5L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5620), null, "Sıvı Yapıştırıcı", 35m, null, 1, 60, null },
                    { 22L, 5L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630), null, "Bantlı Yapıştırıcı", 30m, null, 1, 90, null },
                    { 23L, 5L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630), null, "Hot Melt Yapıştırıcı", 80m, null, 1, 30, null },
                    { 24L, 5L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630), null, "Yapıştırıcı Stik", 75m, null, 1, 120, null },
                    { 25L, 5L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5630), null, "Modeller İçin Yapıştırıcı", 55m, null, 1, 40, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "TwoFactorEnabled", "UpdatedDate", "UserRoleCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5320), null, "john.doe@example.com", "+905551234567", new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 }, 1, false, null, 1L },
                    { 102L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), null, "jane.doe@example.com", "+905551234568", new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 }, 1, false, null, 2L },
                    { 103L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), null, "alice.smith@example.com", "+905551234569", new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 }, 1, false, null, 3L },
                    { 104L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5330), null, "bob.johnson@example.com", "+905551234570", new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 }, 1, false, null, 3L },
                    { 105L, new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(5340), null, "carol.davis@example.com", "+905551234571", new byte[] { 90, 66, 34, 134, 234, 196, 7, 215, 242, 207, 64, 35, 171, 183, 79, 203, 50, 239, 252, 14, 37, 211, 37, 117, 129, 144, 144, 159, 134, 246, 79, 65, 157, 110, 133, 253, 116, 181, 161, 147, 11, 16, 72, 211, 41, 150, 186, 89, 127, 253, 245, 192, 67, 13, 140, 253, 193, 227, 82, 64, 142, 222, 178, 202 }, new byte[] { 223, 55, 162, 243, 165, 161, 203, 190, 106, 228, 9, 201, 221, 117, 116, 117 }, 1, false, null, 3L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4110), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4160), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 16, 26, 193, DateTimeKind.Local).AddTicks(4170), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
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
                name: "IX_OrderDetail_ProductCode",
                table: "OrderDetail",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryCode",
                table: "Product",
                column: "CategoryCode");

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
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
