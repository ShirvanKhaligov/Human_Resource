#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab5b01c7a110070d964858602855f1d362bfa60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Shared_PartialView__CandidatePartial), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Shared/PartialView/_CandidatePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Shared/PartialView/_CandidatePartial.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Shared_PartialView__CandidatePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab5b01c7a110070d964858602855f1d362bfa60", @"/Areas/InternalHR/Views/Shared/PartialView/_CandidatePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Shared_PartialView__CandidatePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneNumberToEmployee>>
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
            BeginContext(42, 570, true);
            WriteLiteral(@"<table id=""dataAllSearch"" class=""table table-hover table-responsive-md"">
    <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
        <tr class=""All_Index_View_Change_Tr"">
            <th scope=""col"">Sıra №</th>
            <th scope=""col"">Soyadı,Adı,Ata adı</th>
            <th scope=""col""> Email</th>
            <th scope=""col""> Mobil nömrə</th>
            <th scope=""col""> Redaktə et</th>
            <th scope=""col"">Köhnə İş yerləri</th>

        </tr>
    </thead>
    <tbody style=""text-align: center"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 15 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
         if (Model.Count() != 0)
        {
            int count = 1;
            

#line default
#line hidden
#line 18 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
             foreach (var candidatesAndNumber in Model)
            {

#line default
#line hidden
            BeginContext(752, 57, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(810, 5, false);
#line 21 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(815, 30, true);
            WriteLiteral("</th>\n                    <td>");
            EndContext();
            BeginContext(847, 127, false);
#line 22 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                    Write(candidatesAndNumber.Emplooyee.Lastname+" "+candidatesAndNumber.Emplooyee.FirstName+" "+candidatesAndNumber.Emplooyee.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(975, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 23 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                     if (candidatesAndNumber.Emplooyee.Email.Length > 22)
                    {

#line default
#line hidden
            BeginContext(1077, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1107, 57, false);
#line 25 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                        Write(candidatesAndNumber.Emplooyee.Email.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(1165, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 26 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1240, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1269, 35, false);
#line 29 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                       Write(candidatesAndNumber.Emplooyee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1332, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1357, 43, false);
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                   Write(candidatesAndNumber.PhoneNumber.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1400, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1455, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5066aaa46aa43fabc374bf217b1e6c9", async() => {
                BeginContext(1602, 63, true);
                WriteLiteral("\n                            İşə qəbul\n                        ");
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
#line 33 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
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
            BeginContext(1669, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1694, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27d4c45b0fb488fbb9cabfb4840afd4", async() => {
                BeginContext(1832, 28, true);
                WriteLiteral(" <i class=\"fas fa-edit\"></i>");
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
#line 36 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
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
            BeginContext(1864, 27, true);
            WriteLiteral("\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1891, "\"", 1965, 3);
            WriteAttributeValue("", 1901, "confirmationDeleteForCandidate(", 1901, 31, true);
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
WriteAttributeValue("", 1932, candidatesAndNumber.EmplooyeeID, 1932, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1964, ")", 1964, 1, true);
            EndWriteAttribute();
            BeginContext(1966, 156, true);
            WriteLiteral(" text-white class=\"btn btn-danger\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2122, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98a9bb3d5f6d477b9c6953c0609ee20b", async() => {
                BeginContext(2262, 32, true);
                WriteLiteral("<i class=\"fas fa-briefcase\"></i>");
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
#line 40 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
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
            BeginContext(2298, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 43 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
                count++;
            }

#line default
#line hidden
#line 44 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(2419, 219, true);
            WriteLiteral("            <tr>\n                <th scope=\"row\">0</th>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n            </tr>\n");
            EndContext();
#line 56 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Shared\PartialView\_CandidatePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(2648, 338, true);
            WriteLiteral(@"

    </tbody>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneNumberToEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
