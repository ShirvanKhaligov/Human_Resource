using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class CreateAdditionalEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdditionalEquipmentId",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeadPhoneCount",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InternalNumber",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MouseCount",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Parametr",
                table: "Devices",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeriaNumber",
                table: "Devices",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdditionalEquipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalEquipments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_AdditionalEquipmentId",
                table: "Devices",
                column: "AdditionalEquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_AdditionalEquipments_AdditionalEquipmentId",
                table: "Devices",
                column: "AdditionalEquipmentId",
                principalTable: "AdditionalEquipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_AdditionalEquipments_AdditionalEquipmentId",
                table: "Devices");

            migrationBuilder.DropTable(
                name: "AdditionalEquipments");

            migrationBuilder.DropIndex(
                name: "IX_Devices_AdditionalEquipmentId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "AdditionalEquipmentId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "HeadPhoneCount",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "InternalNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "MouseCount",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Parametr",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "SeriaNumber",
                table: "Devices");
        }
    }
}
