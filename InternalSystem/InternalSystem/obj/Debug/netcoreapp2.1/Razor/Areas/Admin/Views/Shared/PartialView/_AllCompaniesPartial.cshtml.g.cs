#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085b0ded0effe5f05a3f07a977562cdd640fa341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__AllCompaniesPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PartialView/_AllCompaniesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/PartialView/_AllCompaniesPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_PartialView__AllCompaniesPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"085b0ded0effe5f05a3f07a977562cdd640fa341", @"/Areas/Admin/Views/Shared/PartialView/_AllCompaniesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PartialView__AllCompaniesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(17, 615, true);
            WriteLiteral(@"<table style=""width:1500px"" class=""table table-bordered table-responsive-md  "">
    <thead class="" table-dark"">
        <tr>
            <th scope=""col"">Sıra №</th>
            <th scope=""col"">Şirkətin adı</th>
            <th scope=""col"">VÖEN</th>
            <th scope=""col"">Qeydiyyat nömrəsi</th>
            <th scope=""col"">Ünvan</th>
            <th scope=""col"">İnternet səhifəsi</th>
            <th scope=""col"">Poçt ünvanı</th>
            <th scope=""col"">Şəhər</th>
            <th scope=""col"">Ölkə</th>
            <th scope=""col"">Redaktə et</th>
        </tr>
    </thead>
    <tbody class=""table-hover"">
");
            EndContext();
#line 18 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
         if (Model.Companies.Count() != 0)
        {
            int count = 1;
            

#line default
#line hidden
#line 21 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
             foreach (var item in Model.Companies)
            {

#line default
#line hidden
            BeginContext(777, 57, true);
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(835, 5, false);
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(840, 30, true);
            WriteLiteral("</th>\n                    <th>");
            EndContext();
            BeginContext(871, 9, false);
#line 25 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(880, 30, true);
            WriteLiteral("</th>\n                    <td>");
            EndContext();
            BeginContext(911, 10, false);
#line 26 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.TaxId);

#line default
#line hidden
            EndContext();
            BeginContext(921, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(952, 23, false);
#line 27 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.RegistrationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(975, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1006, 12, false);
#line 28 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 32, true);
            WriteLiteral("</td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1050, "\"", 1074, 2);
            WriteAttributeValue("", 1057, "www.", 1057, 4, true);
#line 29 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
WriteAttributeValue("", 1061, item.Website, 1061, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1077, 12, false);
#line 29 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                                               Write(item.Website);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 34, true);
            WriteLiteral("</a></td>\n                    <td>");
            EndContext();
            BeginContext(1124, 12, false);
#line 30 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.ZipCode);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1167, 14, false);
#line 31 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1212, 24, false);
#line 32 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                   Write(item.City.Countries.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 152, true);
            WriteLiteral("</td>\n                    <th class=\"text-white\">\n                        <div class=\"d-flex w-100 justify-content-center\">\n                            ");
            EndContext();
            BeginContext(1388, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c70e29e4fd4d36a78fd9871832b3aa", async() => {
                BeginContext(1496, 28, true);
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
#line 35 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
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
            BeginContext(1528, 31, true);
            WriteLiteral("\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1559, "\"", 1603, 3);
            WriteAttributeValue("", 1569, "confirmationIdForCompany(", 1569, 25, true);
#line 36 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
WriteAttributeValue("", 1594, item.Id, 1594, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1602, ")", 1602, 1, true);
            EndWriteAttribute();
            BeginContext(1604, 154, true);
            WriteLiteral(" class=\"btn btn-danger ml-1\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                        </div>\n                    </th>\n                </tr>\n");
            EndContext();
#line 40 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
                count++;
            }

#line default
#line hidden
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(1830, 367, true);
            WriteLiteral(@"            <tr class=""text-danger text-center"">
                <th scope=""row"">0</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
                <th>Boş</th>
            </tr>
");
            EndContext();
#line 57 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\Shared\PartialView\_AllCompaniesPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(2207, 21, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyVM> Html { get; private set; }
    }
}
#pragma warning restore 1591