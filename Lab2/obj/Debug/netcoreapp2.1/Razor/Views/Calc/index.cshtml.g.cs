#pragma checksum "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4eb5845d79d6980cd5c0b81ada30023799860e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_index), @"mvc.1.0.view", @"/Views/Calc/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/index.cshtml", typeof(AspNetCore.Views_Calc_index))]
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
#line 1 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#line 2 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eb5845d79d6980cd5c0b81ada30023799860e6", @"/Views/Calc/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89765656c821c781e86e91f6556d3354219de22", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Учеба\6 семестр\Web\daniil.haibullin.931705-master\Lab2\Lab2\Views\Calc\index.cshtml"
  
    ViewData["Title"] = "Lab2 Home Page";

#line default
#line hidden
            BeginContext(47, 467, true);
            WriteLiteral(@"<h2>Form Parameters Parsing Demo</h2>
<ul>
    <li>
        <a href=""/Calc/ManualParsingInSingleAction"">Manual parsing in single action</a>
    </li>
    <li>
        <a href=""/Calc/ManualParsingInSeparateActions"">Manual parsing in separate actions</a>
    </li>
    <li>
        <a href=""/Calc/ModelBindingParametrs"">Model binding (parametrs)</a>
    </li>
    <li>
        <a href=""/Calc/ModelBindingSeparateModel"">Model binding (separate model)</a>
    </li>
</ul>");
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
