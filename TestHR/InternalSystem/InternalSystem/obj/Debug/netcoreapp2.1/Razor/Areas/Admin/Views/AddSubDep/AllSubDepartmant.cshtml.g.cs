#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0fd910abe0f773a1ee001804f249ce539810b95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AddSubDep_AllSubDepartmant), @"mvc.1.0.view", @"/Areas/Admin/Views/AddSubDep/AllSubDepartmant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AddSubDep/AllSubDepartmant.cshtml", typeof(AspNetCore.Areas_Admin_Views_AddSubDep_AllSubDepartmant))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fd910abe0f773a1ee001804f249ce539810b95", @"/Areas/Admin/Views/AddSubDep/AllSubDepartmant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff8064f2271ac85688048f91c7ba961808c54d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AddSubDep_AllSubDepartmant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeptAndSubDeptVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyiş"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddSubDep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
  
    ViewData["Title"] = "AllSubDepartmant";

#line default
#line hidden
            BeginContext(74, 2436, true);
            WriteLiteral(@"
<div class=""content-wrapper"" style=""padding:0px 0px 0px 250px"">
    <div class=""container-fluid"">
        <br>
        <div class=""card"">
            <div class=""row"">
                <div class=""modal"" tabindex=""-1"" id=""confirmationSubDepModalForAll"" role=""dialog"">
                    <input type=""hidden"" id=""hiddenModal"" name=""name"" value="""" />
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 style=""color:black;font-size:1rem;"" class=""modal-title"">Məlumatı sil</h5>
                                <button type=""button"" onclick=""closeConfirmationIdSubDepartmentForAll()"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"" style=""padding-bottom: 0;"">
 ");
            WriteLiteral(@"                               <p style=""color:#2590d3 !important;;font-size: 1.3rem;"">Məlumatı silməyə əminsinizmi?</p>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" onclick=""modalSubDepartmentDelete($('#hiddenModal').val())"" class=""btn btn-secondary"" data-dismiss=""modal"">Bəli</button>
                                <button type=""button"" onclick=""closeConfirmationIdSubDepartmentForAll()"" id=""confirmationSubDepModalForAll"" class=""btn btn-primary"">Xeyr</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 mx-auto"" id=""SubDepartmentTableDiv"">
                    <table style=""color:blue"" class=""table table-hover table-responsive-md "">
                        <thead style=""text-align: center"" class=""thead-dark "">
                            <tr>
                                <th scope=""col"">Sıra №</th>
   ");
            WriteLiteral(@"                             <th scope=""col"">Alt şöbənin adı</th>
                                <th scope=""col"">Şöbənin adı</th>
                                <th scope=""col"">Şirkətin adı</th>
                                <th scope=""col"">Redaktə et:</th>
                            </tr>
                        </thead>
                        <tbody style=""text-align: center"">
");
            EndContext();
#line 44 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                               var count = 1; 

#line default
#line hidden
            BeginContext(2558, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                             if (Model.SubDepartments.Count() != 0)
                            {
                                

#line default
#line hidden
#line 47 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                 foreach (var item in Model.SubDepartments)
                                {

#line default
#line hidden
            BeginContext(2766, 97, true);
            WriteLiteral("                                    <tr>\n                                        <th scope=\"row\">");
            EndContext();
            BeginContext(2864, 5, false);
#line 50 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2869, 51, true);
            WriteLiteral("</th>\n                                        <td>\n");
            EndContext();
#line 52 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                             if (item.Name.Length > 50)
                                            {

#line default
#line hidden
            BeginContext(3039, 34, false);
#line 53 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                         Write(item.Name.Substring(0, 50) + "...");

#line default
#line hidden
            EndContext();
#line 53 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                                                                   }
                                            else
                                            {
                                                

#line default
#line hidden
            BeginContext(3221, 9, false);
#line 56 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
#line 56 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                                          }

#line default
#line hidden
            BeginContext(3232, 90, true);
            WriteLiteral("                                        </td>\n                                        <td>");
            EndContext();
            BeginContext(3323, 40, false);
#line 58 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                       Write(item.DepartmentToCompany.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3363, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(3414, 37, false);
#line 59 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                       Write(item.DepartmentToCompany.Company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3451, 95, true);
            WriteLiteral("</td>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(3546, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b40763dc77b48f682e0732e54d4bf1b", async() => {
                BeginContext(3629, 28, true);
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
#line 61 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
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
            BeginContext(3661, 47, true);
            WriteLiteral("\n                                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3708, "\"", 3761, 3);
            WriteAttributeValue("", 3718, "confirmationIdSubDepartmentForAll(", 3718, 34, true);
#line 62 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
WriteAttributeValue("", 3752, item.Id, 3752, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3760, ")", 3760, 1, true);
            EndWriteAttribute();
            BeginContext(3762, 158, true);
            WriteLiteral(" class=\"btn btn-danger\" title=\"Sil\"> <i class=\"fas fa-trash\"></i></a>\n                                        </td>\n                                    </tr>\n");
            EndContext();
#line 65 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                    count++;
                                }

#line default
#line hidden
#line 66 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                                  }
                            else
                            {

#line default
#line hidden
            BeginContext(4064, 370, true);
            WriteLiteral(@"                                <tr>
                                    <th scope=""row"">0</th>
                                    <td>Siyahı boşdur</td>
                                    <td>Siyahı boşdur</td>
                                    <td>Siyahı boşdur</td>
                                    <td>Siyahı boşdur</td>
                                </tr>
");
            EndContext();
#line 76 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                            }

#line default
#line hidden
            BeginContext(4464, 159, true);
            WriteLiteral("\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n            <div class=\"card-footer\">\n                ");
            EndContext();
            BeginContext(4623, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "684881d1f53b4c619f67fe8999f79960", async() => {
                BeginContext(4723, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            BeginContext(4731, 55, true);
            WriteLiteral("\n\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4803, 135, true);
                WriteLiteral("\n    <script>\n\n        function modalSubDepartmentDelete(id) {\n            $.ajax({\n                type: \"post\",\n                url:\"");
                EndContext();
                BeginContext(4939, 32, false);
#line 96 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Admin\Views\AddSubDep\AllSubDepartmant.cshtml"
                Write(Url.Action("Delete","AddSubDep"));

#line default
#line hidden
                EndContext();
                BeginContext(4971, 660, true);
                WriteLiteral(@""",
                data: { SubDepartmentId:id},
                success: function (res) {
                    $(""#confirmationSubDepModalForAll"").hide();
                    $(""#SubDepartmentTableDiv"").html(res);
                },
                error: function (res) {
                    console.error(res)
                }
            });
        }

        function confirmationIdSubDepartmentForAll(id) {
            $(""#confirmationSubDepModalForAll"").show();
            $(""#hiddenModal"").val(id)
        };

        function closeConfirmationIdSubDepartmentForAll() {
            $(""#confirmationSubDepModalForAll"").hide();
        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(5633, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeptAndSubDeptVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
