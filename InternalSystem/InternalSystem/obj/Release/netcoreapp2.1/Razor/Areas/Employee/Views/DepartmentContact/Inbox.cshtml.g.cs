#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bc6ae3423e9a90a37eb16789880aa95dabdc47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_DepartmentContact_Inbox), @"mvc.1.0.view", @"/Areas/Employee/Views/DepartmentContact/Inbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/DepartmentContact/Inbox.cshtml", typeof(AspNetCore.Areas_Employee_Views_DepartmentContact_Inbox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bc6ae3423e9a90a37eb16789880aa95dabdc47", @"/Areas/Employee/Views/DepartmentContact/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_DepartmentContact_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactBetweenDepartmentsInbox>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";

#line default
#line hidden
            BeginContext(89, 914, true);
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
<div class=""content-wrapper"" style=""background:#e0e0e0"">
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark""></h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(1003, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f11a7df15f73486b812d909ac5331899", async() => {
                BeginContext(1072, 9, true);
                WriteLiteral("Dashboard");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1085, 1296, true);
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"">Gələnlər</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <div class="""">
            <div class=""card-body"">
                <div class=""row"">
                    <div style=""height:600px;overflow-y:scroll;"" class=""col-md-12 mx-auto"" id=""inboxtableDiv"">
                        <table class=""table table-responsive-md"" style=""color:black;"">
                            <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
                                <tr class=""All_Index_View_Change_Tr"">
                                    <th scope=""col"">Sıra №</th>
                                    <th scope=""col"">Kimdən</th>
                                    <th scope=""col""> Mövzu</th>
                                    <th scope=""col""> Mesaj</th>
                                    <th scope=""col""> Tarix</th>
                     ");
            WriteLiteral(@"               <th scope=""col""> Status</th>
                                    <th scope=""col""> Sil</th>
                                </tr>
                            </thead>
                            <tbody style=""text-align: center;background: white;"" class="""">
");
            EndContext();
#line 61 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                 if (Model.Count() != 0)
                                {
                                    int count = 1;
                                    foreach (var inbox in Model)
                                    {
                                        

#line default
#line hidden
#line 66 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                         if (inbox.isRead != false)
                                        {

#line default
#line hidden
            BeginContext(2736, 124, true);
            WriteLiteral("                                            <tr style=\"cursor:pointer;\">\n                                                <th");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2860, "\"", 2896, 3);
            WriteAttributeValue("", 2870, "openAnswerModal(", 2870, 16, true);
#line 69 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 2886, inbox.Id, 2886, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2895, ")", 2895, 1, true);
            EndWriteAttribute();
            BeginContext(2897, 13, true);
            WriteLiteral(" scope=\"row\">");
            EndContext();
            BeginContext(2911, 5, false);
#line 69 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                                Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2916, 57, true);
            WriteLiteral("</th>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2973, "\"", 3009, 3);
            WriteAttributeValue("", 2983, "openAnswerModal(", 2983, 16, true);
#line 70 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 2999, inbox.Id, 2999, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3008, ")", 3008, 1, true);
            EndWriteAttribute();
            BeginContext(3010, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3012, 10, false);
#line 70 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.From);

#line default
#line hidden
            EndContext();
            BeginContext(3022, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3079, "\"", 3115, 3);
            WriteAttributeValue("", 3089, "openAnswerModal(", 3089, 16, true);
#line 71 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 3105, inbox.Id, 3105, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3114, ")", 3114, 1, true);
            EndWriteAttribute();
            BeginContext(3116, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3118, 13, false);
#line 71 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(3131, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3188, "\"", 3224, 3);
            WriteAttributeValue("", 3198, "openAnswerModal(", 3198, 16, true);
#line 72 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 3214, inbox.Id, 3214, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3223, ")", 3223, 1, true);
            EndWriteAttribute();
            BeginContext(3225, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3227, 13, false);
#line 72 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.Message);

#line default
#line hidden
            EndContext();
            BeginContext(3240, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3297, "\"", 3333, 3);
            WriteAttributeValue("", 3307, "openAnswerModal(", 3307, 16, true);
#line 73 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 3323, inbox.Id, 3323, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3332, ")", 3332, 1, true);
            EndWriteAttribute();
            BeginContext(3334, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3336, 17, false);
#line 73 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 191, true);
            WriteLiteral("</td>\n                                                <td class=\"text-white\">◉</td>\n                                                <td>\n                                                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3544, "\"", 3583, 3);
            WriteAttributeValue("", 3554, "deleteConfirmation(", 3554, 19, true);
#line 76 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 3573, inbox.Id, 3573, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3582, ")", 3582, 1, true);
            EndWriteAttribute();
            BeginContext(3584, 136, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\n                                                </td>\n                                            </tr>\n");
            EndContext();
#line 79 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3849, 125, true);
            WriteLiteral("                                            <tr style=\"font-weight:bold\">\n                                                <th");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3974, "\"", 4010, 3);
            WriteAttributeValue("", 3984, "openAnswerModal(", 3984, 16, true);
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4000, inbox.Id, 4000, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4009, ")", 4009, 1, true);
            EndWriteAttribute();
            BeginContext(4011, 13, true);
            WriteLiteral(" scope=\"row\">");
            EndContext();
            BeginContext(4025, 5, false);
#line 83 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                                Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(4030, 57, true);
            WriteLiteral("</th>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4087, "\"", 4123, 3);
            WriteAttributeValue("", 4097, "openAnswerModal(", 4097, 16, true);
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4113, inbox.Id, 4113, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4122, ")", 4122, 1, true);
            EndWriteAttribute();
            BeginContext(4124, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4126, 10, false);
#line 84 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.From);

#line default
#line hidden
            EndContext();
            BeginContext(4136, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4193, "\"", 4229, 3);
            WriteAttributeValue("", 4203, "openAnswerModal(", 4203, 16, true);
#line 85 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4219, inbox.Id, 4219, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4228, ")", 4228, 1, true);
            EndWriteAttribute();
            BeginContext(4230, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4232, 13, false);
#line 85 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(4245, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4302, "\"", 4338, 3);
            WriteAttributeValue("", 4312, "openAnswerModal(", 4312, 16, true);
#line 86 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4328, inbox.Id, 4328, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4337, ")", 4337, 1, true);
            EndWriteAttribute();
            BeginContext(4339, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4341, 13, false);
#line 86 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.Message);

#line default
#line hidden
            EndContext();
            BeginContext(4354, 57, true);
            WriteLiteral("</td>\n                                                <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4411, "\"", 4447, 3);
            WriteAttributeValue("", 4421, "openAnswerModal(", 4421, 16, true);
#line 87 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4437, inbox.Id, 4437, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4446, ")", 4446, 1, true);
            EndWriteAttribute();
            BeginContext(4448, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4450, 17, false);
#line 87 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                                                                    Write(inbox.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(4467, 192, true);
            WriteLiteral("</td>\n                                                <td class=\"text-green\">◉</td>\n\n                                                <td>\n                                                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4659, "\"", 4698, 3);
            WriteAttributeValue("", 4669, "deleteConfirmation(", 4669, 19, true);
#line 91 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
WriteAttributeValue("", 4688, inbox.Id, 4688, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4697, ")", 4697, 1, true);
            EndWriteAttribute();
            BeginContext(4699, 136, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\n                                                </td>\n                                            </tr>\n");
            EndContext();
#line 94 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                        }

#line default
#line hidden
#line 94 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                         

                                        count++;
                                    }
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5070, 452, true);
            WriteLiteral(@"                                    <tr>
                                        <td>0</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                        <td>Boş</td>
                                    </tr>
");
            EndContext();
#line 110 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                                }

#line default
#line hidden
            BeginContext(5556, 451, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
    </div>

    <!--content-wrapper-->
</div>
<section class=""modalSection"">
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""inboxModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"" id=""intoIntoModal"">

            </div>
        </div>
    </div>
</section>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6024, 514, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js""></script>
    <script>
        function deleteConfirmation(Id) {
            swal({
                title: ""Silməyə əminsiniz?"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {
                        $.ajax({
                        type: 'post',
                        url: '");
                EndContext();
                BeginContext(6539, 53, false);
#line 143 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                         Write(Url.Action("DeleteMsjFromInbox", "DepartmentContact"));

#line default
#line hidden
                EndContext();
                BeginContext(6592, 781, true);
                WriteLiteral(@"',
                        data: { msjId: Id },
                           success: function (response) {
                               $(""#inboxtableDiv"").html(response)
                               if (willDelete) {
                                   swal(""Mesaj Silindi"", {
                                       icon: ""success"",
                                   });
                               }
                        },
                        error: function (response) {
                            console.error(response)
                        }
                     })
                    }
                });
        }


        function openAnswerModal(Id) {
                      $.ajax({
                        type: 'get',
                        url: '");
                EndContext();
                BeginContext(7374, 56, false);
#line 165 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
                         Write(Url.Action("GetSingleInboxMessage", "DepartmentContact"));

#line default
#line hidden
                EndContext();
                BeginContext(7430, 571, true);
                WriteLiteral(@"',
                        data: { msjId: Id },
                           success: function (response) {
                               $(""#inboxModal"").modal('show')
                               $(""#intoIntoModal"").html(response)
                        },
                        error: function (response) {
                            console.error(response)
                        }
                     })
        }


        function closeModal() {
            $(""#inboxModal"").modal('hide')
            $.ajax({
              type: 'get',
              url: '");
                EndContext();
                BeginContext(8002, 44, false);
#line 182 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
               Write(Url.Action("loadInbox", "DepartmentContact"));

#line default
#line hidden
                EndContext();
                BeginContext(8046, 412, true);
                WriteLiteral(@"',
                 success: function (response) {
                     $(""#inboxtableDiv"").html(response)
              },
              error: function (response) {
                  console.error(response)
              }
           })
        }


        function sentAnswerMessage(Id) {
           var answerId = $(""#answerMesajId"").val()
           $.ajax({
              type: 'post',
              url: '");
                EndContext();
                BeginContext(8459, 48, false);
#line 197 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Areas\Employee\Views\DepartmentContact\Inbox.cshtml"
               Write(Url.Action("AnswerMessage", "DepartmentContact"));

#line default
#line hidden
                EndContext();
                BeginContext(8507, 604, true);
                WriteLiteral(@"',
               data: {
                   from: Id,
                   answer:answerId,
               },
                 success: function (response) {
                     $(""#inboxtableDiv"").html(response)
                     $(""#inboxModal"").modal('hide')
                     swal({
                         title: ""Uğurlu!"",
                         icon: ""success"",
                         button: ""Bağla!"",
                     });
              },
              error: function (response) {
                  console.error(response)
              }
           })
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactBetweenDepartmentsInbox>> Html { get; private set; }
    }
}
#pragma warning restore 1591