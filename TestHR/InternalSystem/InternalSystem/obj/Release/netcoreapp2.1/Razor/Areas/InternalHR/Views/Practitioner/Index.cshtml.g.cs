#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c334cc01049878b86a81b4cccdd7b4d4cadd112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_InternalHR_Views_Practitioner_Index), @"mvc.1.0.view", @"/Areas/InternalHR/Views/Practitioner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/InternalHR/Views/Practitioner/Index.cshtml", typeof(AspNetCore.Areas_InternalHR_Views_Practitioner_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c334cc01049878b86a81b4cccdd7b4d4cadd112", @"/Areas/InternalHR/Views/Practitioner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1dd5b97e9d720ce4bc46ea1db6bc3e26cac2ec", @"/Areas/InternalHR/Views/_ViewImports.cshtml")]
    public class Areas_InternalHR_Views_Practitioner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhoneNumberToEmployee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Practitioner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "InternalHR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mr-md-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px;float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllPractitioner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn All_Index_View_Change_Cart_Footer_A col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 1098, true);
            WriteLiteral(@"<style>



    .btn-success {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-primary {
        background-color: #f6822d !important;
        border-color: #f6822d  !important;
    }

    .btn-warning {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }

    .btn-danger {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }
    .btn-info {
        background-color: #f6822d !important;
        border-color: #f6822d !important;
    }
</style>

<div class=""content-wrapper"">
    <div class="""">
        <div style=""background-color: #f4f6f9"" class=""card All_Index_View_Change_Card"">
            <div class=""card-header All_Index_View_Change_Card_Header"">
                <p style=""color:#f6822d"" class=""All_Index_View_Change_P"">Namizədlərin siyahısı</p>
            </div>
            <div class=""card-body "">
                <div class=""row ml-md-");
            WriteLiteral("3\">\r\n                    <div class=\"col-md-12\">\r\n                        ");
            EndContext();
            BeginContext(1182, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "585bbecef1e84b399bf88f14f572af92", async() => {
                BeginContext(1323, 73, true);
                WriteLiteral(" <i class=\"fa fa-plus-circle\" aria-hidden=\"true\"></i>  Təcrübəçi əlavə et");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(1400, 1006, true);
            WriteLiteral(@"
                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-md-12 mx-auto"">
                        <div style=""height:600px;overflow-y:scroll;"" class=""table-responsive"">
                            <table class=""table table-hover table-responsive-md"">
                                <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                                    <tr class=""All_Index_View_Change_Tr"">
                                        <th scope=""col"">Sıra №</th>
                                        <th scope=""col"">Soyadı,Adı,Ata adı</th>
                                        <th scope=""col""> Email</th>
                                        <th scope=""col""> Mobil nömrə</th>
                                    </tr>
                                </thead>
                                <tbody style=""text-align: center;"" class=""All_Index_View_Change_Tbody"">
");
            EndContext();
#line 60 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                     if (Model.Count() != 0)
                                    {
                                        int count = 1;
                                        

#line default
#line hidden
#line 63 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                         foreach (var candidatesAndNumber in Model)
                                        {

#line default
#line hidden
            BeginContext(2691, 114, true);
            WriteLiteral("                                            <tr>\r\n                                                <td scope=\"row\">");
            EndContext();
            BeginContext(2806, 5, false);
#line 66 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2811, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2872, 127, false);
#line 67 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                Write(candidatesAndNumber.Emplooyee.Lastname+" "+candidatesAndNumber.Emplooyee.FirstName+" "+candidatesAndNumber.Emplooyee.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(3000, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 68 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                 if (candidatesAndNumber.Emplooyee.Email.Length > 22)
                                                {

#line default
#line hidden
            BeginContext(3161, 56, true);
            WriteLiteral("                                                    <td>");
            EndContext();
            BeginContext(3219, 57, false);
#line 70 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                    Write(candidatesAndNumber.Emplooyee.Email.Substring(0,20)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(3277, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 71 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3440, 56, true);
            WriteLiteral("                                                    <td>");
            EndContext();
            BeginContext(3497, 35, false);
#line 74 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                   Write(candidatesAndNumber.Emplooyee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3532, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 75 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3590, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 76 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                 if (candidatesAndNumber.PhoneNumber.PhoneNumber.Length > 15)
                                                {

#line default
#line hidden
            BeginContext(3752, 56, true);
            WriteLiteral("                                                    <td>");
            EndContext();
            BeginContext(3810, 65, false);
#line 78 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                    Write(candidatesAndNumber.PhoneNumber.PhoneNumber.Substring(0,15)+"...");

#line default
#line hidden
            EndContext();
            BeginContext(3876, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 79 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(4039, 56, true);
            WriteLiteral("                                                    <td>");
            EndContext();
            BeginContext(4096, 43, false);
#line 82 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                   Write(candidatesAndNumber.PhoneNumber.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4197, 51, true);
            WriteLiteral("                                            </tr>\r\n");
            EndContext();
#line 85 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                            count++;
                                        }

#line default
#line hidden
#line 86 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4465, 335, true);
            WriteLiteral(@"                                        <tr>
                                            <td scope=""row"">0</td>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                            <td>Boş</td>
                                        </tr>
");
            EndContext();
#line 96 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4839, 184, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 103 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
             if (Model.Count() != 0)
            {

#line default
#line hidden
            BeginContext(5076, 63, true);
            WriteLiteral("                <div class=\"card-footer\">\r\n                    ");
            EndContext();
            BeginContext(5139, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fae0bbdf294b95ba0ea6006bb01add", async() => {
                BeginContext(5281, 27, true);
                WriteLiteral("Bütün namizədlərin siyahısı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(5312, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 108 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\InternalHR\Views\Practitioner\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5353, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhoneNumberToEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591