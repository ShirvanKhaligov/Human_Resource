using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateExectimeColumnToBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreaterUser",
                table: "BusinessTripEmps",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Exectime",
                table: "BusinessTripEmps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreaterUser",
                table: "BusinessTripEmps");

            migrationBuilder.DropColumn(
                name: "Exectime",
                table: "BusinessTripEmps");
        }
    }
}
