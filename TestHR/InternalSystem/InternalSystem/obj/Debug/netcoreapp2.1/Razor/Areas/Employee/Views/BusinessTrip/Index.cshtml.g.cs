#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f8b8e8f3ef968fc27a15dbc4150af4f24be760f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_BusinessTrip_Index), @"mvc.1.0.view", @"/Areas/Employee/Views/BusinessTrip/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/BusinessTrip/Index.cshtml", typeof(AspNetCore.Areas_Employee_Views_BusinessTrip_Index))]
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
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models;

#line default
#line hidden
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Employee.ViewModels;

#line default
#line hidden
#line 4 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.Departments;

#line default
#line hidden
#line 5 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.Admin.Models;

#line default
#line hidden
#line 6 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\_ViewImports.cshtml"
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8b8e8f3ef968fc27a15dbc4150af4f24be760f", @"/Areas/Employee/Views/BusinessTrip/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_BusinessTrip_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessTripEmp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BusinessTrip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(65, 136, true);
            WriteLiteral("\r\n<div class=\"content-wrapper\" style=\"color: black; background-color: rgb(255, 255, 255);\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(201, 3058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ede69860bd9487495eb6ac26d4db63d", async() => {
                BeginContext(221, 316, true);
                WriteLiteral(@"
            <div style=""height: 30px""></div>


            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">Ad Soyad Finkod</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 537, "\"", 632, 1);
#line 17 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 545, Model.Emplooyee.FirstName+" " + Model.Emplooyee.Lastname+" "+Model.Emplooyee.FinCode, 545, 87, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(633, 390, true);
                WriteLiteral(@" id=""name"" class=""form-control input-height""
                           type=""text"">
                </div>
            </div>

            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">Tarixdən</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1023, "\"", 1048, 1);
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 1031, Model.FromDate, 1031, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1049, 391, true);
                WriteLiteral(@" id=""name"" class=""form-control input-height""
                           type=""text"">
                </div>
            </div>

            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">Tarixədək</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1440, "\"", 1463, 1);
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 1448, Model.ToDate, 1448, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1464, 388, true);
                WriteLiteral(@" id=""name"" class=""form-control input-height""
                           type=""text"">
                </div>
            </div>

            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">Mağaza</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1852, "\"", 1880, 1);
#line 47 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 1860, Model.PartnorName, 1860, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1881, 386, true);
                WriteLiteral(@" id=""name"" class=""form-control input-height""
                           type=""text"">
                </div>
            </div>

            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">İzah</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2267, "\"", 2290, 1);
#line 57 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 2275, Model.Commet, 2275, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2291, 388, true);
                WriteLiteral(@" id=""name"" class=""form-control input-height""
                           type=""text"">
                </div>
            </div>

            <div class=""form-group row "">
                <div class=""col-md-2"">
                    <label class=""label-font"" for=""name"">Region</label>
                </div>
                <div class=""col-md-5"">
                    <input readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2679, "\"", 2715, 1);
#line 67 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\BusinessTrip\Index.cshtml"
WriteAttributeValue("", 2687, Model.Distric.DistricName, 2687, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2716, 167, true);
                WriteLiteral(" id=\"name\" class=\"form-control input-height\"\r\n                           type=\"text\">\r\n                </div>\r\n            </div>\r\n\r\n            <br><br>\r\n            ");
                EndContext();
                BeginContext(2883, 154, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0002b1f194c14830a408be82ff8c67a5", async() => {
                    BeginContext(2980, 53, true);
                    WriteLiteral("Silmək istədiyinizdən əminsiniz? Xeyr isə geri dönün ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
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
                BeginContext(3037, 215, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <button style=\"float:left;\" class=\"btn btn-danger col-md-3 mx-auto\" type=\"submit\">\r\n                    Sil\r\n                </button>\r\n            </div>\r\n\r\n        ");
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
            BeginContext(3259, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessTripEmp> Html { get; private set; }
    }
}
#pragma warning restore 1591
