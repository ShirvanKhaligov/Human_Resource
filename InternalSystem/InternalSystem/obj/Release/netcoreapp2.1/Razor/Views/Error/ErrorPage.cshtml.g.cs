#pragma checksum "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Views\Error\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97488d4db05d57b856e3fc6c9adafb0d9907aa6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_ErrorPage), @"mvc.1.0.view", @"/Views/Error/ErrorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/ErrorPage.cshtml", typeof(AspNetCore.Views_Error_ErrorPage))]
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
#line 2 "C:\Users\shirvan.khaligov\Desktop\InternalSystem\InternalSystem\Views\_ViewImports.cshtml"
using InternalSystem.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97488d4db05d57b856e3fc6c9adafb0d9907aa6c", @"/Views/Error/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb54b00526a3cacd93382daa18d218a6dcca9c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 1409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8767b1c81a6140f69b1e2251038102d0", async() => {
                BeginContext(29, 1396, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Errorr</title>
    <style>
        body {
            margin: 0;
        }

        .full-screen {
            background-color: #333;
            width: 100vw;
            height: 100vh;
            color: white;
            font-family: 'Arial Black';
            text-align: center;
        }

        .container {
            padding-top: 4em;
            width: 50%;
            display: block;
            margin: 0 auto;
        }

        .error-num {
            font-size: 8em;
        }

        .eye {
            background: #fff;
            border-radius: 50%;
            display: inline-block;
            height: 100px;
            position: relative;
            width: 100px;
        }

            .eye::after {
                background: #000;
                border-radius: 50%;
                bottom: 56.1px;
                content: ' ';
                height: 33px;
                position: absolute;
                right: ");
                WriteLiteral(@"33px;
                width: 33px;
            }

        .italic {
            font-style: italic;
        }

        p {
            margin-bottom: 4em;
        }

        a {
            color: white;
            text-decoration: none;
            text-transform: uppercase;
        }

            a:hover {
                color: lightgray;
            }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1432, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1433, 1078, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c07105881e5c424291c40b2df0d2ec08", async() => {
                BeginContext(1439, 1065, true);
                WriteLiteral(@"
    <div class=""full-screen"">
        <div class='container'>
            <span class=""error-num"">4</span>
            <div class='eye'></div>
            <div class='eye'></div>

            <p class=""sub-text"">Xəta baş verdi! Zəhmət olmasa bu barədə məlumat verin.</p>
        </div>
    </div>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script>
        $("".full-screen"").mousemove(function (event) {
            var eye = $("".eye"");
            var x = (eye.offset().left) + (eye.width() / 2);
            var y = (eye.offset().top) + (eye.height() / 2);
            var rad = Math.atan2(event.pageX - x, event.pageY - y);
            var rot = (rad * (180 / Math.PI) * -1) + 180;
            eye.css({
                '-webkit-transform': 'rotate(' + rot + 'deg)',
                '-moz-transform': 'rotate(' + rot + 'deg)',
                '-ms-transform': 'rotate(' + rot + 'deg)',
                'transform': 'rotate(' + rot + 'deg)'
  ");
                WriteLiteral("          });\n        });\n\n    </script>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2511, 10, true);
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
