using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementASPAngular.Migrations.Manager
{
    public partial class UpdateManagertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerManaderDepartment",
                table: "Managers",
                newName: "ManagerManagerDepartment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerManagerDepartment",
                table: "Managers",
                newName: "ManagerManaderDepartment");
        }
    }
}
