#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6603027c24ecab27943558236c9805eb6805b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddUni_AllUniversities), @"mvc.1.0.view", @"/Areas/Admin/Views/AddUni/AllUniversities.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddUni/AllUniversities.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddUni_AllUniversities))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6603027c24ecab27943558236c9805eb6805b8", @"/Areas/Admin/Views/AddUni/AllUniversities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddUni_AllUniversities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EducationTypeToUnivercity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUniversity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddUni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
  
    ViewData["Title"] = "AllUniversities";

#line default
#line hidden
            BeginContext(94, 847, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""min-height: 329px; padding:0px 0px 0px 250px"">

    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""row"">
                <div class=""col-md-12 mx-auto"" id=""tableDiv"">
                    <table style=""color:blue"" class=""table table-hover table-responsive-md "">
                        <thead style=""text-align: center"" class=""thead-dark "">
                            <tr>
                                <th scope=""col"">Sıra №</th>
                                <th scope=""col"">Universitetiin adı</th>
                                <th scope=""col"">Təhsilin növü</th>
                                <th scope=""col"">Redaktə et:</th>
                            </tr>
                        </thead>
                        <tbody style=""text-align: center"">
");
            EndContext();
#line 23 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                               int count = 1; 

#line default
#line hidden
            BeginContext(989, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                             if (Model.Count() != 0)
                            {

                                

#line default
#line hidden
#line 27 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1168, 97, true);
            WriteLiteral("                                    <tr>\n                                        <th scope=\"row\">");
            EndContext();
            BeginContext(1266, 5, false);
#line 30 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 50, true);
            WriteLiteral("</th>\n                                        <td>");
            EndContext();
            BeginContext(1322, 22, false);
#line 31 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                       Write(item.Universities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(1395, 23, false);
#line 32 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                       Write(item.EducationType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 95, true);
            WriteLiteral("</td>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(1513, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f66cefcd96c04b9bb87597540c1fe899", async() => {
                BeginContext(1643, 28, true);
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
#line 34 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                                                                                     WriteLiteral(item.Universities.Id);

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
            BeginContext(1675, 47, true);
            WriteLiteral("\n                                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1722, "\"", 1775, 3);
            WriteAttributeValue("", 1732, "confirmationIdForAll(", 1732, 21, true);
#line 35 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
WriteAttributeValue("", 1753, item.Universities.Id, 1753, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1774, ")", 1774, 1, true);
            EndWriteAttribute();
            BeginContext(1776, 167, true);
            WriteLiteral(" class=\"btn btn-danger\" title=\"Sil\" href=\"#\"> <i class=\"fas fa-trash\"></i></a>\n                                        </td>\n                                    </tr>\n");
            EndContext();
#line 38 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                    count++;
                                }

#line default
#line hidden
#line 39 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                                 }

#line default
#line hidden
            BeginContext(2023, 159, true);
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n            <div class=\"card-footer\">\n\n                ");
            EndContext();
            BeginContext(2182, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a1f9a400634b6b8c694dfc91444f19", async() => {
                BeginContext(2279, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2287, 1094, true);
            WriteLiteral(@"

            </div>
        </div>
    </div>

    <!--content-wrapper-->
</div>
<section class=""modaDiv"">
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""confirmationModalForAll"">
        <input type=""hidden"" id=""hiddenUniversityIdInAll"" value="""" />
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title text-danger"">Silməyə əminsiniz?</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeConfirmationIdForAll()"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <a onclick=""deleteUniversityInAllUn($('#hiddenUniversityIdInAll').val())"" class=""btn btn-primary"">Sil</a>
                    <a onclick=""closeConfirmationIdForAll()"" class=""btn btn-secondary"" data-dismiss=""modal"">Ləvğ et</a>
          ");
            WriteLiteral("      </div>\n            </div>\n        </div>\n    </div>\n\n</section>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3398, 172, true);
                WriteLiteral("\n    <script>\n                    /////////////////\n        function deleteUniversityInAllUn(Id) {\n            $.ajax({\n                type: \'post\',\n                url: \'");
                EndContext();
                BeginContext(3571, 39, false);
#line 80 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddUni\AllUniversities.cshtml"
                 Write(Url.Action("DeleteFromAllUn", "AddUni"));

#line default
#line hidden
                EndContext();
                BeginContext(3610, 727, true);
                WriteLiteral(@"',
                data: { UniversityId: Id },
                success: function (response) {
                    $(""#tableDiv"").html(response)
                    $(""#confirmationModalForAll"").hide()
                },
                error: function (response) {
                    console.error(response)
                }
            })
        }
        //////////////
        //////////////open modul
        function confirmationIdForAll(Id) {
            $(""#confirmationModalForAll"").show()
            $(""#hiddenUniversityIdInAll"").val(Id)
        }
        //close modul//
        function closeConfirmationIdForAll() {
            $(""#confirmationModalForAll"").hide()
        }
        /////////////
    </script>
");
                EndContext();
            }
            );
            BeginContext(4338, 3, true);
            WriteLiteral(">\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EducationTypeToUnivercity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
