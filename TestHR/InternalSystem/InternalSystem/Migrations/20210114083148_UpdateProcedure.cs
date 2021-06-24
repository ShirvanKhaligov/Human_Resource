using Microsoft.EntityFrameworkCore.Migrations;

namespace InternalSystem.Migrations
{
    public partial class UpdateProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"alter PROC dbo.selectdiscdevices  @companyId int as
                                                        begin

                                                        select dvtoemp.Id,dvtoemp.DeviceId,  EmplooyeeId from DeviceToEmployees dvtoemp
                                                        inner join Emplooyeees emp
                                                            on dvtoemp.EmplooyeeId=emp.Id where emp.IsWorking=1 and emp.[Status]=1 and
                                                        emp.IsCandidate=0 
                                                        and emp.CompanyId=@companyId
end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string prodecure = @"Drop PROC dbo.selectdiscdevices ";
            migrationBuilder.Sql(prodecure);
        }
    }
}
