#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d06384fa36b48b6c499c9a3fda2894efe1a4fc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddProfession_AllProfessions), @"mvc.1.0.view", @"/Areas/Admin/Views/AddProfession/AllProfessions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddProfession/AllProfessions.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddProfession_AllProfessions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d06384fa36b48b6c499c9a3fda2894efe1a4fc6", @"/Areas/Admin/Views/AddProfession/AllProfessions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddProfession_AllProfessions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Profession>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
  
    ViewData["Title"] = "AllProfessions";

#line default
#line hidden
            BeginContext(78, 942, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"" id=""professionTableDiv"">
                        <table class=""table table-hover table-responsive-md "">
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
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                   var count = 1;

#line default
#line hidden
            BeginContext(1071, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 25 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1166, 97, true);
            WriteLiteral("                                    <tr>\n                                        <th scope=\"row\">");
            EndContext();
            BeginContext(1264, 5, false);
#line 28 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 50, true);
            WriteLiteral("</th>\n                                        <td>");
            EndContext();
            BeginContext(1320, 9, false);
#line 29 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(1380, 20, false);
#line 30 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                       Write(item.UniFaculty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1400, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(1451, 59, false);
#line 31 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                       Write(item.UniFaculty.EducationTypeToUniversity.Universities.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1513, 60, false);
#line 31 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                                                                                     Write(item.UniFaculty.EducationTypeToUniversity.EducationType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1573, 96, true);
            WriteLiteral(")</td>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(1669, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b76feb30fa942bb936f048c53b69bc3", async() => {
                BeginContext(1790, 28, true);
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
#line 33 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
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
            BeginContext(1822, 47, true);
            WriteLiteral("\n                                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1869, "\"", 1920, 3);
            WriteAttributeValue("", 1879, "confirmationDeleteForProfession(", 1879, 32, true);
#line 34 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
WriteAttributeValue("", 1911, item.Id, 1911, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1919, ")", 1919, 1, true);
            EndWriteAttribute();
            BeginContext(1921, 167, true);
            WriteLiteral(" href=\"#\" class=\"btn btn-danger\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                                        </td>\n                                    </tr>\n");
            EndContext();
#line 37 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                                    count++;
                                }

#line default
#line hidden
            BeginContext(2167, 193, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n            <div class=\"card-footer\">\n                ");
            EndContext();
            BeginContext(2360, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9adc24e9cb2b4eb8ade66d3976b32cec", async() => {
                BeginContext(2466, 4, true);
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
            BeginContext(2474, 1099, true);
            WriteLiteral(@"
            </div>
        </div>

    </div>

    <!--content-wrapper-->
</div>
<section class=""modalClass"">

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""confirmationModalForProfession"">
        <input type=""hidden"" id=""hiddenProfessionId"" value="""" />
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title text-danger"">Silməyə əminsiniz?</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeConfirmationForProfession()"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <a onclick=""deleteProfessiion($('#hiddenProfessionId').val())"" class=""btn btn-primary"">Sil</a>
                    <a onclick=""closeConfirmationForProfession()"" class=""btn btn-secondary"" data-dismiss=""modal"">Ləvğ et</a>
     ");
            WriteLiteral("           </div>\n            </div>\n        </div>\n    </div>\n</section>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3590, 137, true);
                WriteLiteral("\n    <script>\n        function deleteProfessiion(Id) {\n               $.ajax({\n                   type: \'post\',\n                   url: \'");
                EndContext();
                BeginContext(3728, 44, false);
#line 79 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Admin\Views\AddProfession\AllProfessions.cshtml"
                    Write(Url.Action("DeleteProfession", "Profession"));

#line default
#line hidden
                EndContext();
                BeginContext(3772, 798, true);
                WriteLiteral(@"',
                   data: { ProfessionId: Id},
                   success: function (response) {
                       console.log(""success"")
                       $(""#confirmationModalForProfession"").hide()
                       $(""#professionTableDiv"").html(response)
                   },
                   error: function (response) {
                       console.error(response)
                   }
               })
        }

        //////////////open modul
        function confirmationDeleteForProfession(Id) {
            $(""#confirmationModalForProfession"").show()
            $(""#hiddenProfessionId"").val(Id)
        }
        //close modul//
        function closeConfirmationForProfession() {
            $(""#confirmationModalForProfession"").hide()
        }
    </script>

");
                EndContext();
            }
            );
            BeginContext(4572, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Profession>> Html { get; private set; }
    }
}
#pragma warning restore 1591
