using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateBusinesstrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Districs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistricName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTripEmps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDate = table.Column<DateTime>(nullable: true),
                    ToDate = table.Column<DateTime>(nullable: true),
                    DistricId = table.Column<int>(nullable: false),
                    EmplooyeeId = table.Column<int>(nullable: false),
                    Commet = table.Column<string>(nullable: true),
                    PartnorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTripEmps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTripEmps_Districs_DistricId",
                        column: x => x.DistricId,
                        principalTable: "Districs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessTripEmps_Emplooyeees_EmplooyeeId",
                        column: x => x.EmplooyeeId,
                        principalTable: "Emplooyeees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTripEmps_DistricId",
                table: "BusinessTripEmps",
                column: "DistricId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTripEmps_EmplooyeeId",
                table: "BusinessTripEmps",
                column: "EmplooyeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessTripEmps");

            migrationBuilder.DropTable(
                name: "Districs");
        }
    }
}
