#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005342f20dbfc21a8b6b214e6e81a5d0cae09893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Practitioner_AllPractitioner), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Practitioner/AllPractitioner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Practitioner/AllPractitioner.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Practitioner_AllPractitioner))]
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
#line 1 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 4 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 5 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 6 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 7 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"005342f20dbfc21a8b6b214e6e81a5d0cae09893", @"/Areas/InternalHR/Views/Practitioner/AllPractitioner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Practitioner_AllPractitioner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneNumberToEmployee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recruitment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Practitioner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllLastWorks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn All_Index_View_Change_Cart_Footer_A col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
  
    ViewData["Title"] = "AllPractitioner";

#line default
#line hidden
            BeginContext(94, 2302, true);
            WriteLiteral(@"<style>


    .btn-success {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-primary {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-warning {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-danger {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-info {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }
</style>
<div class=""content-wrapper"">
    <div class="""">
        <div style=""background-color: #f4f6f9;padding:7px"" class=""card All_Index_View_Change_Card"">
            <div class=""card-header All_Index_View_Change_Card_Header"">
                <p style=""color:#f6822d"" class=""All_Index_View_Change_P"">Namizədlərin siyahısı</p>
            </div>
            <div class=""card-body "">
                <div class=""r");
            WriteLiteral(@"ow"">
                    <div class=""col-md-12 mx-auto"">
                        <div class=""table-responsive"" id=""canidateTableDiv"">
                            <table id=""dataAllSearch"" class=""table table-hover table-responsive-md"" style=""color:blue;"">
                                <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                                    <tr class=""All_Index_View_Change_Tr"">
                                        <th style=""color :#f6822d !important"" scope=""col"">Sıra №</th>
                                        <th style=""color :#f6822d !important"" scope=""col"">Soyadı,Adı,Ata adı</th>
                                        <th style=""color :#f6822d !important"" scope=""col""> Email</th>
                                        <th style=""color :#f6822d !important"" scope=""col""> Mobil nömrə</th>
                                        <th style=""color :#f6822d !important"" scope=""col""> Redaktə et</th>
                                        <th styl");
            WriteLiteral("e=\"color :#f6822d !important\" scope=\"col\">Köhnə İş yerləri</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody style=\"text-align: center\" class=\"All_Index_View_Change_Tbody\">\r\n");
            EndContext();
#line 55 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                     if (Model.Count() != 0)
                                    {
                                        int count = 1;
                                        

#line default
#line hidden
#line 58 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                         foreach (var candidatesAndNumber in Model)
                                        {

#line default
#line hidden
            BeginContext(2681, 148, true);
            WriteLiteral("                                            <tr>\r\n                                                <td style=\"color :#f6822d !important\" scope=\"row\">");
            EndContext();
            BeginContext(2830, 5, false);
#line 61 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                             Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2835, 93, true);
            WriteLiteral("</td>\r\n                                                <td style=\"color :#f6822d !important\">");
            EndContext();
            BeginContext(2930, 127, false);
#line 62 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                  Write(candidatesAndNumber.Emplooyee.Lastname+" "+candidatesAndNumber.Emplooyee.FirstName+" "+candidatesAndNumber.Emplooyee.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(3058, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 63 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                 if (candidatesAndNumber.Emplooyee.Email.Length > 22)
                                                {

#line default
#line hidden
            BeginContext(3219, 90, true);
            WriteLiteral("                                                    <td style=\"color :#f6822d !important\">");
            EndContext();
            BeginContext(3311, 57, false);
#line 65 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                      Write(candidatesAndNumber.Emplooyee.Email.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(3369, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 66 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3532, 90, true);
            WriteLiteral("                                                    <td style=\"color :#f6822d !important\">");
            EndContext();
            BeginContext(3623, 35, false);
#line 69 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                     Write(candidatesAndNumber.Emplooyee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3658, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3716, 86, true);
            WriteLiteral("                                                <td style=\"color :#f6822d !important\">");
            EndContext();
            BeginContext(3803, 43, false);
#line 71 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                 Write(candidatesAndNumber.PhoneNumber.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3846, 147, true);
            WriteLiteral("</td>\r\n                                                <td style=\"color :#f6822d !important\">\r\n                                                    ");
            EndContext();
            BeginContext(3993, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1012b4d872844388887ebab04cdcdff1", async() => {
                BeginContext(4140, 121, true);
                WriteLiteral("\r\n                                                        İşə qəbul\r\n                                                    ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                                                                WriteLiteral(candidatesAndNumber.Emplooyee.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4265, 54, true);
            WriteLiteral("\r\n                                                    ");
            EndContext();
            BeginContext(4319, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f15c47044bb40a78d7dfb8d2acad71f", async() => {
                BeginContext(4457, 28, true);
                WriteLiteral(" <i class=\"lnr lnr-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                                          WriteLiteral(candidatesAndNumber.EmplooyeeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4489, 56, true);
            WriteLiteral("\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4545, "\"", 4619, 3);
            WriteAttributeValue("", 4555, "confirmationDeleteForCandidate(", 4555, 31, true);
#line 77 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
WriteAttributeValue("", 4586, candidatesAndNumber.EmplooyeeID, 4586, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 4618, ")", 4618, 1, true);
            EndWriteAttribute();
            BeginContext(4620, 278, true);
            WriteLiteral(@" class=""btn btn-danger text-white"" title=""Sil""> <i class=""lnr lnr-trash""></i></a>
                                                </td>
                                                <td style=""color :#f6822d !important"">
                                                    ");
            EndContext();
            BeginContext(4898, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "007deccd4f854df9beb1d74211786123", async() => {
                BeginContext(5038, 29, true);
                WriteLiteral("<i class=\"lnr lnr-book\" ></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                                                                                                 WriteLiteral(candidatesAndNumber.EmplooyeeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5071, 108, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 83 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                            count++;
                                        }

#line default
#line hidden
#line 84 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(5396, 451, true);
            WriteLiteral(@"                                        <tr>
                                            <th scope=""row"">0</th>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                        </tr>
");
            EndContext();
#line 96 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5886, 241, true);
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(6127, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb55ee3b561b471b82a55c25b948c4e1", async() => {
                BeginContext(6259, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6267, 1103, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<section class=""modalForCandidate"">
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""confirmationModalForCandidate"">
        <input type=""hidden"" id=""hiddenCandidateId"" value="""" />
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title text-danger"">Silməyə əminsiniz?</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeConfirmationForCandidate()"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <a onclick=""deleteCandidate($('#hiddenCandidateId').val())"" class=""btn btn-primary"">Sil</a>
                    <a onclick=""closeConfirmationForCandidate()"" class=""btn btn-secondary text-white"" data-dismiss=""modal"">Ləvğ et</a>
     ");
            WriteLiteral("           </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7387, 199, true);
                WriteLiteral("\r\n\r\n    <script>\r\n            //////////////\r\n        function deleteCandidate(Id) {\r\n            console.log(Id)\r\n               $.ajax({\r\n                   type: \'post\',\r\n                   url: \'");
                EndContext();
                BeginContext(7587, 36, false);
#line 137 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\AllPractitioner.cshtml"
                    Write(Url.Action("Delete", "Practitioner"));

#line default
#line hidden
                EndContext();
                BeginContext(7623, 809, true);
                WriteLiteral(@"',
                   data: { CandidateId: Id},
                   success: function (response) {
                       console.log(""success"")
                       $(""#confirmationModalForCandidate"").hide()
                       $(""#canidateTableDiv"").html(response)
                   },
                   error: function (response) {
                       console.error(response)
                   }
               })
        }
        //////////////open modul
        function confirmationDeleteForCandidate(Id) {
            $(""#confirmationModalForCandidate"").show()
            $(""#hiddenCandidateId"").val(Id)
        }
        //close modul//
        function closeConfirmationForCandidate() {
            $(""#confirmationModalForCandidate"").hide()
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(8435, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneNumberToEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
