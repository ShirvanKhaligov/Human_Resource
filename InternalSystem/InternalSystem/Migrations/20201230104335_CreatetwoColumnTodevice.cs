using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreatetwoColumnTodevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IpPhoneNumber",
                table: "Devices",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpPhoneNumber",
                table: "Devices");
        }
    }
}
