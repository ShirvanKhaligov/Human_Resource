#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3541530a6af96bbf59570914b01363977370edda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddPosition_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/AddPosition/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddPosition/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddPosition_Create))]
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
#line 1 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.ViewModels;

#line default
#line hidden
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Employee.ViewModels;

#line default
#line hidden
#line 5 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 6 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 7 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 8 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 9 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 10 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3541530a6af96bbf59570914b01363977370edda", @"/Areas/Admin/Views/AddPosition/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddPosition_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeptAndSubDeptVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("for", new global::Microsoft.AspNetCore.Html.HtmlString("PositionName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 35px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PositionName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(63, 133, true);
            WriteLiteral("\n<div class=\"content-wrapper\">\n    <div class=\"container-fluid\" style=\"padding:0px 0px 0px 250px\">\n        <br>\n        <br>\n        ");
            EndContext();
            BeginContext(196, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "079361132e4543309b365be9ee32bcba", async() => {
                BeginContext(298, 48, true);
                WriteLiteral("<i class=\"fas fa-long-arrow-alt-left\"></i>  Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 58, true);
            WriteLiteral("\n        <div class=\" \">\n            <br><br>\n            ");
            EndContext();
            BeginContext(408, 2959, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1e2bd46d99432c9823dfbc4403c891", async() => {
                BeginContext(428, 337, true);
                WriteLiteral(@"
                <div class=""form-group row ml-md-4"">
                    <label for=""CompanyName"" class=""col-md-2"">Şirkət adı:</label>
                    <div class=""form-group col-md-5"">
                        <select onchange=""getDepartment()"" class=""form-control"" id=""companySelectId"" name=""CompanyId"">
                            ");
                EndContext();
                BeginContext(765, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9098924850054968ad0084f90b0c111a", async() => {
                    BeginContext(791, 3, true);
                    WriteLiteral("Seç");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(803, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 19 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                             foreach (var company in Model.Companiess)
                            {

#line default
#line hidden
                BeginContext(905, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(937, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "855659a685fb491688e96e92e9a9dfe2", async() => {
                    BeginContext(966, 12, false);
#line 21 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                       Write(company.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                   WriteLiteral(company.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(987, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 22 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                             }

#line default
#line hidden
                BeginContext(1019, 34, true);
                WriteLiteral("                        </select>\n");
                EndContext();
#line 24 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                         if (ViewData["companyNull"] != null)
                        {

#line default
#line hidden
                BeginContext(1141, 54, true);
                WriteLiteral("                            <span class=\"text-danger\">");
                EndContext();
                BeginContext(1196, 23, false);
#line 26 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                 Write(ViewData["companyNull"]);

#line default
#line hidden
                EndContext();
                BeginContext(1219, 8, true);
                WriteLiteral("</span>\n");
                EndContext();
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                        }

#line default
#line hidden
                BeginContext(1253, 415, true);
                WriteLiteral(@"                    </div>
                </div>
                <div class=""form-group row ml-md-4"">
                    <label for=""DepartmentName"" class=""col-md-2"">Şöbə adı:</label>
                    <div class=""form-group col-md-5"" id=""DepartmentDiv"">
                        <select onchange=""getSubDepartment()"" class=""form-control"" id=""departmentSelectId"" name=""DepartmentId"">
                            ");
                EndContext();
                BeginContext(1668, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e337bd9a44f4ca8afdde039931b6933", async() => {
                    BeginContext(1694, 3, true);
                    WriteLiteral("Seç");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1706, 35, true);
                WriteLiteral("\n                        </select>\n");
                EndContext();
#line 36 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                         if (ViewData["DepartmentNull"] != null)
                        {

#line default
#line hidden
                BeginContext(1832, 54, true);
                WriteLiteral("                            <span class=\"text-danger\">");
                EndContext();
                BeginContext(1887, 26, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                 Write(ViewData["DepartmentNull"]);

#line default
#line hidden
                EndContext();
                BeginContext(1913, 7, true);
                WriteLiteral("</span>");
                EndContext();
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                                                        }

#line default
#line hidden
                BeginContext(1922, 374, true);
                WriteLiteral(@"                    </div>
                </div>
                <div class=""form-group row ml-md-4"">
                    <label for=""SubDepartmentName"" class=""col-md-2"">Alt şöbə adı:</label>
                    <div class=""form-group col-md-5"" id=""subDepartmentDiv"">
                        <select class=""form-control"" name=""SubDepartmentId"">
                            ");
                EndContext();
                BeginContext(2296, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62fcdaa03ca4d5cb23aa28fea07b738", async() => {
                    BeginContext(2322, 3, true);
                    WriteLiteral("Seç");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2334, 35, true);
                WriteLiteral("\n                        </select>\n");
                EndContext();
#line 47 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                         if (ViewData["SubdepartmentNull"] != null)
                        {

#line default
#line hidden
                BeginContext(2463, 54, true);
                WriteLiteral("                            <span class=\"text-danger\">");
                EndContext();
                BeginContext(2518, 29, false);
#line 49 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                 Write(ViewData["SubdepartmentNull"]);

#line default
#line hidden
                EndContext();
                BeginContext(2547, 7, true);
                WriteLiteral("</span>");
                EndContext();
#line 49 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                                                                                           }

#line default
#line hidden
                BeginContext(2556, 123, true);
                WriteLiteral("                    </div>\n                </div>\n                <div class=\"form-group row ml-md-4\">\n                    ");
                EndContext();
                BeginContext(2679, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616a6bdb785c472e8203087bbb04061a", async() => {
                    BeginContext(2753, 11, true);
                    WriteLiteral("Vəzifə adı:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 53 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Position.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2772, 68, true);
                WriteLiteral("\n                    <div class=\"col-md-5\">\n                        ");
                EndContext();
                BeginContext(2840, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e13202fd32504af8962415ec4c2a4012", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 55 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Position.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2951, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(2976, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfadc5d942884349b5898c186ed309f5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 56 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Position.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3051, 309, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 mx-auto"">
                        <input style=""width: 300px;"" class=""btn btn-success"" type=""submit"" value=""Əlavə et"" />
                    </div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3367, 61, true);
            WriteLiteral("\n        </div>\n    </div>\n    <!--content-wrapper-->\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3445, 358, true);
                WriteLiteral(@"
    <script>
        //Create Action.Department load in ajax
        function getDepartment() {
                var e = document.getElementById(""companySelectId"");
                var selectedCompany = e.options[e.selectedIndex].value;
                console.log(selectedCompany)
                $.ajax({
                type: ""get"",
                url: """);
                EndContext();
                BeginContext(3804, 43, false);
#line 78 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                 Write(Url.Action("CreateDeptLoad", "AddPosition"));

#line default
#line hidden
                EndContext();
                BeginContext(3847, 814, true);
                WriteLiteral(@""",
                data: { id: selectedCompany },
                success: function (respoonse) {

                    $(""#DepartmentDiv"").html(respoonse)
                    console.log(""success"")
                    console.log(respoonse)
                },
                error: function (respoonse) {
                    console.error(""error - suceess"")
                    console.error(respoonse)
                }
            })
        }

           //Create Action.SubDepartment load in ajax
         function getSubDepartment() {
                var e = document.getElementById(""departmentSelectId"");
                var selectedSubDepartment = e.options[e.selectedIndex].value;
             console.log(selectedSubDepartment)
                $.ajax({
                type: ""get"",
                url: """);
                EndContext();
                BeginContext(4662, 43, false);
#line 100 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Create.cshtml"
                 Write(Url.Action("CreateSubDLoad", "AddPosition"));

#line default
#line hidden
                EndContext();
                BeginContext(4705, 474, true);
                WriteLiteral(@""",
                    data: { id: selectedSubDepartment },
                success: function (respoonse) {
                    $(""#subDepartmentDiv"").html(respoonse)
                    console.log(""success"")
                    console.log(respoonse)
                },
                error: function (respoonse) {
                    console.error(""error - suceess"")
                    console.error(respoonse)
                }
            })
        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(5181, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeptAndSubDeptVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
