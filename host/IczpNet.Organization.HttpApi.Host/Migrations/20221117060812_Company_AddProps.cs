using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IczpNet.Organization.Migrations
{
    public partial class Company_AddProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Organization_Company",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BusinessLicenseEndDate",
                table: "Organization_Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BusinessLicenseStartDate",
                table: "Organization_Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditCode",
                table: "Organization_Company",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FoundDate",
                table: "Organization_Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceTitle",
                table: "Organization_Company",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LealPerson",
                table: "Organization_Company",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Organization_Company",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RegisteredCapital",
                table: "Organization_Company",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Organization_Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxNo",
                table: "Organization_Company",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "BusinessLicenseEndDate",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "BusinessLicenseStartDate",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "CreditCode",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "FoundDate",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "InvoiceTitle",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "LealPerson",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "RegisteredCapital",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Organization_Company");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "Organization_Company");
        }
    }
}
