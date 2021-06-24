using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateDeviceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadPhoneCount",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "InternalNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "IpPhoneNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "SeriaNumber",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "MouseCount",
                table: "Devices",
                newName: "Count");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Devices",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parametr",
                table: "Devices",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GivingTime",
                table: "Devices",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "InternalPhoneNumber",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventorCode",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Devices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalPhoneNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "InventorCode",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Devices",
                newName: "MouseCount");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Devices",
                maxLength: 155,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parametr",
                table: "Devices",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GivingTime",
                table: "Devices",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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
                name: "IpPhoneNumber",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Devices",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeriaNumber",
                table: "Devices",
                maxLength: 200,
                nullable: true);
        }
    }
}
