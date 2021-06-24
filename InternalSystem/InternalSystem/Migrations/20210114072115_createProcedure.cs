﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class createProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROC dbo.selectdiscdevices  @companyId int as
                                                        begin

                                                        select  EmplooyeeId from DeviceToEmployees dvtoemp
                                                        inner join Emplooyeees emp
                                                            on dvtoemp.EmplooyeeId=emp.Id where emp.IsWorking=1 and emp.[Status]=1 and
                                                        emp.IsCandidate=0 
                                                        and emp.CompanyId=@companyId
end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string prodecure = @"Drop PROCdbo.selectdiscdevices ";
            migrationBuilder.Sql(prodecure);

        }
    }
}