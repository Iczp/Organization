using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Entity_GlobalDropProp_IsStatic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PostGradePostLevel");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PositionFunctional");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_EmployeePosition");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_DepartmentPosition");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_DepartmentFunctional");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PostGradePostLevel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PositionFunctional",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_EmployeePosition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_DepartmentPosition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_DepartmentFunctional",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
