using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateWorkDateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    IsSpecialDay = table.Column<bool>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkDateToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkDatesId = table.Column<int>(nullable: true),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDateToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkDateToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkDateToEmployees_WorkDates_WorkDatesId",
                        column: x => x.WorkDatesId,
                        principalTable: "WorkDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkDateToEmployees_EmplooyeeId",
                table: "WorkDateToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDateToEmployees_WorkDatesId",
                table: "WorkDateToEmployees",
                column: "WorkDatesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkDateToEmployees");

            migrationBuilder.DropTable(
                name: "WorkDates");
        }
    }
}
