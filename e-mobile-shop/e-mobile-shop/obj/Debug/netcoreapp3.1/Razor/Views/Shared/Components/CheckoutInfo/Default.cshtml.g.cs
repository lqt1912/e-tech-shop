#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0c56e73dae99d21caa4c2b2b4641e3dde3d3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CheckoutInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CheckoutInfo/Default.cshtml")]
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
#line 1 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\_ViewImports.cshtml"
using e_mobile_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\_ViewImports.cshtml"
using e_mobile_shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
using e_mobile_shop.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0c56e73dae99d21caa4c2b2b4641e3dde3d3b9", @"/Views/Shared/Components/CheckoutInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CheckoutInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetUsers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 row  m-2 border"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" col-12 btn btn-block btn-warning m-0 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <div class=""row "">
            <div class=""col-12 p-0 m-0"">
                <input placeholder=""Nhập mã giảm giá"" type=""text"" style=""width: 100%"" class=""m-2 p-2"" />
            </div>
            <div class=""col-12 row  "">
                <div class=""col-12 text-center ""> Nhập thông tin khách hàng </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e0c56e73dae99d21caa4c2b2b4641e3dde3d3b97322", async() => {
                WriteLiteral("\n                    <div class=\"col-6 p-1 \">\n                        <input disabled style=\"width: 100%\"");
                BeginWriteAttribute("value", " value=\"", 773, "\"", 796, 1);
#nullable restore
#line 19 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 781, Model[0].HoTen, 781, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                    <div class=\"col-6 p-1 \">\n                        <input disabled style=\"width: 100%\" placeholder=\"Điện thoại \"");
                BeginWriteAttribute("value", " value=\"", 958, "\"", 987, 1);
#nullable restore
#line 22 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 966, Model[0].PhoneNumber, 966, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                    <div class=\"col-12 p-1 pt-2\">\n                        <input disabled style=\"width: 100%\" name=\"DiaChi\" placeholder=\"Địa chỉ giao hàng \"");
                BeginWriteAttribute("value", " value=\"", 1175, "\"", 1199, 1);
#nullable restore
#line 25 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 1183, Model[0].DiaChi, 1183, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                    <div class=\"col-12 p-1 pt-2\">\n                        <input style=\"width: 100%\" name=\"GhiChu\" placeholder=\"Yêu cầu khác  \" />\n                    </div>\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1445, "\"", 1465, 1);
#nullable restore
#line 30 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 1453, Model[0].Id, 1453, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1520, "\"", 1546, 1);
#nullable restore
#line 31 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 1528, ViewBag.ThanhTien, 1528, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ThanhTien\" />\n\n\n                    <button type=\"submit\" class=\" col-12 btn btn-block btn-success m-0 mt-2\" style=\"border-radius:0; color: white\"> Thanh toán  </button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            </div>\n");
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 43 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div class=""row "">
        <div class=""col-12 p-0 m-0"">
            <input placeholder=""Nhập mã giảm giá"" type=""text"" style=""width: 100%"" class=""m-2 p-2"" />
        </div>
        <div class=""col-12 row  "">
            <div class=""col-12 text-center ""> Nhập thông tin khách hàng </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e0c56e73dae99d21caa4c2b2b4641e3dde3d3b913019", async() => {
                WriteLiteral(@"
                <div class=""col-6 p-1 "">
                    <input style=""width: 100%"" placeholder=""Họ và tên"" name=""HoTen"" />
                </div>
                <div class=""col-6 p-1 "">
                    <input style=""width: 100%"" placeholder=""Điện thoại "" name=""DienThoai"" />
                </div>
                <div class=""col-12 p-1 pt-2"">
                    <input style=""width: 100%"" placeholder=""Địa chỉ giao hàng "" name=""DiaChi"" />
                </div>
                <div class=""col-12 p-1 pt-2"">
                    <input type=""email"" style=""width: 100%"" placeholder=""Email  "" name=""Email"" />
                </div>
                <div class=""col-12 p-1 pt-2"">
                    <input style=""width: 100%"" placeholder=""Yêu cầu khác  "" name=""GhiChu"" />
                </div>
                <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 3350, "\"", 3376, 1);
#nullable restore
#line 69 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
WriteAttributeValue("", 3358, ViewBag.ThanhTien, 3358, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ThanhTien\" />\n                <button type=\"submit\" class=\" col-12 btn btn-block btn-success m-0 mt-2\" style=\"border-radius:0; color: white\"> Thanh toán  </button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </div>\n        <div class=\"col-12 text-center \"> hoặc </div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e0c56e73dae99d21caa4c2b2b4641e3dde3d3b916520", async() => {
                WriteLiteral(" Đăng nhập để lấy thông tin ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n       \n    </div>\n</div>\n");
#nullable restore
#line 79 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Shared\Components\CheckoutInfo\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
