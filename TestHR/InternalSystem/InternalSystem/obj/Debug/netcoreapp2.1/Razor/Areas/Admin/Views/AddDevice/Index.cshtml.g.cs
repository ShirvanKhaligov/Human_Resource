#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924ce1f5278b0df040d9154b57536a2b3977378e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddDevice_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddDevice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddDevice/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddDevice_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"924ce1f5278b0df040d9154b57536a2b3977378e", @"/Areas/Admin/Views/AddDevice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddDevice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevicesType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddDevice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllDevice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 434, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""card-header"">
                <p style=""text-align: center;font-size: 20px; color: green"">Qurğuların siyahısı</p>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        ");
            EndContext();
            BeginContext(504, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58fb5b3076f8411aa354611984696146", async() => {
                BeginContext(595, 48, true);
                WriteLiteral("Yeni qurğu əlavə et <i class=\" fas fa-plus\"></i>");
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
            BeginContext(647, 676, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br><br>
                <div class=""row"">
                    <div class=""col-md-12 mx-auto"" id=""departmentTableDiv"">
                        <table style=""color:blue"" class=""table table-hover table-responsive-md "">
                            <thead style=""text-align: center"" class=""thead-dark "">
                                <tr>
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Qurğunun adı</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center"">
");
            EndContext();
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                   var count = 1; 

#line default
#line hidden
            BeginContext(1375, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                 if (Model.Count() != 0)
                                {

                                    

#line default
#line hidden
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1570, 105, true);
            WriteLiteral("                                        <tr>\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1676, 5, false);
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 54, true);
            WriteLiteral("</th>\n                                            <td>");
            EndContext();
            BeginContext(1736, 9, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 52, true);
            WriteLiteral("</td>\n                                        </tr>\n");
            EndContext();
#line 40 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#line 41 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                      }
                                else
                                {

#line default
#line hidden
            BeginContext(1957, 209, true);
            WriteLiteral("                                    <tr>\n                                        <th scope=\"row\">0</th>\n                                        <td>Siyahı boşdur</td>\n                                    </tr>\n");
            EndContext();
#line 48 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2200, 144, true);
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n\n\n                </div>\n\n\n            </div>\n");
            EndContext();
#line 59 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
             if (Model.Count() != 0)
            {

#line default
#line hidden
            BeginContext(2395, 62, true);
            WriteLiteral("                <div class=\"card-footer\">\n                    ");
            EndContext();
            BeginContext(2457, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "565b92c54f5f4e17b45673b86cea5455", async() => {
                BeginContext(2561, 25, true);
                WriteLiteral("Bütün qurğuların siyahısı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2590, 23, true);
            WriteLiteral("\n                </div>");
            EndContext();
#line 63 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddDevice\Index.cshtml"
                      }

#line default
#line hidden
            BeginContext(2615, 34, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevicesType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
