#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78103b1c8b46c273edb4d54c00b28dedd8a26c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StatusMessages), @"mvc.1.0.view", @"/Views/Shared/_StatusMessages.cshtml")]
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
#line 1 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\_ViewImports.cshtml"
using e_mobile_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\_ViewImports.cshtml"
using e_mobile_shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78103b1c8b46c273edb4d54c00b28dedd8a26c19", @"/Views/Shared/_StatusMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StatusMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
  
    var type = (string)TempData["_alert.type"];
    var title = (string)TempData["_alert.title"];
    var body = (string)TempData["_alert.body"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
 if (!string.IsNullOrEmpty(type))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 202, "\"", 245, 4);
            WriteAttributeValue("", 210, "alert", 210, 5, true);
            WriteAttributeValue(" ", 215, "alert-", 216, 7, true);
#nullable restore
#line 8 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
WriteAttributeValue("", 222, type, 222, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 227, "alert-dismissible", 228, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        <strong>");
#nullable restore
#line 10 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
           Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 10 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
                           Write(body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\Shared\_StatusMessages.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
