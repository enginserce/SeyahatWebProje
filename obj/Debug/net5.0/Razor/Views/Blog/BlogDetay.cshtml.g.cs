#pragma checksum "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e8269c4b0cceefb8e407ecdd6d90adcbcb5375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetay), @"mvc.1.0.view", @"/Views/Blog/BlogDetay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e8269c4b0cceefb8e407ecdd6d90adcbcb5375", @"/Views/Blog/BlogDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c76b0fed6adb9d22c9d3ee55012efb1f5e5fb9f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeyahatWebProje.Models.Siniflar.BlogYorum>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kullanici.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "YorumYap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
  
    ViewData["Title"] = "Blog Detay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"ftco-section ftco-no-pt ftco-no-pb\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n          <div class=\"col-lg-8 order-md-last ftco-animate py-md-5 mt-md-5 fadeInUp ftco-animated\">\r\n");
#nullable restore
#line 11 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
               foreach (var item in Model.deger1)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"mb-3\">");
#nullable restore
#line 13 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                        Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>\r\n              <img");
            BeginWriteAttribute("src", " src=\"", 454, "\"", 475, 1);
#nullable restore
#line 15 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
WriteAttributeValue("", 460, item.BlogImage, 460, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 476, "\"", 482, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n            </p>\r\n            <p>");
#nullable restore
#line 17 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
          Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("            <div class=\"pt-5 mt-5\">\r\n              <h3 class=\"mb-5\">Yorumlar</h3>\r\n              <ul class=\"comment-list\">\r\n");
#nullable restore
#line 22 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                 foreach (var yorum in Model.deger2)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"comment\">\r\n                  <div class=\"vcard bio\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7e8269c4b0cceefb8e407ecdd6d90adcbcb53756740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"comment-body\">\r\n                      \r\n                    <h3>");
#nullable restore
#line 30 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                   Write(yorum.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"meta\"></div>\r\n                    <p>");
#nullable restore
#line 32 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                  Write(yorum.Yorum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                </li>\r\n");
#nullable restore
#line 35 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                  } 

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\r\n                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7e8269c4b0cceefb8e407ecdd6d90adcbcb53758875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          </div>
          
          <!-- .col-md-8 -->
          <div class=""col-lg-4 sidebar ftco-animate bg-light py-md-5 fadeInUp ftco-animated"">
            <div class=""sidebar-box ftco-animate fadeInUp ftco-animated"">
              <h3>Son G??nderiler</h3>
");
#nullable restore
#line 46 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
               foreach (var item in Model.deger3)
			    {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"block-21 mb-4 d-flex\">\r\n                <a class=\"blog-img mr-4\"");
            BeginWriteAttribute("style", " style=\"", 1757, "\"", 1804, 4);
            WriteAttributeValue("", 1765, "background-image:", 1765, 17, true);
            WriteAttributeValue(" ", 1782, "url(", 1783, 5, true);
#nullable restore
#line 49 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
WriteAttributeValue("", 1787, item.BlogImage, 1787, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1802, ");", 1802, 2, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <div class=\"text\">\r\n                                <h3 class=\"heading\"><a");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1933, 2);
            WriteAttributeValue("", 1909, "/Blog/BlogDetay/", 1909, 16, true);
#nullable restore
#line 51 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
WriteAttributeValue("", 1925, item.ID, 1925, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                                                                                  Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                  <div class=\"meta\">\r\n                                    <div><a href=\"#\"><span class=\"icon-calendar\"></span>");
#nullable restore
#line 53 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                                                                                   Write(item.Tarih.ToString("dd MMMM yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n");
#nullable restore
#line 57 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 59 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
             foreach (var item in Model.deger4)
                {   

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"sidebar-box ftco-animate fadeInUp ftco-animated\">\r\n              <h3>Hakk??m??zda</h3>\r\n              <p>");
#nullable restore
#line 63 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
            Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 65 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Views\Blog\BlogDetay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </div>\r\n        </div>\r\n      </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeyahatWebProje.Models.Siniflar.BlogYorum> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
