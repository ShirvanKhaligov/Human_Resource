#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7733716edf0acde9798773801896cf882bbcf04d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7733716edf0acde9798773801896cf882bbcf04d", @"/Areas/InternalHR/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllModelVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PositionList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllEmployeeMen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllEmployeeWomans", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Departamentlər", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("null"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(60, 187, true);
            WriteLiteral("\r\n<!-- / Widget -->\r\n<div class=\"row\">\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(247, 545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07493b80970b447ab6c8e1c186a8c406", async() => {
                BeginContext(341, 360, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-primary"">
                        <i class=""fa fa-users"" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">İşçilərin sayı</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(702, 14, false);
#line 18 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.EmpCount);

#line default
#line hidden
                EndContext();
                BeginContext(716, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
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
            BeginContext(792, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(960, 563, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3231303015c4e30a6b336e959351f7e", async() => {
                BeginContext(1056, 371, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-danger"">
                        <i class=""fa fa-briefcase"" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Ümumi vəzifələrin sayı</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(1428, 19, false);
#line 35 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.PositionCount);

#line default
#line hidden
                EndContext();
                BeginContext(1447, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1523, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(1691, 548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31d4ac97df7e4d91814475e77cbe3a99", async() => {
                BeginContext(1788, 360, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-success"">
                        <i class=""fa fa-user "" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Kişilərin sayı</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(2149, 14, false);
#line 52 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.MenCount);

#line default
#line hidden
                EndContext();
                BeginContext(2163, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2239, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(2407, 554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27e4f7de37f44c2b1b8e380e018884b", async() => {
                BeginContext(2507, 361, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-warning"">
                        <i class=""fa fa-user "" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Qadınların sayı</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(2869, 16, false);
#line 69 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.WomenCount);

#line default
#line hidden
                EndContext();
                BeginContext(2885, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2961, 204, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(3165, 557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b427b5b2b6ad474e887b8868f82848b1", async() => {
                BeginContext(3263, 368, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-info"">
                        <i class=""fa fa-building"" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Ümumi departament sayı</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(3632, 14, false);
#line 88 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.DepCount);

#line default
#line hidden
                EndContext();
                BeginContext(3646, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3722, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-sm-6 col-12\">\r\n        <div class=\"card dash-widget ctm-border-radius shadow-sm grow\">\r\n            ");
            EndContext();
            BeginContext(3890, 543, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c308a0b8c6b45a28210072167530773", async() => {
                BeginContext(3984, 358, true);
                WriteLiteral(@"

                <div class=""card-body"">
                    <div class=""card-icon bg-dark"">
                        <i class=""fa fa-glass"" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Unique Visitors</h4>
                        <p class=""card-text"">");
                EndContext();
                BeginContext(4343, 14, false);
#line 105 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                        Write(Model.EmpCount);

#line default
#line hidden
                EndContext();
                BeginContext(4357, 72, true);
                WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
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
            BeginContext(4433, 1688, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-sm-6 col-12"">
        <div class=""card dash-widget ctm-border-radius shadow-sm grow"">
            <a href=""#"" class=""card-text"">

                <div class=""card-body"">
                    <div class=""card-icon bg-secondary"">
                        <i class=""fa fa-users"" aria-hidden=""true""></i>
                    </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">İşə vaxtında gəlmə</h4>
                        <p class=""card-text"">87%</p>

                    </div>
                </div>
            </a>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-sm-6 col-12"">
        <div class=""card dash-widget ctm-border-radius shadow-sm grow"">
            <a href=""#"" class=""card-text"">

                <div class=""card-body"">
                    <div class=""card-icon bg-danger"">
                        <i class=""fa fa-users"" aria-hidden=""true""></i>
           ");
            WriteLiteral(@"         </div>
                    <div class=""card-right"">
                        <h4 class=""card-title"">Məzuniyyətdəkilər</h4>
                        <p class=""card-text"">8</p>

                    </div>
                </div>
            </a>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""card ctm-border-radius shadow-sm grow"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0 d-inline-block"">Bu gün</h4>
                <a href=""javascript:void(0)"" class=""d-inline-block float-right text-primary""><i class=""lnr lnr-sync""></i></a>
            </div>

");
            EndContext();
#line 156 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
              
                var today = DateTime.Now;
                var dayoftoday = today.Day;
                var montoftoday = today.Month;
                //Console.WriteLine(dayoftoday + " " + montoftoday);
                var thismonth = today.Month;
            

#line default
#line hidden
            BeginContext(6404, 179, true);
            WriteLiteral("\r\n\r\n            <div class=\"card-body recent-activ\">\r\n                <div class=\"recent-comment\">\r\n                    <a href=\"javascript:void(0)\" class=\"dash-card text-dark\">\r\n");
            EndContext();
#line 168 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                         foreach (var item in Model.Emplooyees)
                        {
                            if (item.Birthday.Day == dayoftoday && item.Birthday.Month == montoftoday)
                            {
                                //var totaldays = ((DateTime.Now - item.Birthday).TotalDays);

#line default
#line hidden
            BeginContext(6905, 412, true);
            WriteLiteral(@"                                <div class=""dash-card-container"">
                                    <div class=""dash-card-icon text-primary"">
                                        <i class=""fa fa-birthday-cake"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""dash-card-content"">
                                        <h5 class=""mb-0"">");
            EndContext();
            BeginContext(7319, 121, false);
#line 178 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                                     Write("Bu gün " + item.FirstName + " " + item.Lastname + " - doğum günüdür." + (today.Year - item.Birthday.Year) + " yaşı olur");

#line default
#line hidden
            EndContext();
            BeginContext(7441, 91, true);
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 181 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                            }


                        }

#line default
#line hidden
            BeginContext(7594, 136, true);
            WriteLiteral("\r\n                    </a>\r\n                    <hr>\r\n                    <h2 style=\"text-align:center\"> Bu ay doğum günü olanlar</h2>\r\n");
            EndContext();
#line 189 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                     foreach (var item in Model.Emplooyees)
                    {
                        

#line default
#line hidden
#line 191 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                         if (item.Birthday.Month == thismonth)
                        {

#line default
#line hidden
            BeginContext(7905, 499, true);
            WriteLiteral(@"                            <a href=""javascript:void(0)"" class=""dash-card text-dark"">
                                <div class=""dash-card-container"">
                                    <div class=""dash-card-icon text-warning"">
                                        <i class=""fa fa-birthday-cake"" aria-hidden=""true""></i>
                                    </div>
                                    <div class=""dash-card-content"">
                                        <h6 class=""mb-0"">");
            EndContext();
            BeginContext(8406, 165, false);
#line 199 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                                     Write(item.FirstName+" "+item.Lastname+"  "+((item.Birthday.Day + "-" + item.Birthday.Month + "-" + today.Year))+" də " + (today.Year - item.Birthday.Year) + " yaşı olur.");

#line default
#line hidden
            EndContext();
            BeginContext(8572, 182, true);
            WriteLiteral("</h6>\r\n                                    </div>\r\n                                    <div class=\"dash-card-avatars\">\r\n                                        <div class=\"e-avatar\">");
            EndContext();
            BeginContext(8754, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e864582577e9471a8ef2a07538248825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8782, "~/allUserImg/", 8782, 13, true);
#line 202 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue("", 8795, item.Image !=null ?item.Image:"", 8795, 35, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8845, 52, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n");
            EndContext();
            BeginContext(9145, 108, true);
            WriteLiteral("                                </div>\r\n                            </a>\r\n                            <hr>\r\n");
            EndContext();
#line 210 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
#line 210 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                         

                    }

#line default
#line hidden
            BeginContext(9305, 402, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6 col-md-12 d-flex"">

        <!-- Team Leads List -->
        <div class=""card flex-fill team-lead shadow-sm grow"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0 d-inline-block"">Departament Müdirləri </h4>
            </div>
            <div class=""card-body"">
");
            EndContext();
#line 227 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                 foreach (var item in Model.DepartmentBoss)
                {

#line default
#line hidden
            BeginContext(9816, 134, true);
            WriteLiteral("                <div class=\"media mb-3\" style=\"border:0px !important\">\r\n                     <div class=\"e-avatar avatar-online mr-3\">");
            EndContext();
            BeginContext(9950, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58873f6bc93049598af0340fb92a6e17", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9960, "~/allUserImg/", 9960, 13, true);
#line 230 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue("", 9973, item.Meneger.Image!=null?  item.Meneger.Image:"", 9973, 51, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10055, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(10185, 88, true);
            WriteLiteral("\r\n                    <div class=\"media-body\">\r\n                        <h6 class=\"m-0\">");
            EndContext();
            BeginContext(10275, 52, false);
#line 234 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                    Write(item.Meneger.FirstName + " " + item.Meneger.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(10328, 59, true);
            WriteLiteral("</h6>\r\n                        <p class=\"mb-0 ctm-text-sm\">");
            EndContext();
            BeginContext(10388, 20, false);
#line 235 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"
                                               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(10408, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 238 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Dashboard\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(10487, 60, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllModelVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
