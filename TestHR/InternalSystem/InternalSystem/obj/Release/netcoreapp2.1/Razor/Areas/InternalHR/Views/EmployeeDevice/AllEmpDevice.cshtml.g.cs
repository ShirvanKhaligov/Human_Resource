#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\AllEmpDevice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5cb0713fa3c7ae80322830f2cc5bd4166c630e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_EmployeeDevice_AllEmpDevice), @"mvc.1.0.view", @"/Areas/InternalHR/Views/EmployeeDevice/AllEmpDevice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/EmployeeDevice/AllEmpDevice.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_EmployeeDevice_AllEmpDevice))]
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
#line 1 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.ViewModels;

#line default
#line hidden
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Education;

#line default
#line hidden
#line 4 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Commands;

#line default
#line hidden
#line 5 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 6 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 7 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Devices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5cb0713fa3c7ae80322830f2cc5bd4166c630e2", @"/Areas/InternalHR/Views/EmployeeDevice/AllEmpDevice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_EmployeeDevice_AllEmpDevice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDeviceVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmployeeDevice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn All_Index_View_Change_Cart_Footer_A col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\AllEmpDevice.cshtml"
  
    ViewData["Title"] = "AllEmpDevice";

#line default
#line hidden
            BeginContext(69, 3157, true);
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
<div class=""content-wrapper"">
    <div class="""">
        <div class=""card All_Index_View_Change_Card"" style=""padding:7px;overflow-x:scroll"">
            <div class=""row"">
                <div class=""modal"" tabindex=""-1"" id=""confirmationModalForDevice"" role=""dialog"">
                    <input type=""hidden"" id=""hiddenModal"" name=""name"" value="""" />
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                ");
            WriteLiteral(@"<h5 style=""color:black;font-size:1rem;"" class=""modal-title"">Qaurğunu qaytar</h5>
                                <button type=""button"" onclick=""closeConfirmationIdDeviceForAll()"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"" style=""padding-bottom: 0;"">
                                <p style=""color:#2590d3 !important;;font-size: 1.3rem;"">Qaytarılmasına əminsiniz?</p>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" onclick=""deleteDevice($('#hiddenModal').val())"" class=""btn btn-secondary"" data-dismiss=""modal"">Bəli</button>
                                <button type=""button"" onclick=""closeConfirmationIdDeviceForAll()"" id=""confirmationModalForPosition"" class=""btn btn-primary"">Xeyr</button>
                ");
            WriteLiteral(@"            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 mx-auto"" id=""deviceTableDiv"">
                    <table style=""color:blue;width:1250px"" class=""table table-hover table-responsive-md "">
                        <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                            <tr class=""All_Index_View_Change_Tr"">
                                <th scope=""col""> Sıra №</th>
                                <th scope=""col""> Soyadı,Adı,Ata adı</th>
                                <th scope=""col""> Ş\V seriyası</th>
                                <th scope=""col""> Vəzifəsi</th>
                                <th scope=""col""> Qurğunun növü</th>
                                <th scope=""col""> Qurğunun kodu</th>
                                <th scope=""col""> Verilmə tarixi</th>
                                <th scope=""col""> Qaytarılma tarixi</th>
                                <th scope=""col""");
            WriteLiteral("> Redaktə et</th>\n                            </tr>\n                        </thead>\n");
            EndContext();
            BeginContext(7664, 117, true);
            WriteLiteral("                </div>\n            </div>\n            <div class=\"card-footer\" style=\"width:1250px\">\n                ");
            EndContext();
            BeginContext(7781, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22ac35f525454d2e846c73dda20a6cf9", async() => {
                BeginContext(7915, 4, true);
                WriteLiteral("Geri");
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
            BeginContext(7923, 54, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7994, 148, true);
                WriteLiteral("\n    <script>\n            function deleteDevice(Id) {\n                   $.ajax({\n                       type: \'post\',\n                       url: \'");
                EndContext();
                BeginContext(8143, 38, false);
#line 156 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\EmployeeDevice\AllEmpDevice.cshtml"
                        Write(Url.Action("Delete", "EmployeeDevice"));

#line default
#line hidden
                EndContext();
                BeginContext(8181, 849, true);
                WriteLiteral(@"',
                       data: { DeviceId: Id},
                       success: function (response) {
                           console.log(response)
                           $(""#confirmationModalForDevice"").hide()
                           $(""#deviceTableDiv"").html(response)
                       },
                       error: function (response) {
                           console.error(response)
                       }
                   })
            }

            //////////////open modul
            function confirmationDeleteForDevice(Id) {
                $(""#confirmationModalForDevice"").show()
                $(""#hiddenModal"").val(Id);
            }
            //close modul//
            function closeConfirmationIdDeviceForAll() {
                $(""#confirmationModalForDevice"").hide()
            }

    </script>

");
                EndContext();
            }
            );
            BeginContext(9032, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDeviceVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
