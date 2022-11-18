using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class BaseEntity_GlobalAddProp_Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_PostType",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_PostRank",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_PostLevel",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_PostGrade",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_PositionType",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_EmployeeType",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_EmployeeState",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_Employee",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_DepartmentType",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organization_CompanyType",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_PostType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_PostRank");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_PostLevel");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_PositionType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_EmployeeType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_EmployeeState");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organization_CompanyType");
        }
    }
}
