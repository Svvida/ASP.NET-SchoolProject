using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a5120b4-7104-4531-8153-c49eebcd6b72", "4a5120b4-7104-4531-8153-c49eebcd6b72", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "628a862f-bbba-4af7-a0b8-2b251336c28e", "628a862f-bbba-4af7-a0b8-2b251336c28e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c13830d9-97d2-4c88-ab82-f0163141815f", 0, "53a2833a-5223-4894-8d12-879e20ee8e1a", "", false, false, null, null, "USER", null, null, false, "aae2350c-488a-46f4-bce2-87e8257bda42", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fba0573e-8211-469f-9e80-64594e9cf794", 0, "5b1318d5-0aa3-4a7b-b616-4ca2e711655a", "admin@wsei.edu.pl", false, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEHggqCDkj/xqKWuBvfbg6ViVBCnVQOI4dXBkYPzDOR+es9mLEEPNnBjyh1+O/I87LQ==", null, false, "4b670ab0-cb98-413e-8b03-e451f655c78d", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a5120b4-7104-4531-8153-c49eebcd6b72", "c13830d9-97d2-4c88-ab82-f0163141815f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "628a862f-bbba-4af7-a0b8-2b251336c28e", "fba0573e-8211-469f-9e80-64594e9cf794" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a5120b4-7104-4531-8153-c49eebcd6b72", "c13830d9-97d2-4c88-ab82-f0163141815f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "628a862f-bbba-4af7-a0b8-2b251336c28e", "fba0573e-8211-469f-9e80-64594e9cf794" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5120b4-7104-4531-8153-c49eebcd6b72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "628a862f-bbba-4af7-a0b8-2b251336c28e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c13830d9-97d2-4c88-ab82-f0163141815f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba0573e-8211-469f-9e80-64594e9cf794");
        }
    }
}
