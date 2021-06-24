using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class Createffourtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Explanations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Reason = table.Column<string>(nullable: true),
                    CreatingTime = table.Column<DateTime>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    FromDateForHour = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    PermissionTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExeTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explanations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Explanations_PermissionTypes_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "PermissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryPositionChanges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    CommandsToEmployeeId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: true),
                    WorkPlaceAdditionId = table.Column<int>(nullable: true),
                    WorkTimeOfTypeId = table.Column<int>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryPositionChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryPositionChanges_CommandsToEmployees_CommandsToEmployeeId",
                        column: x => x.CommandsToEmployeeId,
                        principalTable: "CommandsToEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPositionChanges_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScanPdfCommands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pdf = table.Column<string>(nullable: true),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    CommandsName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Exetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanPdfCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScanPdfCommands_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExplanationToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PermissionId = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    ExplanationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanationToEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExplanationToEmployees_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExplanationToEmployees_Explanations_ExplanationId",
                        column: x => x.ExplanationId,
                        principalTable: "Explanations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Explanations_PermissionTypeId",
                table: "Explanations",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanationToEmployees_EmplooyeeId",
                table: "ExplanationToEmployees",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanationToEmployees_ExplanationId",
                table: "ExplanationToEmployees",
                column: "ExplanationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPositionChanges_CommandsToEmployeeId",
                table: "HistoryPositionChanges",
                column: "CommandsToEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPositionChanges_EmplooyeeId",
                table: "HistoryPositionChanges",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScanPdfCommands_EmplooyeeId",
                table: "ScanPdfCommands",
                column: "EmplooyeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExplanationToEmployees");

            migrationBuilder.DropTable(
                name: "HistoryPositionChanges");

            migrationBuilder.DropTable(
                name: "ScanPdfCommands");

            migrationBuilder.DropTable(
                name: "Explanations");
        }
    }
}
