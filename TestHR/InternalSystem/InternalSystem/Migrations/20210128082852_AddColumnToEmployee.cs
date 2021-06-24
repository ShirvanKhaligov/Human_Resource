using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class AddColumnToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReminderVacationCount",
                table: "Emplooyeees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReminderVacationCount",
                table: "Emplooyeees");
        }
    }
}
