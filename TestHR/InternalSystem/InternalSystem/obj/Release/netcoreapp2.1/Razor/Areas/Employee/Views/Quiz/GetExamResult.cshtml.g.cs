#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7d4fa762eb76789e3fbceea84f5c7730033426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Quiz_GetExamResult), @"mvc.1.0.view", @"/Areas/Employee/Views/Quiz/GetExamResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Quiz/GetExamResult.cshtml", typeof(AspNetCore.Areas_Employee_Views_Quiz_GetExamResult))]
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
#line 1 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
using InternalSystem.Areas.InternalHR.Models.Quiz;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7d4fa762eb76789e3fbceea84f5c7730033426", @"/Areas/Employee/Views/Quiz/GetExamResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Quiz_GetExamResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exam_Result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
  
    ViewData["Title"] = "GetExamResult";

#line default
#line hidden
            BeginContext(127, 274, true);
            WriteLiteral(@"
<h1>GetExamResult</h1>

<div>
    <table>
        <thead>
        <th>
            #
        </th>
        <th>
            User
        </th>
        <th>
            Quiz Exam
        </th>
        <th>
            Score
        </th>
        </thead>
");
            EndContext();
#line 25 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
           int i = 0;

#line default
#line hidden
            BeginContext(425, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 26 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
         foreach (InternalSystem.Areas.InternalHR.Models.Quiz.Exam_Result exam in (List<InternalSystem.Areas.InternalHR.Models.Quiz.Exam_Result>)(Model))
        {

#line default
#line hidden
            BeginContext(591, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(631, 9, false);
#line 29 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
                Write(i = i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(641, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(669, 13, false);
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
               Write(exam.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(682, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(710, 13, false);
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
               Write(exam.QuizName);

#line default
#line hidden
            EndContext();
            BeginContext(723, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(751, 10, false);
#line 32 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
               Write(exam.Score);

#line default
#line hidden
            EndContext();
            BeginContext(761, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Quiz\GetExamResult.cshtml"
        }

#line default
#line hidden
            BeginContext(798, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam_Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591