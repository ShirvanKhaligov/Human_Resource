#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e743af149014598a87b807657fa33f80a62ffa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Shared_PartialView__EmployeeDeviceDeletePartial), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Shared_PartialView__EmployeeDeviceDeletePartial))]
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
#line 1 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 4 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 5 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 6 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 7 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e743af149014598a87b807657fa33f80a62ffa2", @"/Areas/InternalHR/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Shared_PartialView__EmployeeDeviceDeletePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDeviceVm>
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
            BeginContext(25, 754, true);
            WriteLiteral(@"<table style=""color:blue;width:1250px"" class=""table table-hover table-responsive-md "">
    <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
        <tr class=""All_Index_View_Change_Tr"">
            <th scope=""col"">Sıra №</th>
            <th scope=""col"">Soyadı,Adı,Ata adı</th>
            <th scope=""col""> Ş\V seriyası</th>
            <th scope=""col""> Vəzifəsi</th>
            <th scope=""col""> Qurğunun növü</th>
            <th scope=""col""> Qurğunun kodu</th>
            <th scope=""col""> Verilmə tarixi</th>
            <th scope=""col""> Qaytarılma tarixi</th>
            <th scope=""col""> Redaktə et</th>
        </tr>
    </thead>
    <tbody style=""text-align: center;background:#efefef;"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 17 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
          
            int count = 1;
        

#line default
#line hidden
            BeginContext(827, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 20 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
         if (Model.DeviceToEmployees.Count() != 0)
        {
            

#line default
#line hidden
#line 22 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
             foreach (var dvc in Model.DeviceToEmployees)
            {

#line default
#line hidden
            BeginContext(960, 57, true);
            WriteLiteral("                <tr>\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(1018, 5, false);
#line 25 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1054, 27, false);
#line 26 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                   Write(dvc.Device.DevicesType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 27 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Count == null)
                    {

#line default
#line hidden
            BeginContext(1160, 35, true);
            WriteLiteral("                        <td>1</td>\n");
            EndContext();
#line 30 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1264, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1293, 16, false);
#line 33 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 34 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1337, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 35 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Parametr == null)
                    {

#line default
#line hidden
            BeginContext(1413, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 38 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1522, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1551, 19, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.Parametr);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1598, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 43 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.InventorCode == null)
                    {

#line default
#line hidden
            BeginContext(1678, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 46 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1787, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1816, 23, false);
#line 49 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.InventorCode);

#line default
#line hidden
            EndContext();
            BeginContext(1839, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 50 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1867, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 51 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.SerialNumber == null)
                    {

#line default
#line hidden
            BeginContext(1947, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 54 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2056, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2085, 23, false);
#line 57 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.SerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 58 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2136, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 59 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.PhoneNumber == null)
                    {

#line default
#line hidden
            BeginContext(2215, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 62 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2324, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2353, 22, false);
#line 65 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2375, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 66 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2403, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 67 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.InternalPhoneNumber == null)
                    {

#line default
#line hidden
            BeginContext(2490, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 70 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2599, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2628, 30, false);
#line 73 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.InternalPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2658, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 74 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2686, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(2711, 49, false);
#line 75 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                   Write(dvc.Device.GivingTime.ToString().Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 76 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.ReturnDate != null)
                    {

#line default
#line hidden
            BeginContext(2844, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2873, 49, false);
#line 78 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                       Write(dvc.Device.ReturnDate.ToString().Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 79 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2997, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(3059, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                     if (dvc.Device.Reason != null)
                    {
                        if (dvc.Device.Reason.Length > 20)
                        {

#line default
#line hidden
            BeginContext(3218, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3252, 39, false);
#line 88 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                            Write(dvc.Device.Reason.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(3292, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 89 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3379, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3412, 17, false);
#line 92 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                           Write(dvc.Device.Reason);

#line default
#line hidden
            EndContext();
            BeginContext(3429, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 93 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3531, 40, true);
            WriteLiteral("                        <td>------</td>\n");
            EndContext();
#line 99 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(3593, 25, true);
            WriteLiteral("                    <td>\n");
            EndContext();
#line 101 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                         if (dvc.Device.Status != false)
                        {

#line default
#line hidden
            BeginContext(3701, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3729, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "827445f314044124a5edcfd65222206a", async() => {
                BeginContext(3882, 89, true);
                WriteLiteral("\n                                <i class=\"fas fa-edit\"></i>\n                            ");
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
#line 103 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
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
            BeginContext(3975, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 106 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4057, 222, true);
            WriteLiteral("                            <a class=\"btn btn-warning\" style=\"color:white;padding: 5px 28px;pointer-events:none;\" title=\"Dəyiş\">\n                                <i class=\"fas fa-edit\"></i>\n                            </a>\n");
            EndContext();
#line 112 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(4305, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 113 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                         if (dvc.Device.Status != false)
                        {

#line default
#line hidden
            BeginContext(4388, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4418, "\"", 4491, 5);
            WriteAttributeValue("", 4428, "confirmationDeleteForDevice(\'", 4428, 29, true);
#line 115 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
WriteAttributeValue("", 4457, dvc.DeviceId, 4457, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4470, "\',\'", 4470, 3, true);
#line 115 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
WriteAttributeValue("", 4473, dvc.EmplooyeeId, 4473, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4489, "\')", 4489, 2, true);
            EndWriteAttribute();
            BeginContext(4492, 142, true);
            WriteLiteral(" class=\"badge badge-info\" title=\"Qaytar\" style=\"color:white;font-size: 11px;padding: 14px 12px;cursor:pointer;margin-top: 5px;\">TƏHVİL AL</a>\n");
            EndContext();
#line 116 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4715, 182, true);
            WriteLiteral("                            <a style=\"color:white;pointer-events:none;font-size: 11px;padding: 13px 2px;margin-top: 5px;\" class=\"badge badge-danger\" title=\"Qaytar\">TƏHVİL ALINDI</a>\n");
            EndContext();
#line 120 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(4923, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 124 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
                count++;
            }

#line default
#line hidden
#line 125 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(5044, 77, true);
            WriteLiteral("            <tr>\n                <td colspan=\"11\">Boş</td>\n            </tr>\n");
            EndContext();
#line 132 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_EmployeeDeviceDeletePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(5131, 336, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(function () {
        $('#dataAllSearch').DataTable({
            ""paging"": true,
            ""lengthChange"": true,
            ""searching"": true,
            ""ordering"": false,
            ""info"": false,
            ""autoWidth"": false,
            ""responsive"": true,
        });
    });
</script>");
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
