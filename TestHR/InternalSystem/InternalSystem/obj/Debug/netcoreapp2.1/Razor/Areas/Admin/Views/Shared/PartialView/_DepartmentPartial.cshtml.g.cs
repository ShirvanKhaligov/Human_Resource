#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76cdcc3a218df9c38ce76cdfa7205d53955dbfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__DepartmentPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialView/_DepartmentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/PartialView/_DepartmentPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__DepartmentPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76cdcc3a218df9c38ce76cdfa7205d53955dbfd", @"/Areas/Admin/Views/Shared/PartialView/_DepartmentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialView__DepartmentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeptAndSubDeptVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 496, true);
            WriteLiteral(@"

    <table class=""table table-hover table-responsive-md "">
        <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
            <tr class=""All_Index_View_Change_Tr"">
                <th scope=""col"">Sıra №</th>
                <th scope=""col"">Şöbənin adı</th>
                <th scope=""col"">Şirkətin adı</th>
                <th scope=""col"">Redaktə et:</th>
            </tr>
        </thead>
        <tbody style=""text-align: center"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 14 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
              
                var count = 1;
            

#line default
#line hidden
            BeginContext(580, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 17 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
             if (Model.Departments.Count() != 0)
            {

                

#line default
#line hidden
#line 20 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                 foreach (var item in Model.DepartmentToCompanies)
                {

#line default
#line hidden
            BeginContext(729, 65, true);
            WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(795, 5, false);
#line 23 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(800, 6, true);
            WriteLiteral("</th>\n");
            EndContext();
#line 24 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                         if (item.Department.Name.Length > 35)
                        {

#line default
#line hidden
            BeginContext(895, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(929, 42, false);
#line 26 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                            Write(item.Department.Name.Substring(0,35)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(972, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1059, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1092, 20, false);
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                           Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(1144, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 32 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                         if (item.Company.Name.Length > 20)
                        {

#line default
#line hidden
            BeginContext(1230, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1264, 39, false);
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                            Write(item.Company.Name.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(1304, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 35 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1391, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1424, 17, false);
#line 38 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                           Write(item.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1441, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 39 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(1473, 57, true);
            WriteLiteral("                        <td>\n                            ");
            EndContext();
            BeginContext(1530, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e5f3affd5c449f7a55e7d0bfd499eee", async() => {
                BeginContext(1613, 28, true);
                WriteLiteral(" <i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1645, 31, true);
            WriteLiteral("\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1676, "\"", 1726, 3);
            WriteAttributeValue("", 1686, "confirmationIdDepartmentForAll(", 1686, 31, true);
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
WriteAttributeValue("", 1717, item.Id, 1717, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1725, ")", 1725, 1, true);
            EndWriteAttribute();
            BeginContext(1727, 126, true);
            WriteLiteral(" class=\"btn btn-danger\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                    count++;
                }

#line default
#line hidden
#line 46 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
                 

            }
            else
            {

#line default
#line hidden
            BeginContext(1946, 215, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\">0</th>\n                    <td>Siyahı boşdur</td>\n                    <td>Siyahı boşdur</td>\n                    <td>Siyahı boşdur</td>\n                </tr>\n");
            EndContext();
#line 57 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_DepartmentPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(2175, 31, true);
            WriteLiteral("\n        </tbody>\n    </table>\n");
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
