#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9785854173040f4590c9c8054b6eee93921b391c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_ReminderVacation_Update), @"mvc.1.0.view", @"/Areas/Employee/Views/ReminderVacation/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/ReminderVacation/Update.cshtml", typeof(AspNetCore.Areas_Employee_Views_ReminderVacation_Update))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Employee.ViewModels;

#line default
#line hidden
#line 4 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 5 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 6 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9785854173040f4590c9c8054b6eee93921b391c", @"/Areas/Employee/Views/ReminderVacation/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_ReminderVacation_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReminderVacationVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(69, 1483, true);
            WriteLiteral(@"

<div class=""content-wrapper"" style=""color: black; background-color: rgb(255, 255, 255);"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12 mx-auto"">
                <div>
                    <table id=""dataAllSearch"" class=""table table-hover table-responsive-md mytable"">
                        <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                            <tr class=""All_Index_View_Change_Tr"">
                                <th scope=""col"">Sıra №</th>
                                <th scope=""col"">İşə qəbul</th>
                                <th scope=""col"">Soyadı,Adı,Ata adı</th>
                                <th scope=""col"">Məzuniyyət qalığı</th>
                                <th scope=""col"">Məzuniyyət ili</th>
                                <th scope=""col"">MƏZUNİYYƏT GÜNÜ ƏSAS</th>
                                <th scope=""col"">Işlədiyi ay</th>
                                <th scope=""col"">Şirkət");
            WriteLiteral(@"</th>
                                <th scope=""col"">Əlavə məzuniyyət</th>
                                <th scope=""col"">Neçə gün düşür</th>
                                <th scope=""col"">Vəzifəsi</th>
                                <th scope=""col"">Əməliyyat</th>
                            </tr>
                        </thead>
                        <tbody style=""text-align: center;background:#efefef;"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                               int count = 1; 

#line default
#line hidden
            BeginContext(1601, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                             if (Model.CommandsToEmployees != null)
                            {
                                

#line default
#line hidden
#line 33 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                 foreach (var command in Model.CommandsToEmployees.Take(25))
                                {

#line default
#line hidden
            BeginContext(1830, 98, true);
            WriteLiteral("                                    <tr>\r\n                                        <td scope=\"row\">");
            EndContext();
            BeginContext(1929, 5, false);
#line 36 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1934, 63, true);
            WriteLiteral("</td>\r\n                                        <td scope=\"row\">");
            EndContext();
            BeginContext(1998, 42, false);
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                   Write(command.CreatedDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2093, 93, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        Write(command.Emplooyee.Lastname+" "+command.Emplooyee. FirstName+" "+command .Emplooyee.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(2187, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2190, 48, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                                                                                                         Write(command.Emplooyee .GenderId==1 ? "oğlu" : "qızı");

#line default
#line hidden
            EndContext();
            BeginContext(2239, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2291, 39, false);
#line 39 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                       Write(command.Emplooyee.ReminderVacationCount);

#line default
#line hidden
            EndContext();
            BeginContext(2330, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 40 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                           var month = command.CreatedDate.Month;
                                            var day = command.CreatedDate.Day;
                                            var currentyear = DateTime.Now.Year;
                                            DateTime todaydate = DateTime.Today;
                                            DateTime firsja = new DateTime(todaydate.Year, 01, 01);
                                            var nextyear = DateTime.Now.AddYears(1).Year;
                                            var valid_date_now = day + "." + month + "." + currentyear;
                                            var valid_date_next = day + "." + month + "." + nextyear;
                                            //+ "-" + day + "/" + month + "/" + nextyear
                                            //TimeSpan diff = DateTime.Now - OtherDateTime;
                                            //int days = (int)Math.Abs(Math.Round(diff.TotalDays));
                                            //int days = (int)Math.Abs(Math.Round(diff.TotalDays));

                                        

#line default
#line hidden
            BeginContext(3494, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 54 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (DateTime.Parse(valid_date_now) > DateTime.Now)
                                        {

#line default
#line hidden
            BeginContext(3630, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(3680, 125, false);
#line 56 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            Write(DateTime.Parse(valid_date_now).AddYears(-1).ToString("dd/MM/yyy")+"-"+(DateTime.Parse(valid_date_now)).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3806, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 57 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else if (command.CreatedDate.Year == DateTime.Now.Year)
                                        {

#line default
#line hidden
            BeginContext(3996, 49, true);
            WriteLiteral("                                            <td> ");
            EndContext();
            BeginContext(4047, 103, false);
#line 60 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                             Write(command.CreatedDate.ToString("dd/MM/yyyy")+"-"+(command.CreatedDate.AddYears(1).ToString("dd/MM/yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(4151, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 61 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else if (DateTime.Parse(valid_date_now) < DateTime.Now)
                                        {

#line default
#line hidden
            BeginContext(4341, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(4391, 127, false);
#line 64 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            Write(DateTime.Parse(valid_date_now).ToString("dd/MM/yyy") + "-"+ (DateTime.Parse(valid_date_now).AddYears(1).ToString("dd/MM/yyy")) );

#line default
#line hidden
            EndContext();
            BeginContext(4519, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(4658, 56, true);
            WriteLiteral("                                            <td>b</td>\r\n");
            EndContext();
#line 69 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4757, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 70 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (command.Emplooyee.Positions.VacationDayCount == 0)
                                        {

#line default
#line hidden
            BeginContext(4897, 56, true);
            WriteLiteral("                                            <td>0</td>\r\n");
            EndContext();
#line 73 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(5085, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(5134, 44, false);
#line 76 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                           Write(command.Emplooyee.Positions.VacationDayCount);

#line default
#line hidden
            EndContext();
            BeginContext(5178, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 77 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5228, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 78 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                          
                                            var ay = ((DateTime.Now - command.CreatedDate).TotalDays) / 30.4;
                                        

#line default
#line hidden
            BeginContext(5426, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (ay <= 12)
                                        {

#line default
#line hidden
            BeginContext(5527, 72, true);
            WriteLiteral("                                            <td class=\"btn btn-warning\">");
            EndContext();
            BeginContext(5601, 28, false);
#line 84 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                                    Write(ay.ToString().Substring(0,3));

#line default
#line hidden
            EndContext();
            BeginContext(5630, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(5769, 81, true);
            WriteLiteral("                                            <td class=\"btn btn-primary\">12</td>\r\n");
            EndContext();
#line 89 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5893, 44, true);
            WriteLiteral("                                        <td>");
            EndContext();
            BeginContext(5938, 30, false);
#line 90 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                       Write(command.Emplooyee.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5968, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 91 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (command.Emplooyee.AdditionalVacationDay == null)
                                        {

#line default
#line hidden
            BeginContext(6113, 56, true);
            WriteLiteral("                                            <td>0</td>\r\n");
            EndContext();
#line 94 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(6301, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(6350, 39, false);
#line 97 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                           Write(command.Emplooyee.AdditionalVacationDay);

#line default
#line hidden
            EndContext();
            BeginContext(6389, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 98 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"

                                        }

#line default
#line hidden
            BeginContext(6441, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 100 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (command.Emplooyee.Positions.VacationDayCount == 30)
                                        {
                                            

#line default
#line hidden
#line 102 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                             if (DateTime.Parse(valid_date_now) > DateTime.Now)
                                            {
                                                var totalday = (DateTime.Now - DateTime.Parse(valid_date_now).AddYears(-1)).TotalDays;
                                                int roundday = (int)Math.Abs(Math.Round(totalday));
                                                var remvac = (roundday / 30.4) * 2.5;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));

#line default
#line hidden
            BeginContext(7152, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(7206, 11, false);
#line 108 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(7218, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 109 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }
                                            else if (command.CreatedDate.Year == DateTime.Now.Year)
                                            {
                                                var totalday = (DateTime.Now - (command.CreatedDate)).TotalDays;
                                                int roundtotalday = (int)Math.Abs(Math.Round(totalday));
                                                var remvac = (roundtotalday / 30.4) * 2.5;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));

#line default
#line hidden
            BeginContext(7834, 53, true);
            WriteLiteral("                                                <td> ");
            EndContext();
            BeginContext(7889, 11, false);
#line 116 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                 Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(7901, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 117 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }
                                            else if (DateTime.Parse(valid_date_now) < DateTime.Now)
                                            {
                                                var totalday = ((DateTime.Now - DateTime.Parse(valid_date_now)).TotalDays);
                                                int roundtotalday = (int)Math.Abs(Math.Round(totalday));

                                                var remvac = (roundtotalday / 30.4) * 2.5;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));


#line default
#line hidden
            BeginContext(8532, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(8586, 11, false);
#line 126 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(8598, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 127 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(8750, 60, true);
            WriteLiteral("                                                <td>b</td>\r\n");
            EndContext();
#line 131 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }

#line default
#line hidden
#line 131 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                             

                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#line 136 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                             if (DateTime.Parse(valid_date_now) > DateTime.Now)
                                            {
                                                var totalday = (DateTime.Now - DateTime.Parse(valid_date_now).AddYears(-1)).TotalDays;
                                                int roundday = (int)Math.Abs(Math.Round(totalday));
                                                var remvac = (roundday / 30.4) * 1.75;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));

#line default
#line hidden
            BeginContext(9562, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(9616, 11, false);
#line 142 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(9628, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 143 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"

                                            }
                                            else if (command.CreatedDate.Year == DateTime.Now.Year)
                                            {
                                                var totalday = (DateTime.Now - (command.CreatedDate)).TotalDays;
                                                int roundtotalday = (int)Math.Abs(Math.Round(totalday));
                                                var remvac = (roundtotalday / 30.4) * 1.75;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));

#line default
#line hidden
            BeginContext(10247, 53, true);
            WriteLiteral("                                                <td> ");
            EndContext();
            BeginContext(10302, 11, false);
#line 151 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                 Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(10314, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 152 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }
                                            else if (DateTime.Parse(valid_date_now) < DateTime.Now)
                                            {
                                                var totalday = ((DateTime.Now - DateTime.Parse(valid_date_now)).TotalDays);
                                                int roundtotalday = (int)Math.Abs(Math.Round(totalday));
                                                var remvac = (roundtotalday / 30.4) * 1.75;
                                                int roundremvac = (int)Math.Abs(Math.Round(remvac));


#line default
#line hidden
            BeginContext(10944, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(10998, 11, false);
#line 160 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                                Write(roundremvac);

#line default
#line hidden
            EndContext();
            BeginContext(11010, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 161 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(11162, 60, true);
            WriteLiteral("                                                <td>b</td>\r\n");
            EndContext();
#line 165 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                            }

#line default
#line hidden
#line 165 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(11312, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 167 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                         if (@command.Emplooyee.Positions == null)
                                        {

#line default
#line hidden
            BeginContext(11439, 66, true);
            WriteLiteral("                                            <td>Şöbə Müdiri</td>\r\n");
            EndContext();
#line 170 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(11637, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(11686, 32, false);
#line 173 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                           Write(command.Emplooyee.Positions.Name);

#line default
#line hidden
            EndContext();
            BeginContext(11718, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 174 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                        }

#line default
#line hidden
            BeginContext(11768, 163, true);
            WriteLiteral("                                        <td><a class=\"btn btn-warning\"href=\"#\"><i class=\"fas fa-edit\">Bax</i></a></td>\r\n                                    </tr>\r\n");
            EndContext();
#line 177 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                    count++;
                                }

#line default
#line hidden
#line 178 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\ReminderVacation\Update.cshtml"
                                 }

#line default
#line hidden
            BeginContext(12013, 144, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(12174, 290, true);
                WriteLiteral(@"
    <script>
        $('.mytable').dataTable({
            ""pageLength"": 100
        });
                                //$('#dataAllSearch').dataTable({
                                //    ""pageLenth"": [10, 25, 50, 75, 100]
                                //});
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReminderVacationVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
