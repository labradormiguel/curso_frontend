#pragma checksum "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16212cb06077d5b983cd4456aa025547e9d71d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/_ViewImports.cshtml"
using mvc_ajax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/_ViewImports.cshtml"
using mvc_ajax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16212cb06077d5b983cd4456aa025547e9d71d0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc492b0396a6cbd05285f2cce8669ff03a810a2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {

        $(""#boton"").click(function () {

            $.get(""home/datos"", function (texto){

                $(""#mitabla"").append(""<tr><td>""+texto+""</td></tr>"");

            })

        })

    })
</script>

<table id=""mitabla"">
    <tr>
        <th>Textos</th>
    </tr>
");
#nullable restore
#line 25 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/Index.cshtml"
     foreach (var texto in ViewBag.textos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/Index.cshtml"
           Write(texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<input type=\"button\" value=\"Aceptar\" id=\"boton\" />\r\n");
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
