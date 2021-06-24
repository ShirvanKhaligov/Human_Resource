using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class Csddssdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HourId",
                table: "CommandsToEmployees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompaniesId = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Explanations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatingTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExeTime = table.Column<DateTime>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    FromDateForHour = table.Column<DateTime>(nullable: false),
                    PermissionTypeId = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    ToDate = table.Column<DateTime>(nullable: false)
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
                    CommandsToEmployeeId = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    WorkPlaceAdditionId = table.Column<int>(nullable: true),
                    WorkTimeOfTypeId = table.Column<int>(nullable: true)
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
                name: "Months",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: true),
                    MonthName = table.Column<string>(nullable: false),
                    MonthNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScanPdfCommands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommandsName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    Exetime = table.Column<DateTime>(nullable: false),
                    Pdf = table.Column<string>(nullable: true)
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
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: true),
                    Years = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExplanationToEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmplooyeeId = table.Column<int>(nullable: true),
                    ExplanationId = table.Column<int>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "YearToMonths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonthId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearToMonths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YearToMonths_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YearToMonths_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hours = table.Column<int>(nullable: false),
                    YearToMonthId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hours_YearToMonths_YearToMonthId",
                        column: x => x.YearToMonthId,
                        principalTable: "YearToMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandsToEmployees_HourId",
                table: "CommandsToEmployees",
                column: "HourId");

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
                name: "IX_Hours_YearToMonthId",
                table: "Hours",
                column: "YearToMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_ScanPdfCommands_EmplooyeeId",
                table: "ScanPdfCommands",
                column: "EmplooyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_YearToMonths_MonthId",
                table: "YearToMonths",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_YearToMonths_YearId",
                table: "YearToMonths",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandsToEmployees_Hours_HourId",
                table: "CommandsToEmployees",
                column: "HourId",
                principalTable: "Hours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
