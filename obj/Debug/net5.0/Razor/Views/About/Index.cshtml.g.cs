#pragma checksum "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eebb0438adff9619c3efdcc3a76140d92319e65c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\_ViewImports.cshtml"
using SeyahatWebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\_ViewImports.cshtml"
using SeyahatWebProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
using SeyahatWebProje.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebb0438adff9619c3efdcc3a76140d92319e65c", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c76b0fed6adb9d22c9d3ee55012efb1f5e5fb9f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hakkimizda>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
  
	ViewData["Title"] = "Hakkımızda";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"ftco-counter img\" id=\"section-counter\">\r\n    \t<div class=\"container\">\r\n    \t\t<div class=\"row d-flex\">\r\n");
#nullable restore
#line 11 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
                 foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("    \t\t\t<div class=\"col-md-6 d-flex\">\r\n    \t\t\t\t<div class=\"img d-flex align-self-stretch\"");
            BeginWriteAttribute("style", " style=\"", 375, "\"", 420, 3);
            WriteAttributeValue("", 383, "background-image:url(", 383, 21, true);
#nullable restore
#line 14 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
WriteAttributeValue("", 404, item.imageURL, 404, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 418, ");", 418, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    \t\t\t</div>\r\n    \t\t\t<div class=\"col-md-6 pl-md-5 py-5\">\r\n    \t\t\t\t<div class=\"row justify-content-start pb-3\">\r\n\t\t          <div class=\"col-md-12 heading-section ftco-animate fadeInUp ftco-animated\">\r\n                    <p>");
#nullable restore
#line 19 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
                  Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t          </div>\r\n\t\t        </div>\r\n\t        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    \t</div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hakkimizda>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
