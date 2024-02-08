using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4533ee23-39dc-4107-a58f-a571ff586f37", "d3ae1731-ff14-4b01-b19e-0c3474a8977c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "741cab43-4755-45d4-ad91-df043d485ad7", "f4c707df-0ab6-456c-ba86-e7051f775102" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4533ee23-39dc-4107-a58f-a571ff586f37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "741cab43-4755-45d4-ad91-df043d485ad7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3ae1731-ff14-4b01-b19e-0c3474a8977c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4c707df-0ab6-456c-ba86-e7051f775102");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0501d189-3abf-4f6d-af04-95895629e47b", "0501d189-3abf-4f6d-af04-95895629e47b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "775ca34f-8a8f-4c4b-ab8d-ad24fd4d7e1b", "775ca34f-8a8f-4c4b-ab8d-ad24fd4d7e1b", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dad18071-5da4-4664-8710-a14f171e8e14", 0, "0382af25-31a2-4a86-8884-345bfa5d5fd4", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "user", "AQAAAAEAACcQAAAAEOeT4vDTMS7KXs/ZTDTV+kiwZNBTyib+SWC5X4ZT0BrT3Rj1H/5yAR8s7Gr4JRiCGw==", null, false, "16ef6972-191e-4843-9ffc-802f8f80fc3f", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e186bddd-378f-4269-95ed-770b79edd1cb", 0, "9af5903c-40c0-45e1-b93a-3cc32dbef430", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "admin", "AQAAAAEAACcQAAAAELPcCF9/a3OFsNk1TtFwbjAjnfOJ9G+FljDAR6RZuHHrIKq5EYo6nFbuYC7MxiotDQ==", null, false, "ac9149fe-19dd-4f40-a046-180a4f355fb3", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0501d189-3abf-4f6d-af04-95895629e47b", "dad18071-5da4-4664-8710-a14f171e8e14" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "775ca34f-8a8f-4c4b-ab8d-ad24fd4d7e1b", "e186bddd-378f-4269-95ed-770b79edd1cb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0501d189-3abf-4f6d-af04-95895629e47b", "dad18071-5da4-4664-8710-a14f171e8e14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "775ca34f-8a8f-4c4b-ab8d-ad24fd4d7e1b", "e186bddd-378f-4269-95ed-770b79edd1cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0501d189-3abf-4f6d-af04-95895629e47b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "775ca34f-8a8f-4c4b-ab8d-ad24fd4d7e1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad18071-5da4-4664-8710-a14f171e8e14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e186bddd-378f-4269-95ed-770b79edd1cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4533ee23-39dc-4107-a58f-a571ff586f37", "4533ee23-39dc-4107-a58f-a571ff586f37", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "741cab43-4755-45d4-ad91-df043d485ad7", "741cab43-4755-45d4-ad91-df043d485ad7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d3ae1731-ff14-4b01-b19e-0c3474a8977c", 0, "875f6791-9a06-470d-b67f-e945234b855f", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "admin", "AQAAAAEAACcQAAAAEKG8OzK7Jpmrt3g7qA80NV65r2IIxWPdxIzDuqN9XovDE1mECwiI+2/1dsUJoPJNCw==", null, false, "bd23b0f3-f408-4d39-8a16-3112803344cc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4c707df-0ab6-456c-ba86-e7051f775102", 0, "25602e45-2fb1-49dd-b4f9-94d873f00ca8", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "user", "AQAAAAEAACcQAAAAED7O+rzk5cz5e7VVxS9UxBePAAsPp/NnaU3jZVnIKZbQB95L5uxNWlGNYOsIa7FaGg==", null, false, "750290c4-cbc9-46e0-9417-cd0d0f77b940", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4533ee23-39dc-4107-a58f-a571ff586f37", "d3ae1731-ff14-4b01-b19e-0c3474a8977c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "741cab43-4755-45d4-ad91-df043d485ad7", "f4c707df-0ab6-456c-ba86-e7051f775102" });
        }
    }
}
