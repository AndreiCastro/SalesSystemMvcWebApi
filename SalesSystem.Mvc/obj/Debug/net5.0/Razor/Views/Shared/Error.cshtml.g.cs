#pragma checksum "C:\Users\andrei\source\repos\MyProjects\SalesSystem\SalesSystem.Mvc\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27f0da809b7b85d5406a921e5b37d6c93220c4961151bda9d4b83c32177f8222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\andrei\source\repos\MyProjects\SalesSystem\SalesSystem.Mvc\Views\_ViewImports.cshtml"
using SalesSystem.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andrei\source\repos\MyProjects\SalesSystem\SalesSystem.Mvc\Views\_ViewImports.cshtml"
using SalesSystem.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"27f0da809b7b85d5406a921e5b37d6c93220c4961151bda9d4b83c32177f8222", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"598cf9611eedda94d5b1f1482ed233c6791fd3be427603611506e06366bff328", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\andrei\source\repos\MyProjects\SalesSystem\SalesSystem.Mvc\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<meta charset=""utf-8"" />

<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-md-8"">

            <div class=""text-center"">
                <h3 class=""display-3"">Erro</h3>
            </div>
            <br />

            <div class=""text-left"">
                <h2>Ocorreu um erro enquanto sua requisição foi processada.</h2>
                <br />
                <br />

                <h3 class=""text-danger"">Erro: <i>");
#nullable restore
#line 21 "C:\Users\andrei\source\repos\MyProjects\SalesSystem\SalesSystem.Mvc\Views\Shared\Error.cshtml"
                                            Write(ViewBag.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h3>\r\n                <br />\r\n                <br />\r\n\r\n                <p><b>Contate o Administrador do Sistema</b></p>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
