#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e006a47498d0fa179ce25c8b1dc8c286c1bad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Adminn_AllAdminList), @"mvc.1.0.view", @"/Areas/Admin/Views/Adminn/AllAdminList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Adminn/AllAdminList.cshtml", typeof(AspNetCore.Areas_Admin_Views_Adminn_AllAdminList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e006a47498d0fa179ce25c8b1dc8c286c1bad1", @"/Areas/Admin/Views/Adminn/AllAdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Adminn_AllAdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adminn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
  
    ViewData["Title"] = "AllAdminList";

#line default
#line hidden
            BeginContext(60, 1454, true);
            WriteLiteral(@"
<div style=""background-color: white"" class=""page-wrapper"">

    <div class=""container-fluid"">

        <div class=""card"">
            <div class=""card-header"">
                <p style=""color: green;text-align: center;font-size: 25px"">Adminlərin siyahısı</p>
            </div>
            <div class=""card-body"" style=""overflow-x:scroll"">
                <div class=""row"">
                    <div class=""col-md-12"" id=""AdminTableDiv"">
                        <table style=""width:1500px"" class=""table table-bordered table-responsive-md text-center"">
                            <thead class="" table-dark"">
                                <tr>
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Şəkil</th>
                                    <th scope=""col"">Şirkətin adı</th>
                                    <th scope=""col"">Adminin adı</th>
                                    <th scope=""col"">Soyadı</th>
                                    <th scope=""co");
            WriteLiteral(@"l"">Atasının adı</th>
                                    <th scope=""col"">Tel nömrəsi</th>
                                    <th scope=""col"">İstifadəçi adı</th>
                                    <th scope=""col"">Poçt ünvanı</th>
                                    <th scope=""col"">Redaktə et</th>
                                </tr>
                            </thead>
                            <tbody class=""table-hover"">
");
            EndContext();
#line 33 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                 if (Model.Companies.Count() != 0)
                                {
                                    int count = 1;
                                    

#line default
#line hidden
#line 36 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                     foreach (var item in Model.AppUsers.Where(a => a.Status != false))
                                    {

#line default
#line hidden
            BeginContext(1808, 105, true);
            WriteLiteral("                                        <tr>\n                                            <th scope=\"row\">");
            EndContext();
            BeginContext(1914, 5, false);
#line 39 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 103, true);
            WriteLiteral("</th>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(2022, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b6ce3a423d64e70becaeaf4bd58d2b2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2032, "~/allUserImg/", 2032, 13, true);
#line 41 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
AddHtmlAttributeValue("", 2045, item.Image, 2045, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2080, 99, true);
            WriteLiteral("\n                                            </td>\n                                            <td>");
            EndContext();
            BeginContext(2180, 19, false);
#line 43 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.Companies.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2199, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2254, 9, false);
#line 44 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2318, 12, false);
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2330, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2385, 15, false);
#line 46 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(2400, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2455, 16, false);
#line 47 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2471, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2526, 13, false);
#line 48 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2539, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2594, 10, false);
#line 49 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2604, 172, true);
            WriteLiteral("</td>\n                                            <th class=\"text-white\">\n                                                <div class=\"d-flex w-100 justify-content-center\">\n");
            EndContext();
            BeginContext(2948, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3000, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3940c460a0b48bca0ab49df4c1659cb", async() => {
                BeginContext(3111, 29, true);
                WriteLiteral(" <i class=\"fas fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3144, 152, true);
            WriteLiteral("\n                                                </div>\n                                            </th>\n                                        </tr>\n");
            EndContext();
#line 57 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#line 58 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3488, 602, true);
            WriteLiteral(@"                                    <tr class=""text-danger text-center"">
                                        <th scope=""row"">0</th>
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
#line 73 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\Adminn\AllAdminList.cshtml"
                                }

#line default
#line hidden
            BeginContext(4124, 193, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n            <div class=\"card-footer\">\n                ");
            EndContext();
            BeginContext(4317, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1862230988164d40a8a349459f7879bb", async() => {
                BeginContext(4414, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4422, 53, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
