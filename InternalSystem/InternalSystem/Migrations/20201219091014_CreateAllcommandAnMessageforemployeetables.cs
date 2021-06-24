using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateAllcommandAnMessageforemployeetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllCommandsHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    CommandsToEmployeeId = table.Column<int>(nullable: true),
                    Pdf = table.Column<string>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    WorkPlaceAdditionId = table.Column<int>(nullable: true),
                    WorkTimeOfTypeId = table.Column<int>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    OldSurname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllCommandsHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllCommandsHistories_CommandsToEmployees_CommandsToEmployeeId",
                        column: x => x.CommandsToEmployeeId,
                        principalTable: "CommandsToEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AllCommandsHistories_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MessageForEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    TimeExecution = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageForEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageForEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllCommandsHistories_CommandsToEmployeeId",
                table: "AllCommandsHistories",
                column: "CommandsToEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AllCommandsHistories_EmplooyeeId",
                table: "AllCommandsHistories",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageForEmployees_EmplooyeeId",
                table: "MessageForEmployees",
                column: "EmplooyeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllCommandsHistories");

            migrationBuilder.DropTable(
                name: "MessageForEmployees");
        }
    }
}
