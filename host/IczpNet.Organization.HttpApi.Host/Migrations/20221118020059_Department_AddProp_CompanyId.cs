using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Department_AddProp_CompanyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Organization_Department",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Department_CompanyId",
                table: "Organization_Department",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Department_Organization_Company_CompanyId",
                table: "Organization_Department",
                column: "CompanyId",
                principalTable: "Organization_Company",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Department_Organization_Company_CompanyId",
                table: "Organization_Department");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Department_CompanyId",
                table: "Organization_Department");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Organization_Department");
        }
    }
}
