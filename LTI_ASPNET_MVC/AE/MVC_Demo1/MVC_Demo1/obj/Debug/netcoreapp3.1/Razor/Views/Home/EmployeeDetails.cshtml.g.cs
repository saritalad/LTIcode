#pragma checksum "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\Home\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a2de9fba4f24a3269f4e1ef4ebae211ea545a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmployeeDetails), @"mvc.1.0.view", @"/Views/Home/EmployeeDetails.cshtml")]
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
#line 1 "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\_ViewImports.cshtml"
using MVC_Demo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\_ViewImports.cshtml"
using MVC_Demo1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a2de9fba4f24a3269f4e1ef4ebae211ea545a3", @"/Views/Home/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3628059621fa127e4b38d7cdf5f9857dc4a0da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-left\">\r\n\r\nID ");
#nullable restore
#line 3 "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\Home\EmployeeDetails.cshtml"
Write(ViewBag.emp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nName:");
#nullable restore
#line 4 "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\Home\EmployeeDetails.cshtml"
Write(ViewBag.emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nDepartment:");
#nullable restore
#line 5 "E:\LTI\LTI_ASPNET_MVC\AE\MVC_Demo1\MVC_Demo1\Views\Home\EmployeeDetails.cshtml"
      Write(ViewBag.emp.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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