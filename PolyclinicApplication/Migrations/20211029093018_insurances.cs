using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PolyclinicApplication.Migrations
{
    public partial class insurances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Specializations");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceIndividualPersonalAccountNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicalInsuranceId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MedicalInsurances",
                columns: table => new
                {
                    MedicalInsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalInsuranceNumber = table.Column<int>(type: "int", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsuranceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalInsurances", x => x.MedicalInsuranceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalInsuranceId",
                table: "Patients",
                column: "MedicalInsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalInsurances_MedicalInsuranceId",
                table: "Patients",
                column: "MedicalInsuranceId",
                principalTable: "MedicalInsurances",
                principalColumn: "MedicalInsuranceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalInsurances_MedicalInsuranceId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "MedicalInsurances");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalInsuranceId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "InsuranceIndividualPersonalAccountNumber",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MedicalInsuranceId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Specializations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
