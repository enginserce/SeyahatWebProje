#pragma checksum "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28dead040f570f38fa9ecb3ddc4f57ce7b981c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_HakkimizdaGetir), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/HakkimizdaGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dead040f570f38fa9ecb3ddc4f57ce7b981c19", @"/Areas/Admin/Views/Admin/HakkimizdaGetir.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Admin_HakkimizdaGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeyahatWebProje.Models.Siniflar.Hakkimizda>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
  
    ViewData["Title"] = "BlogGetir";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card mb-4"">
    <div class=""card-header"">
        <svg class=""svg-inline--fa fa-table me-1"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""table"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M448 32C483.3 32 512 60.65 512 96V416C512 451.3 483.3 480 448 480H64C28.65 480 0 451.3 0 416V96C0 60.65 28.65 32 64 32H448zM224 256V160H64V256H224zM64 320V416H224V320H64zM288 416H448V320H288V416zM448 256V160H288V256H448z""></path></svg><!-- <i class=""fas fa-table me-1""></i> Font Awesome fontawesome.com -->
        Hakkımızda Güncelle
    </div>

    <div class=""card-body"">
");
#nullable restore
#line 15 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
 using (Html.BeginForm("HakkimizdaGuncelle", "Admin", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.LabelFor(x=>x.ID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.TextBoxFor(x=>x.ID, new {@class="form-control", @readonly ="readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.LabelFor(x=>x.imageURL));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.TextBoxFor(x=>x.imageURL, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.LabelFor(x=>x.Aciklama));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
Write(Html.TextAreaFor(x=>x.Aciklama,15,1, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 27 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\Admin\HakkimizdaGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeyahatWebProje.Models.Siniflar.Hakkimizda> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
