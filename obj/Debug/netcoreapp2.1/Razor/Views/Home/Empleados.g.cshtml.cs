#pragma checksum "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd875f158b60013ee914f05190685a4e5f1058df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Empleados), @"mvc.1.0.view", @"/Views/Home/Empleados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Empleados.cshtml", typeof(AspNetCore.Views_Home_Empleados))]
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
#line 1 "F:\Programacion 1\Panaderia-Sem13\Views\_ViewImports.cshtml"
using Panaderia;

#line default
#line hidden
#line 2 "F:\Programacion 1\Panaderia-Sem13\Views\_ViewImports.cshtml"
using Panaderia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd875f158b60013ee914f05190685a4e5f1058df", @"/Views/Home/Empleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2a4f17b7724d121b1f1e6b1850771a0a7559a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Empleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "empleados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
  
    var empleados = Model;

#line default
#line hidden
            BeginContext(58, 35, true);
            WriteLiteral("\r\n<h1>Listado de Empleados</h1>\r\n\r\n");
            EndContext();
            BeginContext(93, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91cadcdd8e0744a087d661041bf29667", async() => {
                BeginContext(135, 59, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"buscar\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 194, "\"", 217, 1);
#line 9 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
WriteAttributeValue("", 202, ViewBag.buscar, 202, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(218, 70, true);
                WriteLiteral(">\r\n    <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(295, 152, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombres</th>\r\n        <th>Apellidos</th>\r\n        <th>Sucursal</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 21 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
     foreach (var e in empleados)
    {

#line default
#line hidden
            BeginContext(489, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(520, 4, false);
#line 24 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
           Write(e.Id);

#line default
#line hidden
            EndContext();
            BeginContext(524, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(548, 9, false);
#line 25 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
           Write(e.Nombres);

#line default
#line hidden
            EndContext();
            BeginContext(557, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(581, 11, false);
#line 26 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
           Write(e.Apellidos);

#line default
#line hidden
            EndContext();
            BeginContext(592, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(616, 17, false);
#line 27 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
           Write(e.Sucursal.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(633, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "F:\Programacion 1\Panaderia-Sem13\Views\Home\Empleados.cshtml"
    }

#line default
#line hidden
            BeginContext(662, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591