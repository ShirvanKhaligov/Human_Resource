#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2151ca6ab50d1955245d23f1cf72cdaf92f51ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Reaward_Detail), @"mvc.1.0.view", @"/Areas/Employee/Views/Reaward/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Reaward/Detail.cshtml", typeof(AspNetCore.Areas_Employee_Views_Reaward_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2151ca6ab50d1955245d23f1cf72cdaf92f51ea1", @"/Areas/Employee/Views/Reaward/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Reaward_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RewardCommandVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/pdf.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AdobePdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reaward", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeReawrd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 5px 60px;color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(62, 655, true);
            WriteLiteral(@"
<h2>Detail</h2>



<div class=""content-wrapper"" style=""color: black; background-color: rgb(255, 255, 255);"">
    <div class=""container-fluid"">

        <div style=""height: 30px""></div>
        <div class=""row"">
            <div class=""col-md-9"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"">İşçinin adı:</label>
                            </div>
                            <div class=""col-sm-8"">
                                <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 717, "\"", 760, 1);
#line 23 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
WriteAttributeValue("", 725, Model.RewardToEmployee.EmplooyeeId, 725, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(761, 73, true);
            WriteLiteral(" id=\"detailEmpName\" />\n                                <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 834, "\"", 1047, 2);
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
WriteAttributeValue("", 842, Model.RewardToEmployee.Emplooyee.FirstName+" "+Model.RewardToEmployee.Emplooyee.Lastname+" "+Model.RewardToEmployee.Emplooyee.FatherName, 842, 139, false);

#line default
#line hidden
#line 24 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
WriteAttributeValue(" ", 981, Model.RewardToEmployee.Emplooyee.GenderId==1 ? "oğlu" : "qızı", 982, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1048, 898, true);
            WriteLiteral(@" class=""form-control input-height"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"">Sənədin adı</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" value=""Mükafat"" class=""form-control input-height"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"">Qəbul vaxtı</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1946, "\"", 2003, 1);
#line 40 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
WriteAttributeValue("", 1954, Model.RewardToEmployee.CreatedDate.ToString("D"), 1954, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2004, 566, true);
            WriteLiteral(@" class=""form-control input-height"" readonly />
                            </div>
                        </div>

                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"">Əmrin skan for.</label>
                            </div>
                            <div class=""col-md-8"">
                                <div class=""col-md-2"">
                                    <div class=""row"" style=""width:175px;"">
                                        ");
            EndContext();
            BeginContext(2570, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ddb3429a65784e399704e32a77ee28b5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(2635, 1356, true);
            WriteLiteral(@"
                                        <div id=""RewardScanisShowing"" style=""margin-top: 10px;""></div>
                                        <!--Partial view scan-->
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"" for=""workType"">İş vaxtı növü:</label>
                            </div>
                            <div class=""col-sm-8"">
                                <input type=""text"" value=""Little"" class=""form-control input-height"" readonly />
                            </div>
                        </div>

                        <div class=""form-group row ml-md-2"">
                            <div class=""col-md-4"">
                                <label style=""color:black;"" for=""workType"">İşin növü:</label>
                         ");
            WriteLiteral(@"   </div>
                            <div class=""col-sm-8"">

                            </div>
                        </div>


                    </div>

                </div>


                <br>
                <div class=""row ml-md-3"">
                    <button class=""btn btn-primary col-md-2"">
                        ");
            EndContext();
            BeginContext(3991, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ba06757adbe4406a5520f3aa37f8fc5", async() => {
                BeginContext(4106, 4, true);
                WriteLiteral("Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
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
            BeginContext(4114, 108, true);
            WriteLiteral("\n                    </button>\n                </div>\n\n            </div>\n        </div>\n\n    </div>\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4239, 193, true);
                WriteLiteral("\n    <script>\n        function getEmpScan() {\n            var emplName = document.getElementById(\"detailEmpName\").value;\n            $.ajax({\n                type: \"get\",\n                url: \"");
                EndContext();
                BeginContext(4433, 38, false);
#line 101 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Reaward\Detail.cshtml"
                 Write(Url.Action("GetRewardScan", "Reaward"));

#line default
#line hidden
                EndContext();
                BeginContext(4471, 342, true);
                WriteLiteral(@""",
                data: {
                    employeeId: emplName
                },
                success: function (respoonse) {
                    $(""#RewardScanisShowing"").html(respoonse)
                },
                error: function (respoonse) {
                }
            })
        };
        getEmpScan();
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RewardCommandVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
