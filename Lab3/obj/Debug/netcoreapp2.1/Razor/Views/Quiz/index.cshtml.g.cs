#pragma checksum "D:\Учеба\6 семестр\Web\lab3\Lab3\Lab3\Views\Quiz\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad9d172da4bbe6f60e982cfb4940ca5d74eb694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_index), @"mvc.1.0.view", @"/Views/Quiz/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/index.cshtml", typeof(AspNetCore.Views_Quiz_index))]
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
#line 1 "D:\Учеба\6 семестр\Web\lab3\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#line 2 "D:\Учеба\6 семестр\Web\lab3\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad9d172da4bbe6f60e982cfb4940ca5d74eb694", @"/Views/Quiz/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ab7d75fe2e0e76f78a01f25c0020ed6eca01b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\Учеба\6 семестр\Web\lab3\Lab3\Lab3\Views\Quiz\index.cshtml"
  
    ViewData["Title"] = "Lab3 Home Page";

#line default
#line hidden
            BeginContext(48, 224, true);
            WriteLiteral("<h2>Mockups</h2>\n<br />\n<ul>\n    <li>\n        <h4>\n            <a href=\"/Quiz/Quiz\">Quiz</a>\n        </h4>\n    </li>\n    <li>\n        <h4>\n            <a href=\"/Quiz/QuizResult\">QuizResult</a>\n        </h4>\n    </li>\n</ul>\n\n");
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
