#pragma checksum "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37d274bc6a62daea9329c18f1eb1c529f1186fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_depart_DepartmanGetir), @"mvc.1.0.view", @"/Views/depart/DepartmanGetir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/depart/DepartmanGetir.cshtml", typeof(AspNetCore.Views_depart_DepartmanGetir))]
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
#line 1 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman;

#line default
#line hidden
#line 2 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a37d274bc6a62daea9329c18f1eb1c529f1186fd", @"/Views/depart/DepartmanGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_depart_DepartmanGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDepartman.Models.departmanlar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml"
  
    ViewData["Title"] = "DepartmanGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
            BeginContext(143, 9, true);
            WriteLiteral("\r\n<br/>\r\n");
            EndContext();
#line 8 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml"
 using (Html.BeginForm("DepartmanGuncelle", "depart", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(228, 25, true);
            WriteLiteral("    <b>Departman ID</b>\r\n");
            EndContext();
            BeginContext(258, 59, false);
#line 11 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml"
Write(Html.TextBoxFor(x => x.id, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(319, 38, true);
            WriteLiteral("    <br />\r\n    <b>Departman Adı</b>\r\n");
            EndContext();
            BeginContext(362, 68, false);
#line 14 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml"
Write(Html.TextBoxFor(x => x.departmanAd, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(432, 124, true);
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-default\" style=\"background-color:#ff6a00\"; color:black;>Departman Güncelle</button>\r\n");
            EndContext();
#line 17 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\DepartmanGetir.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDepartman.Models.departmanlar> Html { get; private set; }
    }
}
#pragma warning restore 1591
