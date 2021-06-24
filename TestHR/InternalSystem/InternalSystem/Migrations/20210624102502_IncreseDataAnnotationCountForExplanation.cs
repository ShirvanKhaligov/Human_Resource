using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class IncreseDataAnnotationCountForExplanation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Permissions",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 120);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Permissions",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
