#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240d06f34cafd68486352b77f77df7a2fd6ea2df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Employee_AllEmployee), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Employee/AllEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Employee/AllEmployee.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Employee_AllEmployee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240d06f34cafd68486352b77f77df7a2fd6ea2df", @"/Areas/InternalHR/Views/Employee/AllEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Employee_AllEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emplooyee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Redaktə et"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 15px;padding-right: 15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detallar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Practitioner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllLastWorks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Köhnə iş yeri"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
  
    ViewData["Title"] = "AllEmployee";

#line default
#line hidden
            BeginContext(49, 504, true);
            WriteLiteral(@"

<style>


    .btn-success {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-primary {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-warning {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-danger {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }
</style>


");
            EndContext();
            BeginContext(584, 373, true);
            WriteLiteral(@"<div class=""content-wrapper"">
    <div class="""">
        <div class=""card All_Index_View_Change_Card"" style=""background-color: #f4f6f9;"">
            <div class=""card-header All_Index_View_Change_Card_Header"">
                <p class=""All_Index_View_Change_P"">İşçilərin siyahısı</p>
            </div>
            <div class=""card-body"" style=""overflow-x:scroll;"">
");
            EndContext();
            BeginContext(1035, 121, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12 mx-auto\">\r\n                        <!---->\r\n");
            EndContext();
            BeginContext(1986, 1033, true);
            WriteLiteral(@"                        <!---->
                        <table id=""dataAllSearch"" class=""table table-responsive-md"" @*id=""employeeList""*@>
                            <thead style=""text-align: center;"" class=""All_Index_View_Change_Thead"">
                                <tr class=""All_Index_View_Change_Tr"">
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Şirkət</th>
                                    <th scope=""col"">Soyad,Ad,Ata adı</th>
                                    <th scope=""col"">Şöbə adı</th>
                                    <th scope=""col"">Vəzifəsi</th>
                                    <th scope=""col"">Ş\V seriyası</th>
                                    <th scope=""col"">Maaş</th>
                                    <th scope=""col"">Redaktə et</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center;"" class=""All_Index_View_Change_");
            WriteLiteral("Tbody\">\r\n");
            EndContext();
#line 69 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                   int count = 1;

#line default
#line hidden
            BeginContext(3071, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 70 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    

#line default
#line hidden
#line 72 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                     foreach (var emp in Model)
                                    {

#line default
#line hidden
            BeginContext(3268, 128, true);
            WriteLiteral("                                        <tr>\r\n                                            <th style=\"width: 100px;\" scope=\"row\">");
            EndContext();
            BeginContext(3397, 5, false);
#line 75 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                             Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(3402, 77, true);
            WriteLiteral("</th>\r\n                                            <td style=\"width: 110px;\">");
            EndContext();
            BeginContext(3480, 16, false);
#line 76 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                 Write(emp.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3496, 77, true);
            WriteLiteral("</td>\r\n                                            <td style=\"width: 240px;\">");
            EndContext();
            BeginContext(3575, 49, false);
#line 77 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                  Write(emp.Lastname+" "+emp.FirstName+" "+emp.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(3625, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 78 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                             if (emp.Positions == null)
                                            {

#line default
#line hidden
            BeginContext(3752, 95, true);
            WriteLiteral("                                                <td style=\"width: 110px;\">Əmr verilməyib</td>\r\n");
            EndContext();
#line 81 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3991, 74, true);
            WriteLiteral("                                                <td style=\"width: 240px;\">");
            EndContext();
            BeginContext(4067, 63, false);
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                      Write(emp.Positions.SubDepartment.DepartmentToCompany.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4131, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4185, 44, true);
            WriteLiteral("                                            ");
            EndContext();
#line 86 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                             if (emp.Positions == null)
                                            {

#line default
#line hidden
            BeginContext(4305, 95, true);
            WriteLiteral("                                                <td style=\"width: 150px;\">Əmr verilməyib</td>\r\n");
            EndContext();
#line 89 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4544, 74, true);
            WriteLiteral("                                                <td style=\"width: 150px;\">");
            EndContext();
            BeginContext(4619, 18, false);
#line 92 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                     Write(emp.Positions.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4637, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 93 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4691, 70, true);
            WriteLiteral("                                            <td style=\"width: 110px;\">");
            EndContext();
            BeginContext(4762, 10, false);
#line 94 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                 Write(emp.IdCard);

#line default
#line hidden
            EndContext();
            BeginContext(4772, 77, true);
            WriteLiteral("</td>\r\n                                            <td style=\"width: 110px;\">");
            EndContext();
            BeginContext(4850, 10, false);
#line 95 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                 Write(emp.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(4860, 204, true);
            WriteLiteral("</td>\r\n                                            <td style=\"width:155px;\">\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(5064, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43ff667c2ecc4cfe99c5a6e908018ada", async() => {
                BeginContext(5199, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                                                                                                                                                                             WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5230, 137, true);
            WriteLiteral("</button>\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(5367, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac554f12f1445d489b199c218e5adbb", async() => {
                BeginContext(5547, 27, true);
                WriteLiteral("<i class=\"fas fa-info\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                                                                                                                                                                                                                            WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5578, 137, true);
            WriteLiteral("</button>\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(5715, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935b17e6d0f74a1b8aba3f0da5e0976d", async() => {
                BeginContext(5865, 32, true);
                WriteLiteral("<i class=\"fas fa-briefcase\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                                                                                                                                                                                                                         WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5901, 109, true);
            WriteLiteral("</button>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"

                                        count++;
                                    }

#line default
#line hidden
#line 104 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                      }
                                else
                                {


#line default
#line hidden
            BeginContext(6178, 617, true);
            WriteLiteral(@"                                    <tr>
                                        <th style=""width: 100px;"">Boş</th>
                                        <th style=""width: 110px;"">Boş</th>
                                        <th style=""width: 240px;"">Boş</th>
                                        <th style=""width: 110px;"">Boş</th>
                                        <th style=""width: 110px;"">Boş</th>
                                        <th style=""width: 110px;"">Boş</th>
                                        <th style=""width: 110px;"">Boş</th>
                                    </tr>
");
            EndContext();
#line 117 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\AllEmployee.cshtml"
                                }

#line default
#line hidden
            BeginContext(6830, 218, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <!--content-wrapper-->\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7065, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(7730, 438, true);
                WriteLiteral(@"
    <script>
        function exportF(elem) {
            var table = document.getElementById(""dataAllSearch"");
            var html = table.outerHTML;
            var url = 'data:application/vnd.ms-excel,' + escape(html); // Set your html table into url
            elem.setAttribute(""href"", url);
            elem.setAttribute(""download"", ""export.xls""); // Choose the file name
            return false;
        }</script>

");
                EndContext();
            }
            );
            BeginContext(8171, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Emplooyee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
