using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Employee_AddProp_PostGradeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PostGradeId",
                table: "Organization_Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Employee_PostGradeId",
                table: "Organization_Employee",
                column: "PostGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Employee_Organization_PostGrade_PostGradeId",
                table: "Organization_Employee",
                column: "PostGradeId",
                principalTable: "Organization_PostGrade",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Employee_Organization_PostGrade_PostGradeId",
                table: "Organization_Employee");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Employee_PostGradeId",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "PostGradeId",
                table: "Organization_Employee");
        }
    }
}
