using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateAdditionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddditionImage",
                table: "AdditionalInfos");

            migrationBuilder.RenameColumn(
                name: "Certificate",
                table: "AdditionalInfos",
                newName: "AdditionCertImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdditionCertImage",
                table: "AdditionalInfos",
                newName: "Certificate");

            migrationBuilder.AddColumn<string>(
                name: "AddditionImage",
                table: "AdditionalInfos",
                nullable: true);
        }
    }
}
