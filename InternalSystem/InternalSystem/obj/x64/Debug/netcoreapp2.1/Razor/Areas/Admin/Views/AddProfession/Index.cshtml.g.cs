#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ad7f55e355d15bb83737eecd4860a6b5bce437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddProfession_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddProfession/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddProfession/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddProfession_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ad7f55e355d15bb83737eecd4860a6b5bce437", @"/Areas/Admin/Views/AddProfession/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddProfession_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Profession>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddProfession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllProfessions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 435, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""card-header"">
                <p style=""text-align: center;font-size: 20px;color: green"">İxtisasların siyahısı</p>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
            EndContext();
            BeginContext(504, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd318f9bac04e5890f325ebf51eab76", async() => {
                BeginContext(600, 41, true);
                WriteLiteral("Yeni ixtisas <i class=\" fas fa-plus\"></i>");
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
            BeginContext(645, 809, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br><br>
                <div class=""row"">
                    <div class=""col-md-12"" id=""professionTableDiv"">
                        <table class=""table table-hover table-responsive-md "">
                            <thead style=""text-align: center"" class=""thead-dark "">
                                <tr>
                                    <th scope=""col""> Sıra№</th>
                                    <th scope=""col"">İxtisasın adı</th>
                                    <th scope=""col"">Fakultənin adı</th>
                                    <th scope=""col"">Universitetin adı</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center;color:blue;"">
");
            EndContext();
#line 32 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    var count = 1;

                                    foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1699, 105, true);
            WriteLiteral("                                        <tr>\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1805, 5, false);
#line 39 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1810, 54, true);
            WriteLiteral("</th>\n                                            <td>");
            EndContext();
            BeginContext(1865, 9, false);
#line 40 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(1929, 20, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                           Write(item.UniFaculty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2004, 59, false);
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                           Write(item.UniFaculty.EducationTypeToUniversity.Universities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2066, 60, false);
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                                                                                         Write(item.UniFaculty.EducationTypeToUniversity.EducationType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2126, 53, true);
            WriteLiteral(")</td>\n                                        </tr>\n");
            EndContext();
#line 44 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                        count++;
                                    }
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2371, 335, true);
            WriteLiteral(@"                                    <tr class=""text-danger text-bold"">
                                        <th scope=""row"">0</th>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                    </tr>
");
            EndContext();
#line 55 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2740, 139, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 61 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
             if (Model.Count() != 0)
            {

#line default
#line hidden
            BeginContext(2930, 62, true);
            WriteLiteral("                <div class=\"card-footer\">\n                    ");
            EndContext();
            BeginContext(2992, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe4e77af1954b6c9fa03ba405cd6141", async() => {
                BeginContext(3105, 27, true);
                WriteLiteral("Bütün ixtisasların siyahısı");
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
            BeginContext(3136, 23, true);
            WriteLiteral("\n                </div>");
            EndContext();
#line 65 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\Index.cshtml"
                      }

#line default
#line hidden
            BeginContext(3161, 64, true);
            WriteLiteral("\n        </div>\n\n    </div>\n\n    <!--content-wrapper-->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Profession>> Html { get; private set; }
    }
}
#pragma warning restore 1591
