using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "32051e01-9c66-4bd1-b590-5e0ada46cf80", "32051e01-9c66-4bd1-b590-5e0ada46cf80", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7db2380-7840-48b3-86d0-fe01c210e38a", "c7db2380-7840-48b3-86d0-fe01c210e38a", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "403d9094-0609-4d7b-a5a1-4b885e714e6e", 0, "1f33ffcd-aa82-4d82-90f4-5f6bf1a58fed", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEOHqlxzR3vXWVC77a5/tNvl1V0588aapZQBOm5BqnaA96NGxwbWa0ttv9uGId3Yxiw==", null, false, "fa5fd8fc-0147-4045-a117-22fe974071b4", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2cbc8b6-647f-42d5-b6c9-bd0529d20351", 0, "f1964814-174c-4211-823b-e9fea9692b92", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAELwvMmKcX+e4lcLEmN67EMtPNKYn9I7phcmOFYi11sIZz/w5BLpq65jnP/i8LZZzHQ==", null, false, "c1713742-636a-4e60-bf03-7697ebfc055c", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7db2380-7840-48b3-86d0-fe01c210e38a", "403d9094-0609-4d7b-a5a1-4b885e714e6e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "32051e01-9c66-4bd1-b590-5e0ada46cf80", "c2cbc8b6-647f-42d5-b6c9-bd0529d20351" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7db2380-7840-48b3-86d0-fe01c210e38a", "403d9094-0609-4d7b-a5a1-4b885e714e6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32051e01-9c66-4bd1-b590-5e0ada46cf80", "c2cbc8b6-647f-42d5-b6c9-bd0529d20351" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32051e01-9c66-4bd1-b590-5e0ada46cf80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7db2380-7840-48b3-86d0-fe01c210e38a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "403d9094-0609-4d7b-a5a1-4b885e714e6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2cbc8b6-647f-42d5-b6c9-bd0529d20351");

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
    }
}
