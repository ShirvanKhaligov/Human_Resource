using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateAdditionTableaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdCard",
                table: "Emplooyeees",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FinCode",
                table: "Emplooyeees",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdCard",
                table: "Emplooyeees",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FinCode",
                table: "Emplooyeees",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }
    }
}
