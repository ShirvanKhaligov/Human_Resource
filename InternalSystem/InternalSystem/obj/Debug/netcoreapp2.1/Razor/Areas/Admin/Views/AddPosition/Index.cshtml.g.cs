#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a045a0737cda1b2779113b186776c381a62770ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddPosition_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AddPosition/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddPosition/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddPosition_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a045a0737cda1b2779113b186776c381a62770ec", @"/Areas/Admin/Views/AddPosition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddPosition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeptAndSubDeptVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
            BeginContext(59, 436, true);
            WriteLiteral(@"

<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""card-header"">
                <p style=""text-align: center;font-size: 20px; color: green"">Vəzifələrin siyahısı</p>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        ");
            EndContext();
            BeginContext(495, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "302dffff77d945d784b4e653cadde7f7", async() => {
                BeginContext(588, 49, true);
                WriteLiteral("Yeni vəzifə əlavə et <i class=\" fas fa-plus\"></i>");
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
            BeginContext(641, 814, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br><br>
                <div class=""row"">
                    <div class=""col-md-12 mx-auto"" id=""positionTableDiv"">
                        <table style=""color:blue"" class=""table table-hover table-responsive-md "">
                            <thead style=""text-align: center"" class=""thead-dark "">
                                <tr>
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Vəzifə adı</th>
                                    <th scope=""col"">Alt şöbənin adı</th>
                                    <th scope=""col"">Şöbənin adı</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center"">
");
            EndContext();
#line 32 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
                                   var count = 1; 

#line default
#line hidden
            BeginContext(1507, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 33 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
                                 if (Model.Positions.Count() != 0)
                                {

                    

#line default
#line hidden
#line 36 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
                     foreach (var item in Model.Positions)
                    {

#line default
#line hidden
            BeginContext(1690, 33, true);
            WriteLiteral("    <tr>\n        <th scope=\"row\">");
            EndContext();
            BeginContext(1724, 5, false);
#line 39 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1729, 18, true);
            WriteLiteral("</th>\n        <td>");
            EndContext();
            BeginContext(1748, 9, false);
#line 40 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1776, 23, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
       Write(item.SubDepartment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1818, 54, false);
#line 42 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
       Write(item.SubDepartment.DepartmentToCompany.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 44 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
count++;
}

#line default
#line hidden
#line 45 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
  }
                else
                {

#line default
#line hidden
            BeginContext(1940, 143, true);
            WriteLiteral("    <tr>\n        <th scope=\"row\">0</th>\n        <td>Siyahı boşdur</td>\n        <td>Siyahı boşdur</td>\n        <td>Siyahı boşdur</td>\n    </tr>\n");
            EndContext();
#line 54 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2085, 140, true);
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 61 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
             if (Model.Positions.Count() != 0)
            {

#line default
#line hidden
            BeginContext(2286, 30, true);
            WriteLiteral("<div class=\"card-footer\">\n    ");
            EndContext();
            BeginContext(2316, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d88b0eca50e406ca4fc47fdb8551be1", async() => {
                BeginContext(2424, 26, true);
                WriteLiteral("Bütün vəzifələrin siyahısı");
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
            BeginContext(2454, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
#line 65 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddPosition\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(2463, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeptAndSubDeptVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
