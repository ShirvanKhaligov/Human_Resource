#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f52c2f79ba5026b8f3d093574ba92ed035e765f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Employee_Index), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Employee/Index.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f52c2f79ba5026b8f3d093574ba92ed035e765f", @"/Areas/InternalHR/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Emplooyee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;border-radius:50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Redaktə et"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 15px;padding-right: 15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detallar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Practitioner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllLastWorks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Köhnə iş yeri"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 983, true);
            WriteLiteral(@"<style>


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
    .btn-info {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }
</style>
<div class=""content-wrapper"">
    <div class="""">
        <div class=""card All_Index_View_Change_Card"" style=""background-color: #f4f6f9;"">
            <div class=""card-header All_Index_View_Change_Card_Header"">
                <p class=""All_Index_View_Change_P"">İşçilərin siyahısı</p>
            </div>
            <div class=""card-body"" style=""overflow-x:scroll;"">
");
            EndContext();
            BeginContext(1133, 1022, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-12 mx-auto"">
                        <table id=""dataAllSearch"" class=""table table-responsive-md"" @*id=""employeeList""*@>
                            <thead style=""text-align: center;"" class=""All_Index_View_Change_Thead"">
                                <tr class=""All_Index_View_Change_Tr"">
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Şirkət</th>
                                    <th scope=""col"">Şəkil</th>
                                    <th scope=""col"">Soyad,Ad,Ata adı</th>
                                    <th scope=""col"">Vəzifəsi</th>
                                    <th scope=""col"">Ş\V seriyası</th>
                                    <th scope=""col"">Redaktə et</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center;"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 55 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                   int count = 1;

#line default
#line hidden
            BeginContext(2207, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 56 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    

#line default
#line hidden
#line 58 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                     foreach (var emp in Model)
                                    {

#line default
#line hidden
            BeginContext(2404, 106, true);
            WriteLiteral("                                        <tr>\r\n                                            <td scope=\"row\">");
            EndContext();
            BeginContext(2511, 5, false);
#line 61 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2516, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2572, 16, false);
#line 62 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                           Write(emp.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 105, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2693, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aecd8e835085458cb2914a85c564120e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2703, "~/allUserImg/", 2703, 13, true);
#line 64 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2716, emp.Image, 2716, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 64 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2733, emp.FirstName, 2733, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2801, 101, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
            EndContext();
            BeginContext(2904, 189, false);
#line 66 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                            Write((emp.FirstName+emp.Lastname+emp.FatherName).Length>42 ? (emp.Lastname+" "+emp.FirstName+" "+emp.FatherName).Substring(0,42)+"..." : emp.Lastname + " " + emp.FirstName + " " + emp.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(3094, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 67 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                             if (emp.Positions == null)
                                            {

#line default
#line hidden
            BeginContext(3221, 70, true);
            WriteLiteral("                                                <td>Şöbə müdiri</td>\r\n");
            EndContext();
#line 70 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3435, 73, true);
            WriteLiteral("                                                <td style=\"width:250px;\">");
            EndContext();
            BeginContext(3510, 92, false);
#line 73 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                                     Write(emp.Positions.Name.Length>50 ? emp.Positions.Name.Substring(0,49)+"..." : emp.Positions.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3603, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 74 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3657, 48, true);
            WriteLiteral("                                            <td>");
            EndContext();
            BeginContext(3706, 10, false);
#line 75 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                           Write(emp.IdCard);

#line default
#line hidden
            EndContext();
            BeginContext(3716, 183, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(3899, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f418261452df48b2be8ecd03c3106e25", async() => {
                BeginContext(4071, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                                                                                                                                                                                             WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                                                                                                                                                                                                                       WriteLiteral(ViewData["DepId"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DepId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-DepId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DepId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4102, 137, true);
            WriteLiteral("</button>\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(4239, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "811fb91587d545ff92b341478a9024a9", async() => {
                BeginContext(4420, 27, true);
                WriteLiteral("<i class=\"fas fa-info\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                                                                                                                                                                                                                                            WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4451, 137, true);
            WriteLiteral("</button>\r\n                                                <button type=\"submit\" class=\"btn\" style=\"padding-left:0px;padding-right:0px;\">");
            EndContext();
            BeginContext(4588, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53d9d4dd9ed24001a79451d0fec73410", async() => {
                BeginContext(4738, 32, true);
                WriteLiteral("<i class=\"fas fa-briefcase\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                                                                                                                                                                                                                         WriteLiteral(emp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4774, 109, true);
            WriteLiteral("</button>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 82 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"
                                     

                                }
                                else
                                {


#line default
#line hidden
            BeginContext(5084, 617, true);
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
#line 98 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\Employee\Index.cshtml"

                                }

#line default
#line hidden
            BeginContext(5738, 216, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <!--content-wrapper-->\r\n</div>\r\n\r\n");
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
