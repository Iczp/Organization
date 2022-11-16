using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class BaseEntity_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostType",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_PostType",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_PostType",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostRank",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_PostRank",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_PostRank",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostGrade",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_PostGrade",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_PostGrade",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_Position",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_Position",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_Level",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_Level",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_Level",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_Employee",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_Employee",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_Employee",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_DepartmentType",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_DepartmentType",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_DepartmentType",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Pinyin",
                table: "Organization_Department",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Py",
                table: "Organization_Department",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_PostType");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_PostType");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_PostRank");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_PostRank");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_Position");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_Position");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_Level");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_Level");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "Name_Pinyin",
                table: "Organization_Department");

            migrationBuilder.DropColumn(
                name: "Name_Py",
                table: "Organization_Department");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostType",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostRank",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_PostGrade",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_Level",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_Employee",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organization_DepartmentType",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);
        }
    }
}
