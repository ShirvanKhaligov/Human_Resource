#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd654ef7df0f07359f0871c903c01094c0b059a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__ProfessionPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialView/_ProfessionPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/PartialView/_ProfessionPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__ProfessionPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd654ef7df0f07359f0871c903c01094c0b059a", @"/Areas/Admin/Views/Shared/PartialView/_ProfessionPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialView__ProfessionPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Profession>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 435, true);
            WriteLiteral(@"<table class=""table table-hover table-responsive-md "">
    <thead style=""text-align: center"" class=""thead-dark "">
        <tr>
            <th scope=""col""> Sıra№</th>
            <th scope=""col"">İxtisasın adı</th>
            <th scope=""col"">Fakultənin adı</th>
            <th scope=""col"">Universitetin adı</th>
            <th scope=""col"">Redaktə et</th>
        </tr>
    </thead>
    <tbody style=""text-align: center;color:blue;"">
");
            EndContext();
#line 13 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
           var count = 1;

#line default
#line hidden
            BeginContext(493, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(541, 49, true);
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
            EndContext();
            BeginContext(591, 5, false);
#line 18 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(596, 26, true);
            WriteLiteral("</th>\n                <td>");
            EndContext();
            BeginContext(623, 9, false);
#line 19 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(632, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(659, 20, false);
#line 20 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
               Write(item.UniFaculty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(679, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(706, 59, false);
#line 21 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
               Write(item.UniFaculty.EducationTypeToUniversity.Universities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(765, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(768, 60, false);
#line 21 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
                                                                             Write(item.UniFaculty.EducationTypeToUniversity.EducationType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(828, 48, true);
            WriteLiteral(")</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(876, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "758f6fc23cc346cebba3286b3eb18ee3", async() => {
                BeginContext(997, 28, true);
                WriteLiteral(" <i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1029, 23, true);
            WriteLiteral("\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1052, "\"", 1103, 3);
            WriteAttributeValue("", 1062, "confirmationDeleteForProfession(", 1062, 32, true);
#line 24 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
WriteAttributeValue("", 1094, item.Id, 1094, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1102, ")", 1102, 1, true);
            EndWriteAttribute();
            BeginContext(1104, 119, true);
            WriteLiteral(" href=\"#\" class=\"btn btn-danger\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                </td>\n            </tr>\n");
            EndContext();
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_ProfessionPartial.cshtml"
            count++;
        }

#line default
#line hidden
            BeginContext(1254, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
