#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f100c48eb0af7d69b1ba465f6c5bb337408cc94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddFaculty_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddFaculty/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddFaculty/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddFaculty_Index))]
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
#line 1 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Employee.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 6 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 8 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 9 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 10 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f100c48eb0af7d69b1ba465f6c5bb337408cc94", @"/Areas/Admin/Views/AddFaculty/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddFaculty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniFaculty>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddFaculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newCommand btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllFaculties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 437, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""card-header"">
                <p style=""text-align: center;font-size: 20px;color: green"">Fakültələrin siyahısı</p>
            </div>

            <div class=""card-body"">

                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
            EndContext();
            BeginContext(506, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6733c18ff2ac4686a11a2da05ee22b20", async() => {
                BeginContext(610, 42, true);
                WriteLiteral("Yeni Fakültə  <i class=\" fas fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(656, 735, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br><br>
                <div class=""row"">
                    <div class=""col-md-12"" id=""tableForFaculty"">
                        <table class=""table table-hover table-responsive-md "">
                            <thead style=""text-align: center"" class=""thead-dark "">
                                <tr>
                                    <th scope=""col""> Sıra№</th>
                                    <th scope=""col"">Fakültənin adı</th>
                                    <th scope=""col"">Universitetin adı</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center; color:blue"">
");
            EndContext();
#line 33 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    int count = 1;

                                    foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1636, 105, true);
            WriteLiteral("                                        <tr>\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1742, 5, false);
#line 40 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 54, true);
            WriteLiteral("</th>\n                                            <td>");
            EndContext();
            BeginContext(1802, 9, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(1866, 48, false);
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                           Write(item.EducationTypeToUniversity.Universities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1917, 49, false);
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                                                                              Write(item.EducationTypeToUniversity.EducationType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 53, true);
            WriteLiteral(")</td>\n                                        </tr>\n");
            EndContext();
#line 44 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                        count++;
                                    }
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2211, 282, true);
            WriteLiteral(@"                                    <tr class=""text-danger text-bold"">
                                        <th scope=""row"">0</th>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                    </tr>
");
            EndContext();
#line 54 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2527, 139, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 60 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
             if (Model.Count() != 0)
            {

#line default
#line hidden
            BeginContext(2717, 62, true);
            WriteLiteral("                <div class=\"card-footer\">\n                    ");
            EndContext();
            BeginContext(2779, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a29dbbcc48bc418ba3c944fb39289195", async() => {
                BeginContext(2887, 27, true);
                WriteLiteral("Bütün fakultələrin siyahısı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(2918, 23, true);
            WriteLiteral("\n                </div>");
            EndContext();
#line 64 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddFaculty\Index.cshtml"
                      }

#line default
#line hidden
            BeginContext(2943, 62, true);
            WriteLiteral("\n        </div>\n    </div>\n    <!--content-wrapper-->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniFaculty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
