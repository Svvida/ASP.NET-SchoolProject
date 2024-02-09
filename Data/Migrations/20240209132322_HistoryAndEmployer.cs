using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class HistoryAndEmployer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36600482-7079-4a27-b7db-f2c60099f92c", "30b918d7-6948-4b11-b978-34da1b735700" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7dc5cba-bc02-4178-ab97-b4da0a6a1ba7", "d5d3f41f-e417-426f-9ee7-5530b8c1ff71" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36600482-7079-4a27-b7db-f2c60099f92c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dc5cba-bc02-4178-ab97-b4da0a6a1ba7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b918d7-6948-4b11-b978-34da1b735700");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5d3f41f-e417-426f-9ee7-5530b8c1ff71");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "36600482-7079-4a27-b7db-f2c60099f92c", "36600482-7079-4a27-b7db-f2c60099f92c", "user", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7dc5cba-bc02-4178-ab97-b4da0a6a1ba7", "f7dc5cba-bc02-4178-ab97-b4da0a6a1ba7", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30b918d7-6948-4b11-b978-34da1b735700", 0, "a929b6cb-eac4-4774-82c0-d6fffde9ce9b", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEMQTdZTQRNYKEgofdNi3KXBA5q3BH7I3QgNJ24YUV7WJVKYQYXXJClfKw1pLOEO3wQ==", null, false, "c387bf77-6c0d-439d-bd72-dddfbb9cfe7c", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5d3f41f-e417-426f-9ee7-5530b8c1ff71", 0, "8dabc6ec-c990-41a9-a4d5-5fa13120778e", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEGCiyMhBUMO6/R6Qy9ivk8MvPbfwED422PfckY5JDM7ViDg5Ad4RnS08TQJqvIbLqQ==", null, false, "8963b71c-789d-4781-850f-54986bbabf38", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36600482-7079-4a27-b7db-f2c60099f92c", "30b918d7-6948-4b11-b978-34da1b735700" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f7dc5cba-bc02-4178-ab97-b4da0a6a1ba7", "d5d3f41f-e417-426f-9ee7-5530b8c1ff71" });
        }
    }
}
