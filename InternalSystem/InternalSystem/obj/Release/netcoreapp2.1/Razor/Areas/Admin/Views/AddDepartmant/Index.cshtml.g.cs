#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd717819272ad9cb528f321086d8efb20c724aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddDepartmant_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddDepartmant/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddDepartmant/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddDepartmant_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd717819272ad9cb528f321086d8efb20c724aaf", @"/Areas/Admin/Views/AddDepartmant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddDepartmant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeptAndSubDeptVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddDepartmant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllDepartmant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn All_Index_View_Change_Cart_Footer_A col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(62, 442, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class="""">
        <div class=""card All_Index_View_Change_Card"">
            <div class=""card-header All_Index_View_Change_Card_Header"">
                <p class=""All_Index_View_Change_P"">Şöbələrin siyahısı</p>
            </div>
            <div class=""card-body"">

                <div class=""row"">
                    <div class=""col-lg-12"">
                        ");
            EndContext();
            BeginContext(504, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8242687b7f64a47b6f96fa368d97ed7", async() => {
                BeginContext(599, 47, true);
                WriteLiteral("Yeni şöbə əlavə et <i class=\" fas fa-plus\"></i>");
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
            BeginContext(650, 830, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br><br>
                <div class=""row"">
                    <div class=""col-md-12 mx-auto"" id=""departmentTableDiv"">
                        <table style=""color:blue"" class=""table table-hover table-responsive-md "">
                            <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                                <tr class=""All_Index_View_Change_Tr"">
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Şöbənin adı</th>
                                    <th scope=""col"">Şirkətin adı</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 31 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                   var count = 1; 

#line default
#line hidden
            BeginContext(1532, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 32 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                 if (Model.Departments.Count() != 0)
                                {

                                    

#line default
#line hidden
#line 35 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                     foreach (var item in Model.DepartmentToCompanies)
                                    {

#line default
#line hidden
            BeginContext(1761, 105, true);
            WriteLiteral("                                        <tr>\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1867, 5, false);
#line 38 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 6, true);
            WriteLiteral("</th>\n");
            EndContext();
#line 39 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                             if (item.Department.Name.Length > 35)
                                            {

#line default
#line hidden
            BeginContext(2007, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2061, 42, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                                Write(item.Department.Name.Substring(0,35)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(2104, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2251, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2304, 20, false);
#line 45 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2324, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 46 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2376, 44, true);
            WriteLiteral("                                            ");
            EndContext();
#line 47 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                             if (item.Company.Name.Length > 20)
                                            {

#line default
#line hidden
            BeginContext(2502, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2556, 39, false);
#line 49 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                                Write(item.Company.Name.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(2596, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 50 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2743, 52, true);
            WriteLiteral("                                                <td>");
            EndContext();
            BeginContext(2796, 17, false);
#line 53 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                               Write(item.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2813, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 54 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2865, 46, true);
            WriteLiteral("                                        </tr>\n");
            EndContext();
#line 56 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#line 57 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                      }
                                else
                                {

#line default
#line hidden
            BeginContext(3071, 272, true);
            WriteLiteral(@"                                    <tr>
                                        <th scope=""row"">0</th>
                                        <td>Siyahı boşdur</td>
                                        <td>Siyahı boşdur</td>
                                    </tr>
");
            EndContext();
#line 65 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3377, 144, true);
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n\n\n                </div>\n\n\n            </div>\n");
            EndContext();
#line 76 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
             if (Model.Departments.Count() != 0)
            {

#line default
#line hidden
            BeginContext(3584, 62, true);
            WriteLiteral("                <div class=\"card-footer\">\n                    ");
            EndContext();
            BeginContext(3646, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "375f65ecd21b4171aae4d59427c379c2", async() => {
                BeginContext(3782, 24, true);
                WriteLiteral("Bütün şöbələrin siyahısı");
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
            BeginContext(3810, 29, true);
            WriteLiteral("\n                </div>      ");
            EndContext();
#line 80 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddDepartmant\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3841, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
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
