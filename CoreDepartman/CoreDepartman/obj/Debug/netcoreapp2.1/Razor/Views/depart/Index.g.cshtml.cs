#pragma checksum "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca2fe1190451e2e783d32da1de603398dff88dc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_depart_Index), @"mvc.1.0.view", @"/Views/depart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/depart/Index.cshtml", typeof(AspNetCore.Views_depart_Index))]
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
#line 1 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2fe1190451e2e783d32da1de603398dff88dc3", @"/Views/depart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_depart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<departmanlar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
            BeginContext(148, 193, true);
            WriteLiteral("\r\n<br/>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Departman</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
            BeginContext(379, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(402, 4, false);
#line 20 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
       Write(x.id);

#line default
#line hidden
            EndContext();
            BeginContext(406, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(426, 13, false);
#line 21 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
       Write(x.departmanAd);

#line default
#line hidden
            EndContext();
            BeginContext(439, 21, true);
            WriteLiteral("</td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 460, "\"", 493, 2);
            WriteAttributeValue("", 467, "/depart/DepartmanSil/", 467, 21, true);
#line 22 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
WriteAttributeValue("", 488, x.id, 488, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(494, 52, true);
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 546, "\"", 581, 2);
            WriteAttributeValue("", 553, "/depart/DepartmanGetir/", 553, 23, true);
#line 23 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
WriteAttributeValue("", 576, x.id, 576, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(582, 54, true);
            WriteLiteral(" class=\"btn btn-success\">Güncelle</td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 636, "\"", 667, 2);
            WriteAttributeValue("", 643, "/depart/BirimDetay/", 643, 19, true);
#line 24 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
WriteAttributeValue("", 662, x.id, 662, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(668, 90, true);
            WriteLiteral(" class=\"btn btn-default\" style=\"background-color:burlywood\">Detaylar</a></td>\r\n    </tr>\r\n");
            EndContext();
#line 26 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\depart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(765, 89, true);
            WriteLiteral("</table>\r\n<a href=\"/depart/YeniDepartman\" class=\"btn btn-primary\">Yeni Departman Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<departmanlar>> Html { get; private set; }
    }
}
#pragma warning restore 1591