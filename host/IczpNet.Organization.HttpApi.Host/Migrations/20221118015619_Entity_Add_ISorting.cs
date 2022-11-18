using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Entity_Add_ISorting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Sorting",
                table: "Organization_PostGradePostLevel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sorting",
                table: "Organization_PositionFunctional",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sorting",
                table: "Organization_EmployeePosition",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sorting",
                table: "Organization_DepartmentPosition",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sorting",
                table: "Organization_DepartmentFunctional",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Organization_PostGradePostLevel");

            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Organization_PositionFunctional");

            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Organization_EmployeePosition");

            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Organization_DepartmentPosition");

            migrationBuilder.DropColumn(
                name: "Sorting",
                table: "Organization_DepartmentFunctional");
        }
    }
}
