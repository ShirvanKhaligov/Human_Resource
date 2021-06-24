using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreteFreeVacation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FreeVacationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeVacationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreeVacations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FreeVacationTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    ExecTime = table.Column<DateTime>(nullable: true),
                    CreaterUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeVacations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreeVacations_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreeVacations_FreeVacationTypes_FreeVacationTypeId",
                        column: x => x.FreeVacationTypeId,
                        principalTable: "FreeVacationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreeVacations_EmplooyeeId",
                table: "FreeVacations",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FreeVacations_FreeVacationTypeId",
                table: "FreeVacations",
                column: "FreeVacationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreeVacations");

            migrationBuilder.DropTable(
                name: "FreeVacationTypes");
        }
    }
}
