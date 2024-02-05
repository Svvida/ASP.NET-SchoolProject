using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PESEL = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Position = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    employment_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    termination_date = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "employment_date", "FirstName", "LastName", "PESEL", "Position", "termination_date" },
                values: new object[] { 1, "IT", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kowalski", "12345678901", "Programista", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "employment_date", "FirstName", "LastName", "PESEL", "Position", "termination_date" },
                values: new object[] { 2, "Administracja", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Nowak", "12345678902", "Kierownik", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
