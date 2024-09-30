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
                table: "UserRole",
                columns: new[] { "UserRoleCode", "CreatedDate", "DeletedDate", "RoleDescription", "Status", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460), null, "Admin", 1, null, null },
                    { 2L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460), null, "Yönetici", 1, null, null },
                    { 3L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6460), null, "Kullanici", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserCode", "CreatedDate", "DeletedDate", "Email", "MobilePhone", "PasswordHash", "PasswordSalt", "Status", "TwoFactorEnabled", "UpdatedDate", "UserRoleCode" },
                values: new object[,]
                {
                    { 101L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7100), null, "john.doe@example.com", "+905551234567", new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 }, 1, false, null, 1L },
                    { 102L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), null, "jane.doe@example.com", "+905551234568", new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 }, 1, false, null, 2L },
                    { 103L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), null, "alice.smith@example.com", "+905551234569", new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 }, 1, false, null, 3L },
                    { 104L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), null, "bob.johnson@example.com", "+905551234570", new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 }, 1, false, null, 3L },
                    { 105L, new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(7110), null, "carol.davis@example.com", "+905551234571", new byte[] { 93, 119, 217, 228, 66, 166, 110, 147, 22, 37, 105, 18, 125, 46, 217, 137, 229, 173, 114, 206, 20, 222, 56, 222, 0, 194, 8, 202, 3, 65, 113, 244, 244, 16, 126, 243, 224, 42, 245, 175, 8, 194, 202, 72, 157, 180, 172, 86, 31, 157, 83, 107, 45, 178, 191, 53, 192, 226, 172, 51, 158, 172, 133, 120 }, new byte[] { 147, 188, 45, 157, 211, 184, 252, 52, 177, 15, 182, 106, 196, 37, 117, 227 }, 1, false, null, 3L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "UserDetailCode", "BirthDate", "CreatedDate", "DeletedDate", "Email", "IdentityNumber", "MobilePhone", "Name", "Status", "Surname", "UpdatedDate", "UserCode" },
                values: new object[,]
                {
                    { 1L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6320), null, "ahmet.yilmaz@kirtasiyemerkezi.com", "98765432101", "+905551234567", "Ahmet", 1, "Yılmaz", null, 101L },
                    { 2L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350), null, "mehmet.demir@ofismalzemeleri.com", "98765432102", "+905551234568", "Mehmet", 1, "Demir", null, 102L },
                    { 3L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6350), null, "ayse.kaya@kirtasiyedunyasi.com", "98765432103", "+905551234569", "Ayşe", 1, "Kaya", null, 103L },
                    { 4L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360), null, "ali.celik@ofismerkezi.com", "98765432104", "+905551234570", "Ali", 1, "Çelik", null, 104L },
                    { 5L, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 9, 35, 790, DateTimeKind.Local).AddTicks(6360), null, "fatma.yurt@kirtasiyevi.com", "98765432105", "+905551234571", "Fatma", 1, "Yurt", null, 105L }
                });

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
                name: "FK_User_UserRole_UserRoleCode",
                table: "User");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
