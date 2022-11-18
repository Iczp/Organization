using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class CompanyType_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyTypeId",
                table: "Organization_Company",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Organization_CompanyType",
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
                    table.PrimaryKey("PK_Organization_CompanyType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Company_CompanyTypeId",
                table: "Organization_Company",
                column: "CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Company_Organization_CompanyType_CompanyTypeId",
                table: "Organization_Company",
                column: "CompanyTypeId",
                principalTable: "Organization_CompanyType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Company_Organization_CompanyType_CompanyTypeId",
                table: "Organization_Company");

            migrationBuilder.DropTable(
                name: "Organization_CompanyType");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Company_CompanyTypeId",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Organization_Company");
        }
    }
}
