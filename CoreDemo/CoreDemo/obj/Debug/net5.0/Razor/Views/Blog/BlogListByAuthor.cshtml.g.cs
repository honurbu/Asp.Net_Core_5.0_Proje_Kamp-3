#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fb59e3b3ac52645011ed9d3bc5577c79d4b58a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByAuthor), @"mvc.1.0.view", @"/Views/Blog/BlogListByAuthor.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fb59e3b3ac52645011ed9d3bc5577c79d4b58a", @"/Views/Blog/BlogListByAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
  
    ViewData["Title"] = "BlogListByAuthor";
    Layout = "~/Views/Shared/AuthorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1><i>YAZARIN BLOGLARI</i></h1>

<table class=""table table-bordered"">

    <tr>
        <th><i> Blog ID </i></th>
        <th><i> Blog Başlığı </i></th>
        <th><i> Oluşturulma Tarihi </i></th>
        <th><i> Kategori </i></th>
        <th><i> Durumu </i></th>
        <th><i> Sil </i></th>
        <th><i> Düzenle </i></th>

    </tr>

");
#nullable restore
#line 24 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 27 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
            Write(((DateTime) item.BlogCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n");
#nullable restore
#line 33 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
                 if (item.BlogStatus)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-success\">Aktif</span>\r\n");
#nullable restore
#line 36 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-secondary\">Pasif</span>\r\n");
#nullable restore
#line 40 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1144, 2);
            WriteAttributeValue("", 1115, "/Blog/DeleteBlog/", 1115, 17, true);
#nullable restore
#line 43 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 1132, item.BlogID, 1132, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Silmek İstediğinize Emin Misiniz ?\')\"> SİL </a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1300, 2);
            WriteAttributeValue("", 1273, "/Blog/EditBlog/", 1273, 15, true);
#nullable restore
#line 44 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 1288, item.BlogID, 1288, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\"> DÜZENLE</a> </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Blog\BlogListByAuthor.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Blog/BlogAdd\" class=\"btn btn-primary\"> Yeni Blog Oluştur</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591