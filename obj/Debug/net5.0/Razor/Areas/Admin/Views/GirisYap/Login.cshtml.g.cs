#pragma checksum "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c32e78a0c08eae4d616c03fd36181c7fb25f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GirisYap_Login), @"mvc.1.0.view", @"/Areas/Admin/Views/GirisYap/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c32e78a0c08eae4d616c03fd36181c7fb25f23", @"/Areas/Admin/Views/GirisYap/Login.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_GirisYap_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeyahatWebProje.Models.Siniflar.Admin>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/area/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79c32e78a0c08eae4d616c03fd36181c7fb25f234338", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <title>Yönetim Paneli</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79c32e78a0c08eae4d616c03fd36181c7fb25f234738", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79c32e78a0c08eae4d616c03fd36181c7fb25f236621", async() => {
                WriteLiteral(@"

        <div id=""layoutAuthentication_content"">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-5"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Admin Giriş Sayfası</h3></div>
                                <div class=""card-body"">
");
#nullable restore
#line 25 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml"
                                      using(Html.BeginForm("Login", "GirisYap", FormMethod.Post))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""form-floating mb-3"">
                                            <input class=""form-control"" name=""Kullanici"" type=""text"" placeholder=""Kullanıcı Adı"" />
                                            <label for=""inputEmail"">Kullanıcı Adı</label>
                                            ");
#nullable restore
#line 30 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml"
                                       Write(Html.ValidationMessageFor(m=>m.Kullanici));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
                                    </div>
                                        <div class=""form-floating mb-3"">
                                            <input class=""form-control"" name=""Sifre"" type=""password"" placeholder=""Şifre"" />
                                            <label for=""inputPassword"">Şifre</label>
                                        ");
#nullable restore
#line 35 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml"
                                   Write(Html.ValidationMessageFor(m=>m.Sifre));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>
                                    <div class=""d-flex align-items-center justify-content-between mt-4 mb-0"">
                                         <button type=""submit"" class=""btn btn-primary"">Giriş Yap</button>
                                    </div>
");
#nullable restore
#line 40 "C:\Users\Engin\source\repos\SeyahatWebProje\SeyahatWebProje\Areas\Admin\Views\GirisYap\Login.cshtml"
                                   
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </main>\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeyahatWebProje.Models.Siniflar.Admin> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591