#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d63dc1b8f1b50467bbe56705e5765da33096db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_EmployeeDevice_Create), @"mvc.1.0.view", @"/Areas/InternalHR/Views/EmployeeDevice/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/EmployeeDevice/Create.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_EmployeeDevice_Create))]
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
#line 1 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 4 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 5 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 6 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 7 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d63dc1b8f1b50467bbe56705e5765da33096db", @"/Areas/InternalHR/Views/EmployeeDevice/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_EmployeeDevice_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDeviceVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeDevice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(63, 616, true);
            WriteLiteral(@"<style>


    .btn-success {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-primary {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-warning {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }

    .btn-danger {
        background-color: #2590d3 !important;
        border-color: #2590d3 !important;
    }
</style>
<div class=""content-wrapper"" style=""color:black; background-color: #fff;"">
    <div class=""container-fluid"">
        <br>
        <br>
        ");
            EndContext();
            BeginContext(679, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf80d4565474cca99647f2a05525750", async() => {
                BeginContext(789, 48, true);
                WriteLiteral("<i class=\"fas fa-long-arrow-alt-left\"></i>  Geri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(841, 58, true);
            WriteLiteral("\n        <div class=\" \">\n            <br><br>\n            ");
            EndContext();
            BeginContext(899, 6785, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e0b088916914e718fb5fc7cc2685237", async() => {
                BeginContext(919, 931, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""row"">
                            <div class=""col-7"">
                                <div class=""form-group"">
                                    <div class=""col-12"">
                                        <div class=""row"" style="" justify-content: center;"">
                                            <div class=""col-2"" style="" text-align: end;"">
                                                <label style=""color:black"" for=""employe"">İşçilər:</label>
                                            </div>
                                            <div class=""col-8"">
                                                <select style=""padding: 0px"" class=""form-control input-height""
                                                        id=""employe"" name=""employe"">
                                                    ");
                EndContext();
                BeginContext(1850, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6191e2d3a8774158a3831594ecf4e54f", async() => {
                    BeginContext(1876, 5, true);
                    WriteLiteral("Seçin");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1890, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 50 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                     foreach (var emp in Model.Emplooyees)
                                                    {

#line default
#line hidden
                BeginContext(2036, 56, true);
                WriteLiteral("                                                        ");
                EndContext();
                BeginContext(2092, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9858cbcd29042d8bd8abb48bdcd7fb2", async() => {
                    BeginContext(2118, 74, false);
#line 52 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                                            Write(emp.FirstName+" "+emp.Lastname+" "+emp.FatherName+" Ş/V("+(emp.IdCard)+")");

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 52 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                           WriteLiteral(emp.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2202, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 53 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(2257, 58, true);
                WriteLiteral("                                                </select>\n");
                EndContext();
#line 55 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                 if (ViewData["error_empId"] != null)
                                                {

#line default
#line hidden
                BeginContext(2451, 78, true);
                WriteLiteral("                                                    <span class=\"text-danger\">");
                EndContext();
                BeginContext(2530, 23, false);
#line 57 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                                         Write(ViewData["error_empId"]);

#line default
#line hidden
                EndContext();
                BeginContext(2553, 8, true);
                WriteLiteral("</span>\n");
                EndContext();
#line 58 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                }

#line default
#line hidden
                BeginContext(2611, 1030, true);
                WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class=""col-5"">
                                <div class=""form-group"">
                                    <div class=""col-12"">
                                        <div class=""row"" style="" justify-content: center;"">
                                            <div class=""col-2"" style="" text-align: end;"">
                                                <label style=""color:black"" for=""devType"">Qurğular:</label>
                                            </div>
                                            <div class=""col-8"">
                                                <select style=""padding: 0px"" class=""form-control input-height""
                                                        id=""devType"" name=""devType"">
                                              ");
                WriteLiteral("      ");
                EndContext();
                BeginContext(3641, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffddf8b71a2446db8b2da9cd5f5ca94", async() => {
                    BeginContext(3667, 5, true);
                    WriteLiteral("Seçin");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3681, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 76 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                     foreach (var devtype in Model.DevicesTypes)
                                                    {

#line default
#line hidden
                BeginContext(3833, 56, true);
                WriteLiteral("                                                        ");
                EndContext();
                BeginContext(3889, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12be6cde17ce4fbcac4f40b62e53fee8", async() => {
                    BeginContext(3918, 12, false);
#line 78 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                                               Write(devtype.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 78 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                           WriteLiteral(devtype.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3939, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 79 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(3994, 58, true);
                WriteLiteral("                                                </select>\n");
                EndContext();
#line 81 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                 if (ViewData["error_devId"] != null)
                                                {

#line default
#line hidden
                BeginContext(4188, 78, true);
                WriteLiteral("                                                    <span class=\"text-danger\">");
                EndContext();
                BeginContext(4267, 23, false);
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                                         Write(ViewData["error_devId"]);

#line default
#line hidden
                EndContext();
                BeginContext(4290, 8, true);
                WriteLiteral("</span>\n");
                EndContext();
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                }

#line default
#line hidden
                BeginContext(4348, 914, true);
                WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>

                </div>
                <div class=""row mt-4"">
                    <div class=""col-12"">
                        <div class=""row"">
                            <div class=""col-7"">
                                <div class=""form-group"">
                                    <div class=""col-12"">
                                        <div class=""row"" style="" justify-content: center;"">
                                            <div class=""col-2"" style=""text-align: end;"">
                                                <label style=""color:black;"">Qurğunun kodu:</label>
                                            </div>
");
                EndContext();
                BeginContext(5958, 863, true);
                WriteLiteral(@"                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class=""col-5"">
                                <div class=""form-group"">
                                    <div class=""col-12"">
                                        <div class=""row"" style="" justify-content: center;"">
                                            <div class=""col-2"" style="" text-align: end;"">
                                                <label style=""color:black"" name=""GivingTime"">Verilmə tarixi:</label>
                                            </div>
                                            <div class=""col-8"">
                                                <input type=""date"" class=""form-control input-height"" name=""GivingTime"" />
");
                EndContext();
#line 128 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                 if (ViewData["error_date"] != null)
                                                {

#line default
#line hidden
                BeginContext(6956, 78, true);
                WriteLiteral("                                                    <span class=\"text-danger\">");
                EndContext();
                BeginContext(7035, 22, false);
#line 130 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                                         Write(ViewData["error_date"]);

#line default
#line hidden
                EndContext();
                BeginContext(7057, 8, true);
                WriteLiteral("</span>\n");
                EndContext();
#line 131 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\Create.cshtml"
                                                }

#line default
#line hidden
                BeginContext(7115, 562, true);
                WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>

                </div>
                <div class=""row mt-4"">
                    <div class=""col-md-4 mx-auto"">
                        <input style=""width: 300px;"" class=""btn btn-success"" type=""submit"" value=""Əlavə et"" />
                    </div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7684, 62, true);
            WriteLiteral("\n        </div>\n    </div>\n    <!--content-wrapper-->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDeviceVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
