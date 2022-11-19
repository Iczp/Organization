using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class DepartmentType_Tree_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Depth",
                table: "Organization_DepartmentType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullPath",
                table: "Organization_DepartmentType",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullPathName",
                table: "Organization_DepartmentType",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Organization_DepartmentType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organization_DepartmentType_ParentId",
                table: "Organization_DepartmentType",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_DepartmentType_Organization_DepartmentType_ParentId",
                table: "Organization_DepartmentType",
                column: "ParentId",
                principalTable: "Organization_DepartmentType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_DepartmentType_Organization_DepartmentType_ParentId",
                table: "Organization_DepartmentType");

            migrationBuilder.DropIndex(
                name: "IX_Organization_DepartmentType_ParentId",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "FullPath",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "FullPathName",
                table: "Organization_DepartmentType");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Organization_DepartmentType");
        }
    }
}
