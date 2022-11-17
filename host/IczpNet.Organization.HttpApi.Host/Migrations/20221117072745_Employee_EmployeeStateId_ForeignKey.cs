using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Employee_EmployeeStateId_ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeState_DepartmentId",
                table: "Organization_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_Employee_EmployeeStateId",
                table: "Organization_Employee",
                column: "EmployeeStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeState_EmployeeStateId",
                table: "Organization_Employee",
                column: "EmployeeStateId",
                principalTable: "Organization_EmployeeState",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeState_EmployeeStateId",
                table: "Organization_Employee");

            migrationBuilder.DropIndex(
                name: "IX_Organization_Employee_EmployeeStateId",
                table: "Organization_Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Employee_Organization_EmployeeState_DepartmentId",
                table: "Organization_Employee",
                column: "DepartmentId",
                principalTable: "Organization_EmployeeState",
                principalColumn: "Id");
        }
    }
}
