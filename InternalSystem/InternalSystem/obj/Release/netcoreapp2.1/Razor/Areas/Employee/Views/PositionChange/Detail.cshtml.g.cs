#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34bb2381935202bcd146b26b233ca843de74644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_PositionChange_Detail), @"mvc.1.0.view", @"/Areas/Employee/Views/PositionChange/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/PositionChange/Detail.cshtml", typeof(AspNetCore.Areas_Employee_Views_PositionChange_Detail))]
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Employee.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 5 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 6 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34bb2381935202bcd146b26b233ca843de74644", @"/Areas/Employee/Views/PositionChange/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_PositionChange_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommandEmpPositionChVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PositionChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 5px 60px;color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(73, 286, true);
            WriteLiteral(@"
<div class=""content-wrapper mb-3"" style=""color: black; background-color: rgb(255, 255, 255);"">
    <div class=""container-fluid"">
        <div style=""height: 30px""></div>
        <div class=""row ml-md-3 mb-4"">
            <button class=""btn btn-primary col-md-2"">
                ");
            EndContext();
            BeginContext(359, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba81748222b54d60b3d58baeb7d5353e", async() => {
                BeginContext(453, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 585, true);
            WriteLiteral(@"
            </button>
        </div>
        <div class=""row"">
            <div class=""col-md-7"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"" style=""color:black;"">İşçinin adı:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(1048, 142, false);
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                Write(Model.CommandsToEmployee.Emplooyee.FirstName+" "+Model.CommandsToEmployee.Emplooyee.Lastname+" "+Model.CommandsToEmployee.Emplooyee.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(1191, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1194, 64, false);
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                                                                                                                                                                  Write(Model.CommandsToEmployee.Emplooyee.GenderId==1 ? "oğlu" : "qızı");

#line default
#line hidden
            EndContext();
            BeginContext(1259, 994, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>

                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Sənədin adı</label>
                            </div>
                            <div class=""col-md-9"">
                                <p class=""detailEmpRecruit"">
                                    Vəzifə dəyişikliyi
                                </p>
                            </div>
                        </div>
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Qəbul vaxtı</label>
                            </div>
                            <div class=""col-md-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(2254, 50, false);
#line 45 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.CreatedDate.ToString("D"));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 490, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">İş vaxtı növü:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(2795, 54, false);
#line 55 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.Emplooyee.WorkTimeOfType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2849, 488, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>

                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">İşin növü:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(3338, 57, false);
#line 66 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.Emplooyee.WorkPlaceAddition.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3395, 490, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>

                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Şöbənin adı:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(3886, 94, false);
#line 77 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.Emplooyee.Positions.SubDepartment.DepartmentToCompany.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3980, 492, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Alt şöbənin adı:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(4473, 63, false);
#line 87 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.Emplooyee.Positions.SubDepartment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4536, 490, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Vəzifənin adı:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(5027, 49, false);
#line 97 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                               Write(Model.CommandsToEmployee.Emplooyee.Positions.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5076, 481, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=""row ml-md-2"">
                            <div class=""col-md-3"">
                                <label class=""detailEmpRecruitLabel"">Maaş:</label>
                            </div>
                            <div class=""col-sm-9"">
                                <p class=""detailEmpRecruit"">
                                    ");
            EndContext();
            BeginContext(5559, 47, false);
#line 107 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                Write(Model.CommandsToEmployee.Emplooyee.Salary+ " ₼");

#line default
#line hidden
            EndContext();
            BeginContext(5607, 304, true);
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-5"">
                <div style=""text-align:end;margin-right:15px"">
                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5911, "\"", 5970, 2);
            WriteAttributeValue("", 5917, "/allUserImg/", 5917, 12, true);
#line 116 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
WriteAttributeValue("", 5929, Model.CommandsToEmployee.Emplooyee.Image, 5929, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5971, 35, true);
            WriteLiteral(" style=\"width:166px; height:250px;\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 6006, "\"", 6107, 1);
#line 116 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
WriteAttributeValue("", 6012, Model.CommandsToEmployee.Emplooyee.FirstName+" "+Model.CommandsToEmployee.Emplooyee.Lastname, 6012, 95, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6108, 317, true);
            WriteLiteral(@" />
                </div>
                <div>
                    <div class=""form-group mt-3"">
                        <div class=""col-md-6"">
                            <label style=""color:black;"">Əmrin skan forması:</label>
                        </div>
                        <div class=""col-md-12"">
");
            EndContext();
#line 124 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                             if (Model.ScanPdfCommands != null)
                            {
                                

#line default
#line hidden
#line 126 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                 if (Model.ScanPdfCommands.Pdf != null)
                                {

#line default
#line hidden
            BeginContext(6629, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(6665, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("embed", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a9537bd03c74a618143f3fb62062fb3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6677, "~/allUserImg/", 6677, 13, true);
#line 128 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
AddHtmlAttributeValue("", 6690, Model.ScanPdfCommands.Pdf, 6690, 26, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6752, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 129 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(6862, 104, true);
            WriteLiteral("                                    <p style=\"font-size:20px;margin-top:15px;display:grid;\">Yoxdur</p>\r\n");
            EndContext();
#line 133 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                }

#line default
#line hidden
#line 133 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7097, 100, true);
            WriteLiteral("                                <p style=\"font-size:20px;margin-top:15px;display:grid;\">Yoxdur</p>\r\n");
            EndContext();
#line 138 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\PositionChange\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(7228, 148, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommandEmpPositionChVM> Html { get; private set; }
    }
}
#pragma warning restore 1591