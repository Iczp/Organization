using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Entity_GlobalAddProp_IsStatic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PostType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PostRank",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PostGradePostLevel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Organization_PostGrade",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStatic",
                table: "Organization_PostGrade",
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
                table: "Organization_Employee",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PostType");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PostRank");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PostGradePostLevel");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_PositionFunctional");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_EmployeePosition");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_DepartmentPosition");

            migrationBuilder.DropColumn(
                name: "IsStatic",
                table: "Organization_DepartmentFunctional");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Organization_PostGrade",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);
        }
    }
}
