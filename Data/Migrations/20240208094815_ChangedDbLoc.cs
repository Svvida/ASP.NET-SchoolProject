using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChangedDbLoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "030a2e1d-e759-4382-840d-66966857a216", "be074218-a985-4572-a4d1-6c66909a51a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbbb464f-9f8a-44ce-b01c-d2a6a1fe515d", "eec5c07b-cf21-4d18-a366-321dc32dc13b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "030a2e1d-e759-4382-840d-66966857a216");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbbb464f-9f8a-44ce-b01c-d2a6a1fe515d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be074218-a985-4572-a4d1-6c66909a51a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eec5c07b-cf21-4d18-a366-321dc32dc13b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "030a2e1d-e759-4382-840d-66966857a216", "030a2e1d-e759-4382-840d-66966857a216", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbbb464f-9f8a-44ce-b01c-d2a6a1fe515d", "bbbb464f-9f8a-44ce-b01c-d2a6a1fe515d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be074218-a985-4572-a4d1-6c66909a51a8", 0, "4e0ccb17-d0a1-4207-bc87-3f3b3c0d3438", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "admin", "AQAAAAEAACcQAAAAEBpMm4ddyOcQKyEhJaHysb84mGrF6Q8FFWyyQnYOcK74hD/8C0ZbNLxdQEJJIX/J6g==", null, false, "c224b77b-0985-4301-8695-9eea1a9cf729", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eec5c07b-cf21-4d18-a366-321dc32dc13b", 0, "c8919ace-3d54-426b-88f0-953777b6d452", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "user", "AQAAAAEAACcQAAAAEGg6x6oTtPkS8Gj/zD6qklfeJSLktL8yTUwCea7D9QGixwB0D8tP1JkVUqWl8usIPw==", null, false, "69a8f8bb-0661-4768-a5e8-45b726ee5bd5", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "030a2e1d-e759-4382-840d-66966857a216", "be074218-a985-4572-a4d1-6c66909a51a8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbbb464f-9f8a-44ce-b01c-d2a6a1fe515d", "eec5c07b-cf21-4d18-a366-321dc32dc13b" });
        }
    }
}
