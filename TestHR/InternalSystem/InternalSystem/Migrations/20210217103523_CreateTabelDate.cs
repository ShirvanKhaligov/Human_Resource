using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateTabelDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalendarId",
                table: "CommandsToEmployees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    GeneralWorkHour = table.Column<int>(nullable: true),
                    NormativeDay = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolidayOfCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HolidayName = table.Column<string>(nullable: true),
                    HolidayDate = table.Column<DateTime>(nullable: true),
                    CalendarId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayOfCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayOfCalendars_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandsToEmployees_CalendarId",
                table: "CommandsToEmployees",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayOfCalendars_CalendarId",
                table: "HolidayOfCalendars",
                column: "CalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandsToEmployees_Calendars_CalendarId",
                table: "CommandsToEmployees",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandsToEmployees_Calendars_CalendarId",
                table: "CommandsToEmployees");

            migrationBuilder.DropTable(
                name: "HolidayOfCalendars");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_CommandsToEmployees_CalendarId",
                table: "CommandsToEmployees");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "CommandsToEmployees");
        }
    }
}
