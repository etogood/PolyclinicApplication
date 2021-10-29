using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PolyclinicApplication.Migrations
{
    public partial class ch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FridayEnd",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "FridayStart",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "MondayEnd",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "MondayStart",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "SaturdayEnd",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "SaturdayStart",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "SundayEnd",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "WednesdayStart",
                table: "Schedules",
                newName: "Wednesday");

            migrationBuilder.RenameColumn(
                name: "WednesdayEnd",
                table: "Schedules",
                newName: "Tuesday");

            migrationBuilder.RenameColumn(
                name: "TuesdayStart",
                table: "Schedules",
                newName: "Thursday");

            migrationBuilder.RenameColumn(
                name: "TuesdayEnd",
                table: "Schedules",
                newName: "Sunday");

            migrationBuilder.RenameColumn(
                name: "ThursdayStart",
                table: "Schedules",
                newName: "Saturday");

            migrationBuilder.RenameColumn(
                name: "ThursdayEnd",
                table: "Schedules",
                newName: "Monday");

            migrationBuilder.RenameColumn(
                name: "SundayStart",
                table: "Schedules",
                newName: "Friday");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AddressId",
                table: "Patients",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Addresses_AddressId",
                table: "Patients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Addresses_AddressId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AddressId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Wednesday",
                table: "Schedules",
                newName: "WednesdayStart");

            migrationBuilder.RenameColumn(
                name: "Tuesday",
                table: "Schedules",
                newName: "WednesdayEnd");

            migrationBuilder.RenameColumn(
                name: "Thursday",
                table: "Schedules",
                newName: "TuesdayStart");

            migrationBuilder.RenameColumn(
                name: "Sunday",
                table: "Schedules",
                newName: "TuesdayEnd");

            migrationBuilder.RenameColumn(
                name: "Saturday",
                table: "Schedules",
                newName: "ThursdayStart");

            migrationBuilder.RenameColumn(
                name: "Monday",
                table: "Schedules",
                newName: "ThursdayEnd");

            migrationBuilder.RenameColumn(
                name: "Friday",
                table: "Schedules",
                newName: "SundayStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "FridayEnd",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FridayStart",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MondayEnd",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MondayStart",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SaturdayEnd",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SaturdayStart",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SundayEnd",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
