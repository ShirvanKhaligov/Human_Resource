#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01647a3738afccf8ce83e2c0487532e54990d542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CompanyAdmin_Views_Hr_Index), @"mvc.1.0.view", @"/Areas/CompanyAdmin/Views/Hr/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/CompanyAdmin/Views/Hr/Index.cshtml", typeof(AspNetCore.Areas_CompanyAdmin_Views_Hr_Index))]
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.CompanyAdmin.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01647a3738afccf8ce83e2c0487532e54990d542", @"/Areas/CompanyAdmin/Views/Hr/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b7b6000a88a44b2352f10dee93856618059514", @"/Areas/CompanyAdmin/Views/_ViewImports.cshtml")]
    public class Areas_CompanyAdmin_Views_Hr_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "CompanyAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(66, 1415, true);
            WriteLiteral(@"
<div style=""background-color: white"" class=""page-wrapper"">

    <div class=""container-fluid"">

        <div class=""card"">
            <div class=""card-header"">
                <p style=""color: green;text-align: center;font-size: 25px"">Hr siyahısı</p>
            </div>
            <div class=""card-body"" style=""overflow-x:scroll"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <table style=""width:1500px"" class=""table table-bordered table-responsive-md text-center"">
                            <thead class="" table-dark"">
                                <tr>
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Şəkil</th>
                                    <th scope=""col"">Adminin adı</th>
                                    <th scope=""col"">Soyadı</th>
                                    <th scope=""col"">Atasının adı</th>
                                    <th scope=""col"">Tel nömrəsi</th>
       ");
            WriteLiteral(@"                             <th scope=""col"">İstifadəçi adı</th>
                                    <th scope=""col"">Poçt ünvanı</th>
                                    <th scope=""col"">Təstiqlənib</th>
                                    <th scope=""col"">Redaktə et</th>
                                </tr>
                            </thead>
                            <tbody class="""">
");
            EndContext();
#line 33 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    int count = 1;
                                    

#line default
#line hidden
#line 36 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        if (item.CompaniesId == ViewBag.userAdmin && item.Status != false)
                                        {

#line default
#line hidden
            BeginContext(1875, 113, true);
            WriteLiteral("                                            <tr>\n                                                <th scope=\"row\">");
            EndContext();
            BeginContext(1989, 5, false);
#line 41 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 59, true);
            WriteLiteral("</th>\n                                                <th>\n");
            EndContext();
#line 43 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                     if (item.Image != null)
                                                    {

#line default
#line hidden
            BeginContext(2184, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(2240, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3d6af9dc9ff4cffa1cbce7a78cb4ab0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2250, "~/allUserImg/", 2250, 13, true);
#line 45 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
AddHtmlAttributeValue("", 2263, item.Image, 2263, 11, false);

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
            BeginContext(2298, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 46 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(2353, 106, true);
            WriteLiteral("                                                </th>\n                                                <th>");
            EndContext();
            BeginContext(2460, 9, false);
#line 48 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 58, true);
            WriteLiteral("</th>\n                                                <td>");
            EndContext();
            BeginContext(2528, 12, false);
#line 49 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(2540, 58, true);
            WriteLiteral("</td>\n                                                <td>");
            EndContext();
            BeginContext(2599, 15, false);
#line 50 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(2614, 58, true);
            WriteLiteral("</td>\n                                                <td>");
            EndContext();
            BeginContext(2673, 16, false);
#line 51 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2689, 58, true);
            WriteLiteral("</td>\n                                                <td>");
            EndContext();
            BeginContext(2748, 13, false);
#line 52 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2761, 58, true);
            WriteLiteral("</td>\n                                                <td>");
            EndContext();
            BeginContext(2820, 10, false);
#line 53 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2830, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 54 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                 if (item.Emplooyee != null)
                                                {
                                                    if (item.Emplooyee.IsWorking == false)
                                                    {

#line default
#line hidden
            BeginContext(3108, 60, true);
            WriteLiteral("                                                        <td>");
            EndContext();
            BeginContext(3168, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6df448e0c0e24d9f90b58da3befd1965", async() => {
                BeginContext(3283, 8, true);
                WriteLiteral("Təstiqlə");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3295, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 59 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                    }

                                                }

#line default
#line hidden
            BeginContext(3406, 229, true);
            WriteLiteral("                                                <td><a style=\"cursor:pointer;\" class=\"btn btn-success\">Təsdiqlənib</a></td>\n                                                <td>\n                                                    ");
            EndContext();
            BeginContext(3635, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39df3159139a479ca6afe7cb4ac52a6c", async() => {
                BeginContext(3761, 29, true);
                WriteLiteral(" <i class=\"fas fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3794, 105, true);
            WriteLiteral("\n                                                </td>\n                                            </tr>\n");
            EndContext();
#line 67 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                            count++;
                                        }
                                        

#line default
#line hidden
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                               
                                    }

#line default
#line hidden
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                     

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5078, 655, true);
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
                                        <th>Boş</th>
                                    </tr>
");
            EndContext();
#line 101 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5767, 1157, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""modaDiv"">
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""confirmationModalForHR"">
        <input type=""hidden"" id=""hiddenHrId"" value="""" />
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title text-danger"">Silməyə əminsiniz?</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeConfirmationIdForAll()"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <a onclick=""deleteUniversityInAllUn($('#hiddenHrId').val())"" class=""btn btn-primary"">Sil</a>
                    <a onclick=""closeConfirmationIdForAll()"" class");
            WriteLiteral("=\"btn btn-secondary\" data-dismiss=\"modal\">Ləvğ et</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6941, 172, true);
                WriteLiteral("\n    <script>\n                    /////////////////\n        function deleteUniversityInAllUn(Id) {\n            $.ajax({\n                type: \'post\',\n                url: \'");
                EndContext();
                BeginContext(7114, 43, false);
#line 136 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\CompanyAdmin\Views\Hr\Index.cshtml"
                 Write(Url.Action("DeleteFromAllUn", "University"));

#line default
#line hidden
                EndContext();
                BeginContext(7157, 710, true);
                WriteLiteral(@"',
                data: { UniversityId: Id },
                success: function (response) {
                    $(""#tableDiv"").html(response)
                    $(""#confirmationModalForHR"").hide()
                },
                error: function (response) {
                    console.error(response)
                }
            })
        }
        //////////////
        //////////////open modul
        function confirmationIdForHR(Id) {
            $(""#confirmationModalForHR"").show()
            $(""#hiddenHrId"").val(Id)
        }
        //close modul//
        function closeConfirmationIdForAll() {
            $(""#confirmationModalForHR"").hide()
        }
        /////////////
    </script>
");
                EndContext();
            }
            );
            BeginContext(7869, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591