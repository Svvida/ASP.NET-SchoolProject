using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4bc0e28-f127-4d4d-926e-c008629f8528", "b336bfe6-3d56-4a63-809f-3964b6b7a7dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f59aec06-4b5d-443a-9fff-c5469ddc2f15", "e596b315-bb88-4d44-98b4-5ed8ae32f888" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4bc0e28-f127-4d4d-926e-c008629f8528");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59aec06-4b5d-443a-9fff-c5469ddc2f15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b336bfe6-3d56-4a63-809f-3964b6b7a7dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e596b315-bb88-4d44-98b4-5ed8ae32f888");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e4bc0e28-f127-4d4d-926e-c008629f8528", "e4bc0e28-f127-4d4d-926e-c008629f8528", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f59aec06-4b5d-443a-9fff-c5469ddc2f15", "f59aec06-4b5d-443a-9fff-c5469ddc2f15", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b336bfe6-3d56-4a63-809f-3964b6b7a7dd", 0, "268d6fe7-bb00-4b1e-8fbb-f8a0c863f8c7", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "admin", "AQAAAAEAACcQAAAAEIgBRBX6py6e3QkkENiC7De1013J76DSu+/lK8qilY/oYpv4qHSwmpQ/Jsr1fy20VQ==", null, false, "4f2703c4-10b7-4118-93fe-27b97b77b9c2", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e596b315-bb88-4d44-98b4-5ed8ae32f888", 0, "1a276d4d-0e1c-446f-b40a-e6e5eb614116", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "user", "AQAAAAEAACcQAAAAEGrmbGI4/YhUW705XoyClVSlabRFNISqBOltMvgHYDO+iah27tCnURpGR3mSmjcIEg==", null, false, "6ef7d30b-62c6-47ca-afd3-2a19fdfec500", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4bc0e28-f127-4d4d-926e-c008629f8528", "b336bfe6-3d56-4a63-809f-3964b6b7a7dd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f59aec06-4b5d-443a-9fff-c5469ddc2f15", "e596b315-bb88-4d44-98b4-5ed8ae32f888" });
        }
    }
}
