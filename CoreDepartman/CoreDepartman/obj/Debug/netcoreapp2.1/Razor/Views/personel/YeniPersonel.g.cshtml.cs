#pragma checksum "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65678303c6716d15d167b72520d526110336f3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_personel_YeniPersonel), @"mvc.1.0.view", @"/Views/personel/YeniPersonel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/personel/YeniPersonel.cshtml", typeof(AspNetCore.Views_personel_YeniPersonel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65678303c6716d15d167b72520d526110336f3b3", @"/Views/personel/YeniPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_personel_YeniPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDepartman.Models.personal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
  
    ViewData["Title"] = "YeniPersonel";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
            BeginContext(137, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(147, 854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e6c0e40cf34bbab885d909e91f487c", async() => {
                BeginContext(186, 33, true);
                WriteLiteral("\r\n\r\n    <b>Personel Adı</b>\r\n    ");
                EndContext();
                BeginContext(220, 59, false);
#line 11 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.TextBoxFor(x => x.ad, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(279, 48, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <b>Personel Soyadı</b>\r\n    ");
                EndContext();
                BeginContext(328, 62, false);
#line 15 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.TextBoxFor(x => x.soyad, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(390, 47, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <b>Personel Şehri</b>\r\n    ");
                EndContext();
                BeginContext(438, 62, false);
#line 19 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.TextBoxFor(x => x.şehir, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(500, 52, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <b>Personel Departmanı</b>\r\n    ");
                EndContext();
                BeginContext(553, 106, false);
#line 23 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.DropDownListFor(x=>x.departmanlar.id,(List<SelectListItem>)ViewBag.dgr,new {@class ="form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(659, 58, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <b>Personel İşe Giriş Tarihi</b>\r\n    ");
                EndContext();
                BeginContext(718, 71, false);
#line 27 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.TextBoxFor(x => x.iseGirisTarihi, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(789, 59, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <b>Personel Yıllık İzin Hakkı</b>\r\n    ");
                EndContext();
                BeginContext(849, 72, false);
#line 31 "C:\Users\msi\Desktop\.NET Projeleri\CoreDepartman\CoreDepartman\Views\personel\YeniPersonel.cshtml"
Write(Html.TextBoxFor(x => x.yillikizinhakki, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(921, 73, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    <button class=\"btn btn-info\">Personel Ekle</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDepartman.Models.personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
