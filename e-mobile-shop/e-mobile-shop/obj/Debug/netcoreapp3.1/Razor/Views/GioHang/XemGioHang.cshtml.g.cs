#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7bccdf4293e2fc9aca901b2fed99b5ac90c874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_XemGioHang), @"mvc.1.0.view", @"/Views/GioHang/XemGioHang.cshtml")]
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
#nullable restore
#line 7 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
using e_mobile_shop.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7bccdf4293e2fc9aca901b2fed99b5ac90c874", @"/Views/GioHang/XemGioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_XemGioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "i", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-outline-primary mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveVoucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XemGioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("voucher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
   ViewData["Title"] = "XemGioHang";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var context = new ClientDbContext();
    var dataAccess = new DataAccess();
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td, th {
        text-align: center;
    }

    .row {
        margin: 0;
        padding: 0;
    }

    .col-2 {
        text-align: center;
    }

    .col-5 {
        text-align: left;
    }

    .tooltip {
        border-bottom: 1px dotted black; /* If you want dots under the hoverable text */
        display: inline-block;
        position: relative;
    }

        /* Tooltip text */

        .tooltip .tooltiptext {
            background-color: black;
            -ms-border-radius: 6px;
            border-radius: 6px;
            color: #fff;
            padding: 5px 0;
            /* Position the tooltip text - see examples below! */
            position: absolute;
            text-align: center;
            visibility: hidden;
            width: 120px;
            z-index: 1;
        }

        /* Show the tooltip text when you mouse over the tooltip container */

        .tooltip:hover .tooltiptext {
            visibility: visible;
        }
</style>

");
#nullable restore
#line 59 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
Write(Html.Partial("_StatusMessages"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3 class=\"tittle-w3l text-center mb-lg-5 mb-sm-4 mb-2 mt-2\">\n    <span>G</span>iỏ hàng\n</h3>\n<div class=\"container p-0\">\n    <div class=\"row pt-1\">\n        <div class=\"col-md-8 col-12 p-0 \">\n");
#nullable restore
#line 66 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
             for (var i = 0; i < ViewBag.GioHang.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row border m-1 \">\n    <div class=\"col-3 \" style=\"margin: auto; text-align: center\">\n        <img");
            BeginWriteAttribute("src", " src=", 1732, "", 1829, 1);
#nullable restore
#line 70 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 1737, Url.Content("~/ProductAvatar/" + dataAccess.GetSanPham(ViewBag.GioHang[i].MaSp).AnhDaiDien), 1737, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 70px; max-width: 70px;\" />\n    </div>\n    <div class=\"col-5 \">\n        <div class=\"p-2\">\n            <strong> ");
#nullable restore
#line 74 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                Write(dataAccess.GetSanPham(ViewBag.GioHang[i].MaSp).TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\n        </div>\n        <div class=\"p-2 border d-inline-flex mb-1\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7bccdf4293e2fc9aca901b2fed99b5ac90c87411142", async() => {
                WriteLiteral("\n                <label class=\"pr-2\"> Số lượng </label>\n                <input disabled");
                BeginWriteAttribute("name", " name=\"", 2293, "\"", 2310, 2);
                WriteAttributeValue("", 2300, "SoLuong-", 2300, 8, true);
#nullable restore
#line 79 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2308, i, 2308, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2311, "\"", 2326, 2);
                WriteAttributeValue("", 2316, "SoLuong+", 2316, 8, true);
#nullable restore
#line 79 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2324, i, 2324, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" max=\"10\" style=\"width: 35px\"");
                BeginWriteAttribute("value", " value=\"", 2356, "\"", 2391, 1);
#nullable restore
#line 79 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2364, ViewBag.GioHang[i].SoLuong, 2364, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\n                <button data-toggle=\"tooltip\" data-placement=\"left\" title=\"Lưu \" class=\"btn btn-primary radius-0 p-1 pl-2 pr-2 ml-2 \"");
                BeginWriteAttribute("id", " id=\"", 2543, "\"", 2562, 2);
                WriteAttributeValue("", 2548, "link-update-", 2548, 12, true);
#nullable restore
#line 80 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2560, i, 2560, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none; font-size: 10px;\" type=\"submit\"> Lưu</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                                                                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <button data-toggle=\"tooltip\" data-placement=\"left\" title=\"Chỉnh sửa \"");
            BeginWriteAttribute("onclick", " onclick=\"", 2734, "\"", 2759, 3);
            WriteAttributeValue("", 2744, "AllowUpdate(", 2744, 12, true);
#nullable restore
#line 82 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2756, i, 2756, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2758, ")", 2758, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2760, "\"", 2778, 2);
            WriteAttributeValue("", 2765, "btn-update-", 2765, 11, true);
#nullable restore
#line 82 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
WriteAttributeValue("", 2776, i, 2776, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary p-0 pl-2 pr-2 ml-2 radius-0"">
                <i class=""fas fa-pencil-alt""></i>
            </button>
        </div>
    </div>
    <div class=""col-4  d-flex justify-content-around flex-column"" style=""text-align: right"">
        <div class=""p-2"">
            <strong style=""font-size: 13px"">
                ");
#nullable restore
#line 90 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
            Write((context.SanPham.Find(ViewBag.GioHang[i].MaSp).GiaGoc * ViewBag.GioHang[i].SoLuong).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </strong>\n        </div>\n        <div class=\"p-2 d-flex  justify-content-between\" style=\"font-size: 12px\">\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7bccdf4293e2fc9aca901b2fed99b5ac90c87418199", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>      ");
#nullable restore
#line 98 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-4 col-12 border"">
            <div class=""row p-2 m-2 "" style=""border-bottom: 1px dashed black"">
                <div class=""col-6"">
                    Tổng cộng
                </div>
                <div class=""col-6"">

");
#nullable restore
#line 107 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                     if (ViewBag.GiaTriDonHang != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"color: blue\">\n\n            ");
#nullable restore
#line 111 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
       Write(ViewBag.GiaTriDonHang.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\n        </span> ");
#nullable restore
#line 112 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> 0 VNĐ</span>");
#nullable restore
#line 115 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"col-6\">\n                    Giảm giá\n                </div>\n                <div class=\"col-6\">\n");
#nullable restore
#line 121 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                     if (ViewBag.GiamGia != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"color: black\">\n\n            ");
#nullable restore
#line 125 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
       Write(ViewBag.GiamGia.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span> ");
#nullable restore
#line 126 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span style=\"color: black\">\n\n    01\n</span>");
#nullable restore
#line 132 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"col-6\">\n                    Cần thanh toán\n                </div>\n                <div class=\"col-6\">\n                    <strong style=\"color: red\"> ");
#nullable restore
#line 138 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                                           Write(ViewBag.ThanhTien.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ </strong>\n                </div>\n            </div>\n            <div class=\"row p-2 m-2\" style=\"border-bottom: 1px dashed black\">\n");
#nullable restore
#line 142 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                 if (ViewBag.Vouchers != null)
                {
                    foreach (var item in (List<Voucher>)ViewBag.Vouchers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 \">\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7bccdf4293e2fc9aca901b2fed99b5ac90c87424362", async() => {
                WriteLiteral(" ");
#nullable restore
#line 148 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                                                                                                                                                    Write(item.VoucherName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-voucherCode", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
                                                                                                                         WriteLiteral(item.VoucherCode);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["voucherCode"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-voucherCode", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["voucherCode"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>");
#nullable restore
#line 149 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
          }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 p-0 m-0\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7bccdf4293e2fc9aca901b2fed99b5ac90c87427654", async() => {
                WriteLiteral(@"
                        <table style=""width: 100%"">
                            <tr>
                                <td style=""width: 10%"">
                                    <span id=""messageVoucher""> </span>
                                </td>
                                <td style=""width: 50%"">
                                    <input id=""voucher"" onkeyup=""ClearMessageVoucher()"" name=""voucher"" onblur=""CheckVoucher()"" placeholder=""Nhập mã giảm giá"" type=""text"" class=""m-2 p-2"" />
                                </td>
                                <td style=""width: 40%"">
                                    <button class=""btn btn-primary radius-0 m-2 p-2"" type=""submit"" id=""btnsubmit""> Sử dụng </button>
                                </td>
                            </tr>
                        </table>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n\n            ");
#nullable restore
#line 170 "C:\Users\thang\Documents\GitHub\e-mobile-shop-refactored\e-mobile-shop\e-mobile-shop\Views\GioHang\XemGioHang.cshtml"
       Write(await Component.InvokeAsync("CheckoutInfo", new { Id = UserManager.GetUserId(User) }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    function ClearMessageVoucher() {
        $(""#messageVoucher"").html("""");
        if ($('#voucher').val() = """") {
            $(""#messageVoucher"").html("""");
        }
    };

    function AllowUpdate(i) {
        var a = document.getElementById(""SoLuong+"" + i.toString());
        if (a.disabled === true) {
            a.disabled = false;
            $(""#btn-update-"" + i.toString()).css(""display"", ""none"");
            $(""#link-update-"" + i.toString()).css(""display"", ""block"");
        }

    }

    function CheckVoucher() {
        var voucher = $(""#voucher"").val();
        $.ajax({
            type: ""POST"",
            url: ""/Home/CheckVoucher"",
            data: { voucher: voucher },
            success: function (response) {

                var message = $(""#messageVoucher"");
                var btn_submit = $(""#btnsubmit"");
                if (response) {
                    message.css(""color"", ""green"");
                    message.addClass(""fas fa-check-circl");
            WriteLiteral(@"e p-0 m-0"");
                    message.removeClass(""fa-times"");
                    btn_submit.html(""Sử dụng"");
                    if (voucher != """") {
                        btn_submit.removeAttr(""disabled"");
                    } else {
                        btn_submit.attr(""disabled"", true);
                    }

                } else {
                    message.css(""color"", ""red"");
                    message.addClass(""fas fa-times p-0 m-0"");
                    message.removeClass(""fa-check-circle"");
                    btn_submit.html(""Không khả dụng"");
                    btn_submit.attr(""disabled"", true);
                }
            }
        });
    };
</script>
<script>
    //How this line work???
    if (window.history.replaceState) {
        window.history.replaceState(null, null, window.location.href);
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
