using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace InternalSystem.Migrations
{
    public partial class spSelectAllEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var sp = @"create procedure SelectAllEmployeem
as  select * from Emplooyeees";

            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
