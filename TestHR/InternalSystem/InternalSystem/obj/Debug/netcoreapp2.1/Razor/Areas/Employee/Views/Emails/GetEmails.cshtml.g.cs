#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e5ce1322af81a1529db006dbb29a30bfa3a858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Emails_GetEmails), @"mvc.1.0.view", @"/Areas/Employee/Views/Emails/GetEmails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Emails/GetEmails.cshtml", typeof(AspNetCore.Areas_Employee_Views_Emails_GetEmails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e5ce1322af81a1529db006dbb29a30bfa3a858", @"/Areas/Employee/Views/Emails/GetEmails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Emails_GetEmails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InternalSystem.Areas.InternalHR.Models.MailRu.EmailMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
  
    ViewData["Title"] = "GetEmails";

#line default
#line hidden
            BeginContext(126, 172, true);
            WriteLiteral("\r\n<h2>mailler</h2>    >\r\n<div class=\"content-wrapper\">\r\n \r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(298, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9370c2a4cbe74894a863994a9f2b53e9", async() => {
                BeginContext(321, 15, true);
                WriteLiteral("Yenisini duzelt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(340, 188, true);
            WriteLiteral("\r\n                </p>\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(529, 43, false);
#line 19 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
                           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(572, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(676, 43, false);
#line 22 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
                           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(719, 37, true);
            WriteLiteral("\r\n                            </th>\r\n");
            EndContext();
            BeginContext(907, 92, true);
            WriteLiteral("\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1080, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
            BeginContext(1276, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1351, 23, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
                               Write(Html.Raw( item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Emails\GetEmails.cshtml"
                        }

#line default
#line hidden
            BeginContext(1479, 111, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InternalSystem.Areas.InternalHR.Models.MailRu.EmailMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
