using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateAdditionTableaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ComputerSkillToLevels",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ComputerSkillToLevels");
        }
    }
}
