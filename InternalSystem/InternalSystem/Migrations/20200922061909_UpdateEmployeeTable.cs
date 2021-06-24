using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdCard",
                table: "Emplooyeees",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FinCode",
                table: "Emplooyeees",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdCard",
                table: "Emplooyeees",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FinCode",
                table: "Emplooyeees",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true);
        }
    }
}
