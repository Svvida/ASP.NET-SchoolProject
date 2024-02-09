using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class EmploymentHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "EmploymentHistory",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistory_EmployerId",
                table: "EmploymentHistory",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentHistory_Employers_EmployerId",
                table: "EmploymentHistory",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentHistory_Employers_EmployerId",
                table: "EmploymentHistory");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentHistory_EmployerId",
                table: "EmploymentHistory");

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

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "EmploymentHistory");

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
    }
}
