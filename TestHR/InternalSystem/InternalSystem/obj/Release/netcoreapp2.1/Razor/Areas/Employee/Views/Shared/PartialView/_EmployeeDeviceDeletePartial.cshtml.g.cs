#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec6289dd535302ce0b45916b9e6985c1371e178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Shared_PartialView__EmployeeDeviceDeletePartial), @"mvc.1.0.view", @"/Areas/Employee/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml", typeof(AspNetCore.Areas_Employee_Views_Shared_PartialView__EmployeeDeviceDeletePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ec6289dd535302ce0b45916b9e6985c1371e178", @"/Areas/Employee/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Shared_PartialView__EmployeeDeviceDeletePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDeviceVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeDevice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;padding: 5px 28px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 869, true);
            WriteLiteral(@"<table id=""dataAllSearchDevice"" class=""table table-hover table-responsive-md"">
    <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
        <tr class=""All_Index_View_Change_Tr"">
            <th scope=""col"">№</th>
            <th scope=""col"">Qurğu</th>
            <th scope=""col"">Say</th>
            <th scope=""col"">Parametr</th>
            <th scope=""col"">Inventor</th>
            <th scope=""col"">Serial №.</th>
            <th scope=""col"">Telefon №.</th>
            <th scope=""col"">Daxili №</th>
            <th scope=""col"">Təhvil verilən tarix</th>
            <th scope=""col"">Təhvil alınan tarix</th>
            <th scope=""col"">Təhvil alınma səbəbi</th>
            <th scope=""col"">Redaktə et</th>
        </tr>
    </thead>
    <tbody style=""text-align: center;background:#efefef;"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 20 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
          
            int count = 1;
        

#line default
#line hidden
            BeginContext(945, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
         if (Model.DeviceToEmployees.Count() != 0)
        {
            

#line default
#line hidden
#line 26 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
             foreach (var dvc in Model.DeviceToEmployees)
            {

#line default
#line hidden
            BeginContext(1084, 58, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(1143, 5, false);
#line 29 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1180, 27, false);
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                   Write(dvc.Device.DevicesType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Count == null)
                    {

#line default
#line hidden
            BeginContext(1289, 36, true);
            WriteLiteral("                        <td>1</td>\r\n");
            EndContext();
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1397, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1426, 16, false);
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1472, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 39 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Parametr == null)
                    {

#line default
#line hidden
            BeginContext(1550, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1663, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1692, 19, false);
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.Parametr);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1741, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 47 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.InventorCode == null)
                    {

#line default
#line hidden
            BeginContext(1823, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 50 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1936, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1965, 23, false);
#line 53 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.InventorCode);

#line default
#line hidden
            EndContext();
            BeginContext(1988, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 54 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2018, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 55 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.SerialNumber == null)
                    {

#line default
#line hidden
            BeginContext(2100, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 58 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2213, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2242, 23, false);
#line 61 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.SerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2265, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 62 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2295, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 63 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.PhoneNumber == null)
                    {

#line default
#line hidden
            BeginContext(2376, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 66 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2489, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2518, 22, false);
#line 69 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2540, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2570, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 71 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.InternalPhoneNumber == null)
                    {

#line default
#line hidden
            BeginContext(2659, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 74 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2772, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2801, 30, false);
#line 77 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.InternalPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 78 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2861, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(2886, 49, false);
#line 79 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                   Write(dvc.Device.GivingTime.ToString().Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 80 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.ReturnDate != null)
                    {

#line default
#line hidden
            BeginContext(3022, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(3051, 49, false);
#line 82 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.ReturnDate.ToString().Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(3100, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3179, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 87 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(3243, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 88 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Reason != null)
                    {
                        if (dvc.Device.Reason.Length > 20)
                        {

#line default
#line hidden
            BeginContext(3406, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3440, 39, false);
#line 92 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                            Write(dvc.Device.Reason.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(3480, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 93 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3571, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3604, 17, false);
#line 96 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                           Write(dvc.Device.Reason);

#line default
#line hidden
            EndContext();
            BeginContext(3621, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 97 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3729, 41, true);
            WriteLiteral("                        <td>------</td>\r\n");
            EndContext();
#line 103 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(3793, 26, true);
            WriteLiteral("                    <td>\r\n");
            EndContext();
#line 105 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                         if (dvc.Device.Status != false)
                        {

#line default
#line hidden
            BeginContext(3904, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3932, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c0172a85514e519c1b110554e427dd", async() => {
                BeginContext(4085, 91, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                                                                                   WriteLiteral(dvc.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 110 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4266, 225, true);
            WriteLiteral("                            <a class=\"btn btn-warning\" style=\"color:white;padding: 5px 28px;pointer-events:none;\" title=\"Dəyiş\">\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            </a>\r\n");
            EndContext();
#line 116 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(4518, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 117 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                         if (dvc.Device.Status != false)
                        {

#line default
#line hidden
            BeginContext(4603, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4633, "\"", 4706, 5);
            WriteAttributeValue("", 4643, "confirmationDeleteForDevice(\'", 4643, 29, true);
#line 119 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
WriteAttributeValue("", 4672, dvc.DeviceId, 4672, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4685, "\',\'", 4685, 3, true);
#line 119 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
WriteAttributeValue("", 4688, dvc.EmplooyeeId, 4688, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4704, "\')", 4704, 2, true);
            EndWriteAttribute();
            BeginContext(4707, 143, true);
            WriteLiteral(" class=\"badge badge-info\" title=\"Qaytar\" style=\"color:white;font-size: 11px;padding: 14px 12px;cursor:pointer;margin-top: 5px;\">TƏHVİL AL</a>\r\n");
            EndContext();
#line 120 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4934, 183, true);
            WriteLiteral("                            <a style=\"color:white;pointer-events:none;font-size: 11px;padding: 13px 2px;margin-top: 5px;\" class=\"badge badge-danger\" title=\"Qaytar\">TƏHVİL ALINDI</a>\r\n");
            EndContext();
#line 124 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(5144, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 127 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                count++;
            }

#line default
#line hidden
#line 128 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(5271, 80, true);
            WriteLiteral("            <tr>\r\n                <td colspan=\"11\">Boş</td>\r\n            </tr>\r\n");
            EndContext();
#line 135 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(5362, 28, true);
            WriteLiteral("\r\n\r\n\r\n    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDeviceVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
