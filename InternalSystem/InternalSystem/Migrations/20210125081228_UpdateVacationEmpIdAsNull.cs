using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateVacationEmpIdAsNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Emplooyeees_EmplooyeeId",
                table: "Vacations");

            migrationBuilder.AlterColumn<int>(
                name: "EmplooyeeId",
                table: "Vacations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Emplooyeees_EmplooyeeId",
                table: "Vacations",
                column: "EmplooyeeId",
                principalTable: "Emplooyeees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Emplooyeees_EmplooyeeId",
                table: "Vacations");

            migrationBuilder.AlterColumn<int>(
                name: "EmplooyeeId",
                table: "Vacations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Emplooyeees_EmplooyeeId",
                table: "Vacations",
                column: "EmplooyeeId",
                principalTable: "Emplooyeees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
