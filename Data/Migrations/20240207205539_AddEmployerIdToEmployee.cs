using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddEmployerIdToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Employees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NIP = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployerId",
                table: "Employees",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employers_EmployerId",
                table: "Employees",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employers_EmployerId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Employees");
        }
    }
}
