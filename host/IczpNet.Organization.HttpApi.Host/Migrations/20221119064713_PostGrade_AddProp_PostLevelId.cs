using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class PostGrade_AddProp_PostLevelId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PostLevelId",
                table: "Organization_PostGrade",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PostGrade_PostLevelId",
                table: "Organization_PostGrade",
                column: "PostLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_PostGrade_Organization_PostLevel_PostLevelId",
                table: "Organization_PostGrade",
                column: "PostLevelId",
                principalTable: "Organization_PostLevel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_PostGrade_Organization_PostLevel_PostLevelId",
                table: "Organization_PostGrade");

            migrationBuilder.DropIndex(
                name: "IX_Organization_PostGrade_PostLevelId",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "PostLevelId",
                table: "Organization_PostGrade");
        }
    }
}
