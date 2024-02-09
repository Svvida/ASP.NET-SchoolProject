using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Risky : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8777913b-74f7-41b8-8794-0221781fd9c2", "3be79401-c412-491e-8267-957b43d9864a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c10dfb4f-362c-41c6-a90b-1ee2ff70f500", "9b5cd847-30a7-420e-8559-f1561c1605ff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8777913b-74f7-41b8-8794-0221781fd9c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c10dfb4f-362c-41c6-a90b-1ee2ff70f500");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3be79401-c412-491e-8267-957b43d9864a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b5cd847-30a7-420e-8559-f1561c1605ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0946b89d-9040-4277-bfb7-cb1ef11362e7", "0946b89d-9040-4277-bfb7-cb1ef11362e7", "user", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2d222c6-baed-4fdf-92af-ccedd4a30f88", "b2d222c6-baed-4fdf-92af-ccedd4a30f88", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58479166-2c6b-4297-9439-1a540dc73adb", 0, "9f56b540-970f-4538-b62a-9a101bd67c9b", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEEv2LjfBtTbFAphKPHtEiH5XXxjiMKm01b+Dizk56O2t7nqzJBnqLzlo1WqmGzVJ/A==", null, false, "e7f25633-240e-43bc-ab58-870677ed88c2", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c1f89619-01a9-4f14-89c5-08c3be611998", 0, "66d7bca3-433c-444a-a27e-f346d5622e31", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEHd2baXelLrbq3Oo11KinGZ/sRaJJSqCvwgxuqU369AHvgdkEqwFgvU9pN8kzqvNow==", null, false, "cae5cb28-f581-4d55-a4a2-a70fd928a325", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0946b89d-9040-4277-bfb7-cb1ef11362e7", "58479166-2c6b-4297-9439-1a540dc73adb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2d222c6-baed-4fdf-92af-ccedd4a30f88", "c1f89619-01a9-4f14-89c5-08c3be611998" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0946b89d-9040-4277-bfb7-cb1ef11362e7", "58479166-2c6b-4297-9439-1a540dc73adb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2d222c6-baed-4fdf-92af-ccedd4a30f88", "c1f89619-01a9-4f14-89c5-08c3be611998" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0946b89d-9040-4277-bfb7-cb1ef11362e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2d222c6-baed-4fdf-92af-ccedd4a30f88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58479166-2c6b-4297-9439-1a540dc73adb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1f89619-01a9-4f14-89c5-08c3be611998");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8777913b-74f7-41b8-8794-0221781fd9c2", "8777913b-74f7-41b8-8794-0221781fd9c2", "user", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c10dfb4f-362c-41c6-a90b-1ee2ff70f500", "c10dfb4f-362c-41c6-a90b-1ee2ff70f500", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3be79401-c412-491e-8267-957b43d9864a", 0, "ce6141ad-d8ad-4590-9e45-daeba05b6d20", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEAeZ9CHBYiMF2DhRGKM7TIanWzETUzRaAM22LyS9nhBOLm3OYX/rs/2i9yasvgueEQ==", null, false, "d29fce31-771f-485a-a661-ca2f31ea1404", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9b5cd847-30a7-420e-8559-f1561c1605ff", 0, "561593b0-b490-41e9-8a7e-565c0c8a2e2c", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEOY/EfxkYnmQ6zajFHIOVZe12SwH2QU49Gh2EsWyhvHPwCA2admXfgXaMCA6KKgAgQ==", null, false, "e21f4848-6fe1-4355-8225-e83ee470b40a", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8777913b-74f7-41b8-8794-0221781fd9c2", "3be79401-c412-491e-8267-957b43d9864a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c10dfb4f-362c-41c6-a90b-1ee2ff70f500", "9b5cd847-30a7-420e-8559-f1561c1605ff" });
        }
    }
}
