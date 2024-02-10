using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employers_AddressId",
                table: "Employers");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Street" },
                values: new object[] { 55, "City1", "00001", "Street1" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Street" },
                values: new object[] { 66, "City2", "00002", "Street2" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "EmployerId", "employment_date", "FirstName", "LastName", "PESEL", "Position", "termination_date" },
                values: new object[] { 55, "HR", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Smith", "85050512345", "Manager", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "EmployerId", "employment_date", "FirstName", "LastName", "PESEL", "Position", "termination_date" },
                values: new object[] { 66, "IT", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Johnson", "90090512345", "Developer", null });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "EmployerId", "AddressId", "CompanyName", "FirstName", "LastName", "NIP" },
                values: new object[] { 55, 1, "JDoe Inc.", "John", "Doe", "1234567890" });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "EmployerId", "AddressId", "CompanyName", "FirstName", "LastName", "NIP" },
                values: new object[] { 66, 2, "JDoe & Co.", "Jane", "Doe", "0987654321" });

            migrationBuilder.CreateIndex(
                name: "IX_Employers_AddressId",
                table: "Employers",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employers_AddressId",
                table: "Employers");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 66);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_AddressId",
                table: "Employers",
                column: "AddressId",
                unique: true);
        }
    }
}
