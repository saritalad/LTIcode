#pragma checksum "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645bb165ecee578cdb7495706ab9f5befead289d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DarkLayout), @"mvc.1.0.view", @"/Views/Shared/_DarkLayout.cshtml")]
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
#line 1 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\_ViewImports.cshtml"
using MVC_LayOut_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\_ViewImports.cshtml"
using MVC_LayOut_Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645bb165ecee578cdb7495706ab9f5befead289d", @"/Views/Shared/_DarkLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f0f05a762ca094334451c644f794ff43608042", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__DarkLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:burlywood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645bb165ecee578cdb7495706ab9f5befead289d4544", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 6 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645bb165ecee578cdb7495706ab9f5befead289d5817", async() => {
                WriteLiteral("\r\n\r\n    <!-- Header -->\r\n    <header>\r\n        <h1 style=\"text-align:center; color:bisque\">My Dark Layout Page</h1>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "645bb165ecee578cdb7495706ab9f5befead289d6208", async() => {
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
                WriteLiteral("\r\n    </header>\r\n    <!-- End of Header -->\r\n    <!-- Left Sidebar -->\r\n    <nav>\r\n        <h3>Navigation</h3>\r\n        ");
#nullable restore
#line 19 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(Html.ActionLink("About", "About"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";<br />\r\n        ");
#nullable restore
#line 20 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(Html.ActionLink("Contact", "Contact"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";<br />\r\n        ");
#nullable restore
#line 21 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(Html.ActionLink("Enquiry", "Enquiry"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";<br />\r\n        ");
#nullable restore
#line 22 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(Html.ActionLink("Home", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";<br />\r\n        ");
#nullable restore
#line 23 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(Html.ActionLink("Purchase", "Purchase"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";<br />\r\n    </nav>\r\n    <!-- End of Left Sidebar -->\r\n    <!-- Content Body -->\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 28 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div style=\"background-color:rebeccapurple; color:antiquewhite; font-weight:bold\">\r\n        ");
#nullable restore
#line 32 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
   Write(RenderSection("Note", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <!-- End of Content Body -->\r\n    <!-- Footer -->\r\n    <footer>\r\n        <h4>I am Footer.</h4>\r\n        <div style=\"background-color:red; color:aliceblue\">");
#nullable restore
#line 38 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
                                                      Write(RenderSection("Footer", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    </footer>\r\n    ");
#nullable restore
#line 40 "E:\LTI_MVC\MVC_LayOut_Demo\MVC_LayOut_Demo\Views\Shared\_DarkLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Style -->
    <style>
        header {
            height: 100px;
            width: 100%;
            background-color: red;
        }

        nav {
            float: left;
            width: 200px;
            height: 250px;
            background-color: darkgoldenrod;
        }

        .content {
            background-color: aliceblue;
            padding: 20px;
        }

        footer {
            background-color: green;
            width: 100%;
            height: 50px;
            float: right;
            text-align: center;
        }
    </style>
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
