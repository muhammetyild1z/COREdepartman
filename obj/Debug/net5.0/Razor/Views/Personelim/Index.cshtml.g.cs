#pragma checksum "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a87a35f4736911ed47d080be30d97c818992fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_Index), @"mvc.1.0.view", @"/Views/Personelim/Index.cshtml")]
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
#line 1 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a87a35f4736911ed47d080be30d97c818992fe", @"/Views/Personelim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_Personelim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutD.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n        <th>Departman</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> ");
#nullable restore
#line 20 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
    Write(item.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> ");
#nullable restore
#line 21 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
    Write(item.PersonelAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> ");
#nullable restore
#line 22 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
    Write(item.PersonelSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> ");
#nullable restore
#line 23 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
    Write(item.PersonelSehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
   Write(item.Birim.BirimAD);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 576, "\"", 623, 2);
            WriteAttributeValue("", 583, "/Personelim/PersonelSil/", 583, 24, true);
#nullable restore
#line 25 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 607, item.PersonelID, 607, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">sil</a></td>\r\n    <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 722, 2);
            WriteAttributeValue("", 680, "/Personelim/PersonelGetir/", 680, 26, true);
#nullable restore
#line 26 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 706, item.PersonelID, 706, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 28 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreDepartman\CoreDepartman\Views\Personelim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<td><a class=\"btn btn-secondary\" href=\"/Personelim/PersonelEkle\">Yeni Personel</a></td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591