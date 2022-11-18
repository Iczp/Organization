using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class PositionType_And_EmployeeType_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PositionTypeId",
                table: "Organization_Position",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeTypeId",
                table: "Organization_Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Organization_EmployeeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name_Py = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Name_Pinyin = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Sorting = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_EmployeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization_PositionType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name_Py = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Name_Pinyin = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Sorting = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_PositionType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Position_PositionTypeId",
                table: "Organization_Position",
                column: "PositionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Employee_EmployeeTypeId",
                table: "Organization_Employee",
                column: "EmployeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeType_EmployeeTypeId",
                table: "Organization_Employee",
                column: "EmployeeTypeId",
                principalTable: "Organization_EmployeeType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Position_Organization_PositionType_PositionTypeId",
                table: "Organization_Position",
                column: "PositionTypeId",
                principalTable: "Organization_PositionType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeType_EmployeeTypeId",
                table: "Organization_Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Position_Organization_PositionType_PositionTypeId",
                table: "Organization_Position");

            migrationBuilder.DropTable(
                name: "Organization_EmployeeType");

            migrationBuilder.DropTable(
                name: "Organization_PositionType");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Position_PositionTypeId",
                table: "Organization_Position");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Employee_EmployeeTypeId",
                table: "Organization_Employee");

            migrationBuilder.DropColumn(
                name: "PositionTypeId",
                table: "Organization_Position");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeId",
                table: "Organization_Employee");
        }
    }
}
