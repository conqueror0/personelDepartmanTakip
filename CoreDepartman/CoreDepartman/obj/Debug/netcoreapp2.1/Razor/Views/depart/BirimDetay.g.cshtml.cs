#pragma checksum "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8379d94abf052214f166cd768c6e7d87f6c5fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_depart_BirimDetay), @"mvc.1.0.view", @"/Views/depart/BirimDetay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/depart/BirimDetay.cshtml", typeof(AspNetCore.Views_depart_BirimDetay))]
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
#line 1 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8379d94abf052214f166cd768c6e7d87f6c5fb", @"/Views/depart/BirimDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_depart_BirimDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
  
    ViewData["Title"] = "BirimDetay";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
            BeginContext(149, 13, true);
            WriteLiteral("\r\n<br/>\r\n<h2>");
            EndContext();
            BeginContext(163, 11, false);
#line 9 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
Write(ViewBag.brm);

#line default
#line hidden
            EndContext();
            BeginContext(174, 234, true);
            WriteLiteral("</h2>\r\n<br/>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n        <th>İşe Giriş Tarihi</th>\r\n        <th>Yıllık İzin Hakkı</th>\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
            BeginContext(446, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(477, 7, false);
#line 23 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.perid);

#line default
#line hidden
            EndContext();
            BeginContext(484, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(508, 4, false);
#line 24 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.ad);

#line default
#line hidden
            EndContext();
            BeginContext(512, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(536, 7, false);
#line 25 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.soyad);

#line default
#line hidden
            EndContext();
            BeginContext(543, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(567, 7, false);
#line 26 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.şehir);

#line default
#line hidden
            EndContext();
            BeginContext(574, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(598, 16, false);
#line 27 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.iseGirisTarihi);

#line default
#line hidden
            EndContext();
            BeginContext(614, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(638, 17, false);
#line 28 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
           Write(x.yillikizinhakki);

#line default
#line hidden
            EndContext();
            BeginContext(655, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\BirimDetay.cshtml"
    }

#line default
#line hidden
            BeginContext(684, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
