using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PolyclinicApplication.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportCode",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PassportDate",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PassportExtraditionPlace",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "PassportId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    PassportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassportExtraditionPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.PassportId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PassportId",
                table: "Patients",
                column: "PassportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Passports_PassportId",
                table: "Patients",
                column: "PassportId",
                principalTable: "Passports",
                principalColumn: "PassportId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Passports_PassportId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PassportId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PassportId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "PassportCode",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PassportDate",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PassportExtraditionPlace",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
