#pragma checksum "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0bc09000476d3d8b378f16774efed64c173649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_PersonelGetir), @"mvc.1.0.view", @"/Views/Personelim/PersonelGetir.cshtml")]
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
#line 1 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0bc09000476d3d8b378f16774efed64c173649", @"/Views/Personelim/PersonelGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_Personelim_PersonelGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDepartman.Models.Personel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Personelim/PersonelGuncelle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
  
    ViewData["Title"] = "PersonelGetir";
    Layout = "~/Views/Shared/_LayoutD.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac0bc09000476d3d8b378f16774efed64c1736494370", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.LabelFor(x => x.PersonelID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonelID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 14 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.LabelFor(x => x.PersonelAD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonelAD, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 17 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.LabelFor(x => x.PersonelSoyad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonelSoyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.LabelFor(x => x.PersonelSehir));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonelSehir, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n\r\n    Departman\r\n    ");
#nullable restore
#line 27 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\PersonelGetir.cshtml"
Write(Html.DropDownListFor(x => x.Birim.BirimAD, (List<SelectListItem>)ViewBag.dgrr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n\r\n\r\n    <button class=\"btn btn-info\"> Personel Güncelle</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDepartman.Models.Personel> Html { get; private set; }
    }
}
#pragma warning restore 1591