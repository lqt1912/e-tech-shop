#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d1316b67414e3a2574133c38598c4c9348fd1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QuanLyDienThoai), @"mvc.1.0.view", @"/Views/Admin/QuanLyDienThoai.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d1316b67414e3a2574133c38598c4c9348fd1e", @"/Views/Admin/QuanLyDienThoai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QuanLyDienThoai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SanPham>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
  
    ViewData["Title"] = "QuanLyDienThoai";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d1316b67414e3a2574133c38598c4c9348fd1e3485", async() => {
                WriteLiteral(@"
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                Quản lý điện thoại
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">

                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Tên</th>
                                <th>Ảnh</th>
                                <th>Số lượng</th>
                                <th>Đã bán</th>
                                <th>Lượt xem</th>
                                <th>Hãng sãn xuất</th>
                                <th>Giá gốc</th>
                                <th>Giá bán</th>
                                <th>Sửa</th>
                                <th>Xóa</th>
                            </tr>
                        <");
                WriteLiteral("/thead>\r\n\r\n                        <tbody>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 39 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.MaSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 41 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.TenSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td align=\"center\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=", 1610, "", 1665, 1);
#nullable restore
#line 43 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
WriteAttributeValue("", 1615, Url.Content("~/ProductAvatar/" + item.AnhDaiDien), 1615, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50\" height=\"50\" />\r\n                                    </td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 45 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">0</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 47 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.SoLuotXemSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 48 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.Nsx);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 49 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.GiaGoc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 50 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.GiaTien);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                    <td style=""vertical-align:middle"">
                                        <button type=""button"" class=""btn btn-primary"">Sửa </button>
                                    </td>
                                    <td style=""vertical-align:middle"">
                                        <button type=""button"" class=""btn btn-primary"">Xóa</button>
                                    </td>
                                </tr>
");
#nullable restore
#line 58 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 63 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.MaSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 65 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.TenSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td align=\"center\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=", 3171, "", 3226, 1);
#nullable restore
#line 67 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
WriteAttributeValue("", 3176, Url.Content("~/ProductAvatar/" + item.AnhDaiDien), 3176, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50\" height=\"50\" />\r\n                                    </td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 69 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">0</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 71 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.SoLuotXemSp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 72 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.Nsx);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 73 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.GiaGoc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 74 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
                                                                 Write(item.GiaTien);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                    <td style=""vertical-align:middle"">
                                        <button type=""button"" class=""btn btn-primary"">Sửa </button>
                                    </td>
                                    <td style=""vertical-align:middle"">
                                        <button type=""button"" class=""btn btn-primary"">Xóa</button>
                                    </td>
                                </tr>
");
#nullable restore
#line 82 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDienThoai.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
