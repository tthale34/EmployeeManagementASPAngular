using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementASPAngular.Migrations.Manager
{
    public partial class UpdateManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerPosition",
                table: "Managers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerPosition",
                table: "Managers",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
