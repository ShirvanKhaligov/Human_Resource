#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9b2db0d94d076bf230149a95d86b253955adcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_EmployeeMessage_Index), @"mvc.1.0.view", @"/Areas/Employee/Views/EmployeeMessage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/EmployeeMessage/Index.cshtml", typeof(AspNetCore.Areas_Employee_Views_EmployeeMessage_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9b2db0d94d076bf230149a95d86b253955adcb", @"/Areas/Employee/Views/EmployeeMessage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_EmployeeMessage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageForEmployee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(81, 564, true);
            WriteLiteral(@"




<div class=""content-wrapper"">
    <div class=""col-md-12"">
        <div>
            <div>
                <table class=""table custom-table mb-0"">
                    <thead>
                        <tr>
                            <th>Sıra №</th>
                            <th>Admin</th>
                            <th>Şəkil</th>

                            <th>Məzmun</th>
                            <th>Vaxt</th>
                           
                        </tr>
                    </thead>
                    <tbody>

");
            EndContext();
#line 28 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                         if (Model.Count() != 0)
                        {
                            int count = 1;
                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(854, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(933, 5, false);
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(938, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(986, 24, false);
#line 35 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                   Write(item.Emplooyee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1012, 23, false);
#line 35 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                                             Write(item.Emplooyee.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1082, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd6e36f206184b30aec85fd282c47280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1112, "~/allUserImg/", 1112, 13, true);
#line 36 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
AddHtmlAttributeValue("", 1125, item.Image, 1125, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1139, 8, true);
            WriteLiteral(" </td>\r\n");
            EndContext();
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                     if (item.Description.Length > 60)
                                    {

#line default
#line hidden
            BeginContext(1258, 90, true);
            WriteLiteral("                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1349, 51, false);
#line 40 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                       Write(Html.Raw(item.Description.Substring(0, 40) + "..."));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 49, true);
            WriteLiteral("\r\n                                        </td>\r\n");
            EndContext();
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1569, 90, true);
            WriteLiteral("                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1660, 26, false);
#line 46 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                       Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 49, true);
            WriteLiteral("\r\n                                        </td>\r\n");
            EndContext();
#line 48 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(1776, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(1817, 41, false);
#line 50 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                   Write(item.TimeExecution.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 52 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                                count++;
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2063, 345, true);
            WriteLiteral(@"                            <tr>
                                <td>Boş</td>
                                <td>Boş</td>
                                <td>Boş</td>
                                <td>Boş</td>
                                <td>Boş</td>
                                <td>Boş</td>
                            </tr>
");
            EndContext();
#line 66 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\EmployeeMessage\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2435, 119, true);
            WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessageForEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591