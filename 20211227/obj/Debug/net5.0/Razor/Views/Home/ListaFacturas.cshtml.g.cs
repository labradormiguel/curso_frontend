#pragma checksum "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/ListaFacturas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41e6035afc30c5e0a0b06a601a1a1c049970ae80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaFacturas), @"mvc.1.0.view", @"/Views/Home/ListaFacturas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e6035afc30c5e0a0b06a601a1a1c049970ae80", @"/Views/Home/ListaFacturas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc492b0396a6cbd05285f2cce8669ff03a810a2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaFacturas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/miguel/Proyectos/Cursos/curso_frontend/20211227/Views/Home/ListaFacturas.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {

        $(""#formularioinsertar"").hide();
        buscarTodos();

        $(""#botonNuevo"").click(function () {

            $(""#listado"").hide();
            $(""#formularioinsertar"").show();
        })

        $(""#botonInsertar"").click(function () {

            var factura = {};
            factura.numero = $(""#numero"").val();
            factura.concepto = $(""#concepto"").val();
            factura.importe = $(""#importe"").val();
            //console.log(factura);

            // muy manual con jquery y ajax para enviar datos al servidor en json
            $.ajax({
                url: ""/api/facturas"",
                type: ""POST"",
                data: JSON.stringify(factura),
                contentType: ""application/json; charset=utf-8"",
                error: function (response) {
                    console.dir(response);
                },
                success: function (response) {


            ");
            WriteLiteral(@"        $(""#listado"").show();
                    $(""#formularioinsertar"").hide();
                    $(""#mitabla"").empty();
                    buscarTodos();
                }
            });





        })
    });

    function borrar(numero) {

        $.ajax({
            url: ""/api/facturas/"" + numero,
            type: ""DELETE"",
            contentType: ""application/json; charset=utf-8"",
            error: function (response) {
                alert(response.responseText);
            },
            success: function (response) {

                $(""#mitabla"").empty();
                buscarTodos();
            }

        });


    }
    function buscarTodos() {

        $.getJSON(""/api/facturas"", function (datos) {

            $(""#mitabla"").append(
                `<tr>
                    <th>N??mero</th>
                    <th>Concepto</th>
                    <th>Importe</th>
                    <th>#</th>
                </tr>`
            )

      ");
            WriteLiteral(@"      for (let i = 0; i < datos.length; i++) {

                $(""#mitabla"").append(
                    `<tr>
                        <td>${datos[i].numero}</td>
                        <td>${datos[i].concepto}</td>
                        <td>${datos[i].importe}</td>
                        <td>
                            <a href="""" onclick=""borrar(${datos[i].numero});return false;"">???</a>
                        </td>
                    </tr>`);
            }
        })

    }


</script>
<div id=""listado"">
    <table id=""mitabla"">

    </table>

    <input type=""button"" value=""insertar"" id=""botonNuevo"" />
</div>
<div id=""formularioinsertar"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41e6035afc30c5e0a0b06a601a1a1c049970ae806244", async() => {
                WriteLiteral(@"

        <p>
            Numero<input type=""text"" name=""numero"" id=""numero"" />
        </p>
        <p>
            Concepto<input type=""text"" name=""concepto"" id=""concepto"" />
        </p>
        <p>
            Importe<input type=""text"" name=""importe"" id=""importe"" />
        </p>
        <p>
            <input type=""button"" id=""botonInsertar"" value=""aceptar"" />
        </p>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>");
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
