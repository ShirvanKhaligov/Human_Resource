#pragma checksum "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2695a8e46c481f92f360900674c96142323f9c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Shared_PartialView__inboxMessagePartial), @"mvc.1.0.view", @"/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml", typeof(AspNetCore.Areas_Employee_Views_Shared_PartialView__inboxMessagePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2695a8e46c481f92f360900674c96142323f9c4", @"/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a9ea914043a907ab4e2f42dfbedfd0f7d8f984", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Shared_PartialView__inboxMessagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactBetweenDepartmentsInbox>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(118, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(170, 528, true);
            WriteLiteral(@"<table class=""table table-responsive-md "">
    <thead style=""text-align: center"" class=""All_Index_View_Change_Thead"">
        <tr class=""All_Index_View_Change_Tr"">
            <th scope=""col"">Sıra №</th>
            <th scope=""col"">Kimdən</th>
            <th scope=""col""> Mövzu</th>
            <th scope=""col""> Mesaj</th>
            <th scope=""col""> Tarix</th>
            <th scope=""col""> Status</th>
            <th scope=""col""> Sil</th>
        </tr>
    </thead>
    <tbody style=""text-align: center;background: white;"">
");
            EndContext();
#line 18 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
         if (Model.Count() != 0)
        {
            int count = 1;
            foreach (var inbox in Model)
            {

                

#line default
#line hidden
#line 24 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                 if (inbox.isRead != false)
                {

#line default
#line hidden
            BeginContext(886, 52, true);
            WriteLiteral("                    <tr>\n                        <th");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 938, "\"", 974, 3);
            WriteAttributeValue("", 948, "openAnswerModal(", 948, 16, true);
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 964, inbox.Id, 964, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 973, ")", 973, 1, true);
            EndWriteAttribute();
            BeginContext(975, 13, true);
            WriteLiteral(" scope=\"row\">");
            EndContext();
            BeginContext(989, 5, false);
#line 27 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                                        Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(994, 33, true);
            WriteLiteral("</th>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1027, "\"", 1063, 3);
            WriteAttributeValue("", 1037, "openAnswerModal(", 1037, 16, true);
#line 28 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1053, inbox.Id, 1053, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1062, ")", 1062, 1, true);
            EndWriteAttribute();
            BeginContext(1064, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1066, 10, false);
#line 28 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.From);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1109, "\"", 1145, 3);
            WriteAttributeValue("", 1119, "openAnswerModal(", 1119, 16, true);
#line 29 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1135, inbox.Id, 1135, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1144, ")", 1144, 1, true);
            EndWriteAttribute();
            BeginContext(1146, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1148, 13, false);
#line 29 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1194, "\"", 1230, 3);
            WriteAttributeValue("", 1204, "openAnswerModal(", 1204, 16, true);
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1220, inbox.Id, 1220, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1229, ")", 1229, 1, true);
            EndWriteAttribute();
            BeginContext(1231, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1233, 13, false);
#line 30 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1279, "\"", 1315, 3);
            WriteAttributeValue("", 1289, "openAnswerModal(", 1289, 16, true);
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1305, inbox.Id, 1305, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1314, ")", 1314, 1, true);
            EndWriteAttribute();
            BeginContext(1316, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1318, 17, false);
#line 31 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 119, true);
            WriteLiteral("</td>\n                        <td class=\"text-white\">◉</td>\n                        <td>\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1454, "\"", 1493, 3);
            WriteAttributeValue("", 1464, "deleteConfirmation(", 1464, 19, true);
#line 34 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1483, inbox.Id, 1483, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1492, ")", 1492, 1, true);
            EndWriteAttribute();
            BeginContext(1494, 88, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 37 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1639, 77, true);
            WriteLiteral("                    <tr style=\"font-weight:bold\">\n                        <th");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1716, "\"", 1752, 3);
            WriteAttributeValue("", 1726, "openAnswerModal(", 1726, 16, true);
#line 41 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1742, inbox.Id, 1742, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1751, ")", 1751, 1, true);
            EndWriteAttribute();
            BeginContext(1753, 13, true);
            WriteLiteral(" scope=\"row\">");
            EndContext();
            BeginContext(1767, 5, false);
#line 41 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                                        Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1772, 33, true);
            WriteLiteral("</th>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1805, "\"", 1841, 3);
            WriteAttributeValue("", 1815, "openAnswerModal(", 1815, 16, true);
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1831, inbox.Id, 1831, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1840, ")", 1840, 1, true);
            EndWriteAttribute();
            BeginContext(1842, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1844, 10, false);
#line 42 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.From);

#line default
#line hidden
            EndContext();
            BeginContext(1854, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1887, "\"", 1923, 3);
            WriteAttributeValue("", 1897, "openAnswerModal(", 1897, 16, true);
#line 43 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1913, inbox.Id, 1913, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1922, ")", 1922, 1, true);
            EndWriteAttribute();
            BeginContext(1924, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1926, 13, false);
#line 43 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1939, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1972, "\"", 2008, 3);
            WriteAttributeValue("", 1982, "openAnswerModal(", 1982, 16, true);
#line 44 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 1998, inbox.Id, 1998, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2007, ")", 2007, 1, true);
            EndWriteAttribute();
            BeginContext(2009, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2011, 13, false);
#line 44 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2024, 33, true);
            WriteLiteral("</td>\n                        <td");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2057, "\"", 2093, 3);
            WriteAttributeValue("", 2067, "openAnswerModal(", 2067, 16, true);
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 2083, inbox.Id, 2083, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2092, ")", 2092, 1, true);
            EndWriteAttribute();
            BeginContext(2094, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2096, 17, false);
#line 45 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                                                            Write(inbox.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(2113, 119, true);
            WriteLiteral("</td>\n                        <td class=\"text-green\">◉</td>\n                        <td>\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2232, "\"", 2271, 3);
            WriteAttributeValue("", 2242, "deleteConfirmation(", 2242, 19, true);
#line 48 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
WriteAttributeValue("", 2261, inbox.Id, 2261, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2270, ")", 2270, 1, true);
            EndWriteAttribute();
            BeginContext(2272, 88, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\n                        </td>\n                    </tr>\n");
            EndContext();
#line 51 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                }

#line default
#line hidden
#line 51 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"
                 

                count++;
            }
        }
        else
        {


#line default
#line hidden
            BeginContext(2452, 209, true);
            WriteLiteral("            <tr>\n                <th>Boş</th>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n                <td>Boş</td>\n            </tr>\n");
            EndContext();
#line 67 "D:\Projects\HRS\TestHR\InternalSystem\InternalSystem\Areas\Employee\Views\Shared\PartialView\_inboxMessagePartial.cshtml"

        }

#line default
#line hidden
            BeginContext(2672, 25, true);
            WriteLiteral("    </tbody>\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactBetweenDepartmentsInbox>> Html { get; private set; }
    }
}
#pragma warning restore 1591