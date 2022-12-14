#pragma checksum "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7331eb019042279be4332f88ddac1a38db05caab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Iletisim), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Iletisim.cshtml")]
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
#line 1 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
using SeyahatWebProje.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7331eb019042279be4332f88ddac1a38db05caab", @"/Areas/Admin/Views/Admin/Iletisim.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Admin_Iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<iletisim>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
  
    ViewData["Title"] = "Blog";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card mb-4"">
    <div class=""card-header"">
        <svg class=""svg-inline--fa fa-table me-1"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""table"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M448 32C483.3 32 512 60.65 512 96V416C512 451.3 483.3 480 448 480H64C28.65 480 0 451.3 0 416V96C0 60.65 28.65 32 64 32H448zM224 256V160H64V256H224zM64 320V416H224V320H64zM288 416H448V320H288V416zM448 256V160H288V256H448z""></path></svg><!-- <i class=""fas fa-table me-1""></i> Font Awesome fontawesome.com -->
        Iletisim Listesi
    </div>

    <div class=""card-body"">
        <div class=""dataTable-wrapper dataTable-loading no-footer sortable searchable fixed-columns"">
            <div class=""dataTable-top"">
            </div>
            <div class=""dataTable-container"">
                <table id=""datatablesSimple"" class=""dataTable-table"">
                    <thead>
                        <tr>
           ");
            WriteLiteral(@"                 <th>ID</th>
                            <th>Ad Soyad</th>
                            <th>Mail</th>
                            <th>Konu</th>
                            <th>Mesaj</th>
                            <th>Sil</th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 32 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                               Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                               Write(item.Konu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                               Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1947, "\"", 1981, 2);
            WriteAttributeValue("", 1954, "/Admin/IletisimSil/", 1954, 19, true);
#nullable restore
#line 40 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
WriteAttributeValue("", 1973, item.ID, 1973, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\Iletisim.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<iletisim>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
