using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class PostGradePostLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organization_PostRankPostGrade");

            migrationBuilder.AddColumn<Guid>(
                name: "PostRankId",
                table: "Organization_PostGrade",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Organization_PostLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStatic = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Organization_PostLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization_PostGradePostLevel",
                columns: table => new
                {
                    PostLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostGradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Organization_PostGradePostLevel", x => new { x.PostGradeId, x.PostLevelId });
                    table.ForeignKey(
                        name: "FK_Organization_PostGradePostLevel_Organization_PostGrade_PostGradeId",
                        column: x => x.PostGradeId,
                        principalTable: "Organization_PostGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_PostGradePostLevel_Organization_PostLevel_PostLevelId",
                        column: x => x.PostLevelId,
                        principalTable: "Organization_PostLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PostGrade_PostRankId",
                table: "Organization_PostGrade",
                column: "PostRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PostGradePostLevel_PostLevelId",
                table: "Organization_PostGradePostLevel",
                column: "PostLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_PostGrade_Organization_PostRank_PostRankId",
                table: "Organization_PostGrade",
                column: "PostRankId",
                principalTable: "Organization_PostRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_PostGrade_Organization_PostRank_PostRankId",
                table: "Organization_PostGrade");

            migrationBuilder.DropTable(
                name: "Organization_PostGradePostLevel");

            migrationBuilder.DropTable(
                name: "Organization_PostLevel");

            migrationBuilder.DropIndex(
                name: "IX_Organization_PostGrade_PostRankId",
                table: "Organization_PostGrade");

            migrationBuilder.DropColumn(
                name: "PostRankId",
                table: "Organization_PostGrade");

            migrationBuilder.CreateTable(
                name: "Organization_PostRankPostGrade",
                columns: table => new
                {
                    PostRankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostGradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_PostRankPostGrade", x => new { x.PostRankId, x.PostGradeId });
                    table.ForeignKey(
                        name: "FK_Organization_PostRankPostGrade_Organization_PostGrade_PostGradeId",
                        column: x => x.PostGradeId,
                        principalTable: "Organization_PostGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_PostRankPostGrade_Organization_PostRank_PostRankId",
                        column: x => x.PostRankId,
                        principalTable: "Organization_PostRank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PostRankPostGrade_PostGradeId",
                table: "Organization_PostRankPostGrade",
                column: "PostGradeId");
        }
    }
}
