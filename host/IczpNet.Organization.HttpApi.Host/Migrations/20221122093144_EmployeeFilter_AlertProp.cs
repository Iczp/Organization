using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class EmployeeFilter_AlertProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResultTime",
                table: "Organization_EmployeeFilter",
                newName: "LastRunTime");

            migrationBuilder.RenameColumn(
                name: "ResultCount",
                table: "Organization_EmployeeFilter",
                newName: "TotalCount");

            migrationBuilder.RenameColumn(
                name: "Parameter",
                table: "Organization_EmployeeFilter",
                newName: "Input");

            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Organization_EmployeeFilter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResultMessage",
                table: "Organization_EmployeeFilter",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Organization_EmployeeFilter");

            migrationBuilder.DropColumn(
                name: "ResultMessage",
                table: "Organization_EmployeeFilter");

            migrationBuilder.RenameColumn(
                name: "TotalCount",
                table: "Organization_EmployeeFilter",
                newName: "ResultCount");

            migrationBuilder.RenameColumn(
                name: "LastRunTime",
                table: "Organization_EmployeeFilter",
                newName: "ResultTime");

            migrationBuilder.RenameColumn(
                name: "Input",
                table: "Organization_EmployeeFilter",
                newName: "Parameter");
        }
    }
}
