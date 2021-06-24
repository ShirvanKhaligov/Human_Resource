using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateOldSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OldSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    CommandsToEmployeeId = table.Column<int>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExeTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OldSalaries_CommandsToEmployees_CommandsToEmployeeId",
                        column: x => x.CommandsToEmployeeId,
                        principalTable: "CommandsToEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OldSalaries_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OldSalaries_CommandsToEmployeeId",
                table: "OldSalaries",
                column: "CommandsToEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OldSalaries_EmplooyeeId",
                table: "OldSalaries",
                column: "EmplooyeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OldSalaries");
        }
    }
}
