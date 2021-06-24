using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "CommandsToEmployees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandsToEmployees_ItemId",
                table: "CommandsToEmployees",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandsToEmployees_Items_ItemId",
                table: "CommandsToEmployees",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandsToEmployees_Items_ItemId",
                table: "CommandsToEmployees");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_CommandsToEmployees_ItemId",
                table: "CommandsToEmployees");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "CommandsToEmployees");
        }
    }
}
