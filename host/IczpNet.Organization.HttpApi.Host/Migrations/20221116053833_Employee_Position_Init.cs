using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Employee_Position_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organization_Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_Employee_Organization_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Organization_Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organization_Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IsSecretary = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FullPath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FullPathName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Sorting = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_Position_Organization_Position_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Organization_Position",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organization_EmployeePosition",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_EmployeePosition", x => new { x.EmployeeId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_Organization_EmployeePosition_Organization_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Organization_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_EmployeePosition_Organization_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Organization_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Employee_DepartmentId",
                table: "Organization_Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_EmployeePosition_PositionId",
                table: "Organization_EmployeePosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Position_ParentId",
                table: "Organization_Position",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organization_EmployeePosition");

            migrationBuilder.DropTable(
                name: "Organization_Employee");

            migrationBuilder.DropTable(
                name: "Organization_Position");
        }
    }
}
