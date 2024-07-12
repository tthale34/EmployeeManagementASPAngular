using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementASPAngular.Migrations
{
    public partial class AddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeManaderId",
                table: "Employees",
                newName: "EmployeeManagerId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeePosition",
                table: "Employees",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeePosition",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeManagerId",
                table: "Employees",
                newName: "EmployeeManaderId");
        }
    }
}
