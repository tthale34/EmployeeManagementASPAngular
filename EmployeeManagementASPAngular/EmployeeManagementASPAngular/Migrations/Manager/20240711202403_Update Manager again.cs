using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementASPAngular.Migrations.Manager
{
    public partial class UpdateManageragain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerManagerDepartment",
                table: "Managers",
                newName: "ManagerPosition");

            migrationBuilder.AddColumn<string>(
                name: "ManagerDepartment",
                table: "Managers",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerDepartment",
                table: "Managers");

            migrationBuilder.RenameColumn(
                name: "ManagerPosition",
                table: "Managers",
                newName: "ManagerManagerDepartment");
        }
    }
}
