#pragma checksum "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d90be78028523193447c7a4fd926b96ccc646b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\_ViewImports.cshtml"
using AgendaContatosMVC;

#line default
#line hidden
#line 2 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\_ViewImports.cshtml"
using AgendaContatosMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d90be78028523193447c7a4fd926b96ccc646b", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da313968ae4eb6dd8fa677f9ffb5bb7d96328c35", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Descrições";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 4 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(80, 19, false);
#line 5 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 179, true);
            WriteLiteral("</h3>\r\n\r\n<p>Agenda Client foi criado com intuito de gerenciar e controlar a carteira de clientes, tem como foco atender empresas de pequeno a grande porte. </p>\r\n<p>Desenvolvedor ");
            EndContext();
            BeginContext(279, 21, false);
#line 8 "D:\temp\ws-vs2022\LinguagemC\AgendaContatosMVC\AgendaContatosMVC\Views\Home\About.cshtml"
            Write(ViewData["Developer"]);

#line default
#line hidden
            EndContext();
            BeginContext(300, 139, true);
            WriteLiteral("</p>\r\n<p>Codigo Aberto: <a href=\"https://github.com/Cotonas/AgendaContatosMVC.git\">https://github.com/Cotonas/AgendaContatosMVC.git</a></p>");
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
