using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class TestData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                column: "EmployerId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "EmployerId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 55,
                column: "AddressId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 66,
                column: "AddressId",
                value: 66);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                column: "EmployerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "EmployerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 55,
                column: "AddressId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "EmployerId",
                keyValue: 66,
                column: "AddressId",
                value: 2);
        }
    }
}
