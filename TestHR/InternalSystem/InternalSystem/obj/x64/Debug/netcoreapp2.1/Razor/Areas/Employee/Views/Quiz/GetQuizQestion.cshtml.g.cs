#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c86a90319f0c022f5c6715ed343e441ffdc522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Quiz_GetQuizQestion), @"mvc.1.0.view", @"/Areas/Employee/Views/Quiz/GetQuizQestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Quiz/GetQuizQestion.cshtml", typeof(AspNetCore.Areas_Employee_Views_Quiz_GetQuizQestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c86a90319f0c022f5c6715ed343e441ffdc522", @"/Areas/Employee/Views/Quiz/GetQuizQestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Quiz_GetQuizQestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InternalSystem.Areas.InternalHR.Models.Quiz.Question>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
  
    ViewData["Title"] = "GetQuizQestion";

#line default
#line hidden
            BeginContext(186, 230, true);
            WriteLiteral("\r\n\r\n<script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n<style>\r\n    div#test {\r\n        border: #000 1px solid;\r\n        padding: 10px 40px 40px 40px;\r\n        text-align: center\r\n    }\r\n</style>\r\n\r\n<div>Quesion ");
            EndContext();
            BeginContext(417, 23, false);
#line 17 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
        Write(ViewBag.CurrentQuestion);

#line default
#line hidden
            EndContext();
            BeginContext(440, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(445, 22, false);
#line 17 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
                                    Write(ViewBag.TotalQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(467, 67, true);
            WriteLiteral("</div>\r\n<label id=\"ShowTime\"></label>\r\n<h2 id=\"test_status\"></h2>\r\n");
            EndContext();
            BeginContext(596, 35, true);
            WriteLiteral("\r\n<div id=\"test\" class=\"row\">\r\n    ");
            EndContext();
            BeginContext(631, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf2628f972d94d668c752980cc502959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 641, "~/QuesPic/", 641, 10, true);
#line 23 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
AddHtmlAttributeValue("", 651, Model.QuestionText, 651, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(674, 25, true);
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 25 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
         for (int i = 0; i < @Model.Choices.Count(); i++)
        {
            

#line default
#line hidden
            BeginContext(942, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 956, "\"", 1178, 1);
#line 28 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
WriteAttributeValue("", 963, Url.Action("GetQuizQestion", "quiz", new { quizId=Model.QuizID ,@qno = Convert.ToInt32(Model.QuestionNo), questionID=Convert.ToInt32(Model.QuestionID), choiceID=Convert.ToInt32(Model.Choices.ToList()[i].ChoiceID)}), 963, 215, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1179, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1180, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9f2da0203cb420e90de403a8e011307", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1190, "~/QuesPic/", 1190, 10, true);
#line 28 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
AddHtmlAttributeValue("", 1200, Model.Choices.ToList()[i].ChoiceText, 1200, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1241, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 29 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetQuizQestion.cshtml"
                      
        }

#line default
#line hidden
            BeginContext(1282, 273, true);
            WriteLiteral(@"    </div>
</div>

<script>
    $(document)
        .ready(function () {
            ShowTime();
        });

    function ShowTime() {
        debugger;
        a = setInterval(function () {
            const showTimeEl = document.getElementById(""ShowTime"");
");
            EndContext();
            BeginContext(1618, 1092, true);
            WriteLiteral(@"            var startTime = new Date('12/18/2020 12:15:52 PM');
            var dateNow = new Date();
            //var t = d.getTime();
            //var tt = d.toLocaleTimeString();
            var seconds = Math.floor((dateNow.getTime() - startTime.getTime()) / 1000);
            var minutes = Math.floor(seconds / 60); 
            var tt = seconds % 60;
            debugger;
            minutes = minutes < 10 ? '0' + minutes : minutes;
            tt = tt < 10 ? '0' + tt : tt;
            //if (seconds >= 59) {
            //    minutes += 1;
            //    seconds = 00;
            //}
            showTimeEl.innerHTML = `${minutes}:${tt}`;
            //alert(""Hi"");
            if (minutes == 00 && tt == 59) {
                clearInterval(a);
                alert(""Exam time is finished!"");
                window.location.href = ""/Quiz/SelectQuizz""
            }
            //af = af - 1;
            //if (af == 0) {
            //    clearInterval(a);
            //}
       ");
            WriteLiteral("     //console.log(af);\r\n        }, 1000);\r\n    }\r\n</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InternalSystem.Areas.InternalHR.Models.Quiz.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591