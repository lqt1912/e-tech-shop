#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93d3e8211d031516fff70e6745b60313b477ff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QuanLyKhuyenMai), @"mvc.1.0.view", @"/Views/Admin/QuanLyKhuyenMai.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93d3e8211d031516fff70e6745b60313b477ff0", @"/Views/Admin/QuanLyKhuyenMai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QuanLyKhuyenMai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Voucher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuanLyKhuyenMai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XoaKhuyenMai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
  
    ViewData["Title"] = "QuanLyKhuyenMai";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var context = new ClientDbContext();
    var dataAccess = new DataAccess();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93d3e8211d031516fff70e6745b60313b477ff05896", async() => {
                WriteLiteral(@"
    <div class=""col-lg-12"">
        <div class=""panel panel-success"">
            <div class="" panel-heading "">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <h4>Quản lý khuyến mãi</h4>

                    </div>
                    <div class=""col-lg-6"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93d3e8211d031516fff70e6745b60313b477ff06510", async() => {
                    WriteLiteral(@"
                            <div class=""input-group custom-search-form"">
                                <input name=""searchValue"" type=""text"" class=""form-control"" placeholder=""Tìm mã hoặc tên khuyến mãi ..."">
                                <span class=""input-group-btn"">
                                    <button class=""btn btn-default"" type=""submit"">
                                        <i class=""fa fa-search""></i>
                                    </button>
                                </span>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""98%"" cellspacing=""0"">

                        <thead>
                            <tr >
                                <th class=""text-center"">ID</th>
                                <th class=""text-center"">Mã voucher</th>
                                <th class=""text-center"">Tên </th>
                                <th class=""text-center"">Giá trị</th>
                                <th class=""text-center"">Loại</th>
                                 <th class=""text-center"">Trạng thái</th>
                                <th class=""text-center"">Xóa</th>
                            </tr>
                        </thead>

                        <tbody>

");
#nullable restore
#line 51 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td style=\"vertical-align:middle\" class=\"text-center\">");
#nullable restore
#line 55 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                                     Write(item.VoucherId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 57 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                 Write(item.VoucherCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 58 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                 Write(item.VoucherName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 59 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                 Write(item.VoucherDiscount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 60 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                 Write(context.VoucherType.Find(item.VoucherType).VoucherTypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                     if(item.Status==1)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"text-center\" style=\"vertical-align:middle\">Hoạt động</td>\r\n");
#nullable restore
#line 64 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                    }else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"text-center\" style=\"vertical-align:middle\">Hết hạn</td>\r\n");
#nullable restore
#line 67 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <td style=""vertical-align:middle; "" class=""text-center"">
                                        <button type=""button"" data-toggle=""modal"" data-target=""#exampleModal"" class=""btn btn-primary text-center"">Xóa</button>
                                        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                            <div class=""modal-dialog"" role=""document"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header"">
                                                        <h5 class=""modal-title"" id=""exampleModalLabel"">Xác nhận xóa </h5>
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                            <span aria-hidden=""true"">&times;</span>
");
                WriteLiteral(@"                                                        </button>
                                                    </div>
                                                    <div class=""modal-body"">
                                                        Bạn có muốn <span style=""color:red; font-weight:bold;"">xóa</span> voucher <span style=""color:red; font-weight:bold""> ");
#nullable restore
#line 80 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                                                                                                                        Write(item.VoucherName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93d3e8211d031516fff70e6745b60313b477ff015773", async() => {
                    WriteLiteral(" Xóa ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                                                                                                                                                    WriteLiteral(item.VoucherId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>

                                </tr>
");
#nullable restore
#line 92 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyKhuyenMai.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Voucher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
