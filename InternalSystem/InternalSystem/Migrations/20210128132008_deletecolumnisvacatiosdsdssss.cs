using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class deletecolumnisvacatiosdsdssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInVacation",
                table: "Emplooyeees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInVacation",
                table: "Emplooyeees",
                nullable: false,
                defaultValue: false);
        }
    }
}
