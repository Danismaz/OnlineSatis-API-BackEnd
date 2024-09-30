using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class AddedTables : Migration
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
                    table.ForeignKey(
                        name: "FK_Order_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "UserCode",
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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1580), new byte[] { 59, 83, 1, 234, 98, 155, 251, 6, 38, 28, 169, 219, 41, 110, 166, 66, 91, 153, 203, 90, 74, 201, 165, 248, 42, 18, 215, 122, 141, 79, 107, 87, 241, 172, 195, 121, 181, 84, 77, 41, 33, 5, 212, 161, 119, 235, 147, 88, 180, 84, 255, 134, 84, 56, 116, 245, 153, 161, 210, 119, 96, 38, 9, 229 }, new byte[] { 51, 64, 7, 22, 84, 123, 66, 147, 250, 214, 176, 75, 104, 67, 104, 137 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1580), new byte[] { 59, 83, 1, 234, 98, 155, 251, 6, 38, 28, 169, 219, 41, 110, 166, 66, 91, 153, 203, 90, 74, 201, 165, 248, 42, 18, 215, 122, 141, 79, 107, 87, 241, 172, 195, 121, 181, 84, 77, 41, 33, 5, 212, 161, 119, 235, 147, 88, 180, 84, 255, 134, 84, 56, 116, 245, 153, 161, 210, 119, 96, 38, 9, 229 }, new byte[] { 51, 64, 7, 22, 84, 123, 66, 147, 250, 214, 176, 75, 104, 67, 104, 137 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1580), new byte[] { 59, 83, 1, 234, 98, 155, 251, 6, 38, 28, 169, 219, 41, 110, 166, 66, 91, 153, 203, 90, 74, 201, 165, 248, 42, 18, 215, 122, 141, 79, 107, 87, 241, 172, 195, 121, 181, 84, 77, 41, 33, 5, 212, 161, 119, 235, 147, 88, 180, 84, 255, 134, 84, 56, 116, 245, 153, 161, 210, 119, 96, 38, 9, 229 }, new byte[] { 51, 64, 7, 22, 84, 123, 66, 147, 250, 214, 176, 75, 104, 67, 104, 137 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1580), new byte[] { 59, 83, 1, 234, 98, 155, 251, 6, 38, 28, 169, 219, 41, 110, 166, 66, 91, 153, 203, 90, 74, 201, 165, 248, 42, 18, 215, 122, 141, 79, 107, 87, 241, 172, 195, 121, 181, 84, 77, 41, 33, 5, 212, 161, 119, 235, 147, 88, 180, 84, 255, 134, 84, 56, 116, 245, 153, 161, 210, 119, 96, 38, 9, 229 }, new byte[] { 51, 64, 7, 22, 84, 123, 66, 147, 250, 214, 176, 75, 104, 67, 104, 137 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1590), new byte[] { 59, 83, 1, 234, 98, 155, 251, 6, 38, 28, 169, 219, 41, 110, 166, 66, 91, 153, 203, 90, 74, 201, 165, 248, 42, 18, 215, 122, 141, 79, 107, 87, 241, 172, 195, 121, 181, 84, 77, 41, 33, 5, 212, 161, 119, 235, 147, 88, 180, 84, 255, 134, 84, 56, 116, 245, 153, 161, 210, 119, 96, 38, 9, 229 }, new byte[] { 51, 64, 7, 22, 84, 123, 66, 147, 250, 214, 176, 75, 104, 67, 104, 137 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 43, 35, 296, DateTimeKind.Local).AddTicks(1040));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 101L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7100), new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 102L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 103L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 104L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserCode",
                keyValue: 105L,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 } });

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "UserDetail",
                keyColumn: "UserDetailCode",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleCode",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460));
        }
    }
}
