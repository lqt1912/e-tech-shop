#pragma checksum "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff5c41fe7f19c46329147ca2db45797fa3c34b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QuanLyDonHang), @"mvc.1.0.view", @"/Views/Admin/QuanLyDonHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff5c41fe7f19c46329147ca2db45797fa3c34b0a", @"/Views/Admin/QuanLyDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e691f4367cc4b6721b6f8680a7758f718fe0c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QuanLyDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("filter()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuanLyDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
  
    ViewData["Title"] = "QuanLyDonHang";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var context = new ClientDbContext();
    var dataAccess = new DataAccess();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff5c41fe7f19c46329147ca2db45797fa3c34b0a6341", async() => {
                WriteLiteral("\r\n     ");
#nullable restore
#line 10 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
Write(Html.Partial("_StatusMessages"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""col-lg-12"">
        <div class=""panel panel-success"">
            <div class="" panel-heading "">
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <h4>Quản lý đơn hàng</h4>
                        
                    </div>
                    <div class=""col-lg-4"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff5c41fe7f19c46329147ca2db45797fa3c34b0a7250", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff5c41fe7f19c46329147ca2db45797fa3c34b0a7546", async() => {
                        WriteLiteral("Trạng thái");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 20 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(context.TrangThaiDonHang.ToList(),"Id","TenTrangThai"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff5c41fe7f19c46329147ca2db45797fa3c34b0a10518", async() => {
                    WriteLiteral(@"
                            <div class=""input-group custom-search-form"">
                                <input name=""searchValue"" type=""text"" class=""form-control"" placeholder=""Tìm mã đơn hàng hoặc tên khách hàng ..."">
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">

                        <thead>
                            <tr>
                                <th>Mã đơn hàng</th>
                                <th>Tên khách hàng</th>
                                <th>Trạng thái</th>
                                <th>Thời gian đặt hàng</th>
                                <th>Phương thức giao dịch</th>
                                <th>Tổng tiền</th>
                                <th>Sửa</th>
                                <th>Chi tiết</th>
                            </tr>
                        </thead>

                        <tbody>

");
#nullable restore
#line 59 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 63 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                 Write(item.MaDh);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 65 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                 Write(item.HoTen);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 66 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                 Write(context.TrangThaiDonHang.Find(item.TinhTrangDh).TenTrangThai);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td  style=\"vertical-align:middle\">");
#nullable restore
#line 67 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                  Write(item.Ghichu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 68 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                 Write(item.PtgiaoDich);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">");
#nullable restore
#line 69 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                                                                 Write(item.Tongtien);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td style=\"vertical-align:middle\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3408, "\"", 3497, 3);
                WriteAttributeValue("", 3418, "location.href=\'", 3418, 15, true);
#nullable restore
#line 71 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
WriteAttributeValue("", 3433, Url.Action( "ChiTietDonHang","Admin", new {  id = item.MaDh }), 3433, 63, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3496, "\'", 3496, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Chi tiết</button>\r\n                                    </td>\r\n                                    <td style=\"vertical-align:middle\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3718, "\"", 3808, 3);
                WriteAttributeValue("", 3728, "location.href=\'", 3728, 15, true);
#nullable restore
#line 74 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
WriteAttributeValue("", 3743, Url.Action( "ChinhSuaDonHang","Admin", new {  id = item.MaDh }), 3743, 64, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3807, "\'", 3807, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Sửa</button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <script>
        function filter() {
           // var e = document.querySelector('#filter').value;
          //  location.href = '/admin/quanlydonhang/3?status=' + document.querySelector('#filter').value;
            location.href = '");
#nullable restore
#line 89 "C:\Users\thang\Documents\GitHub\e-mobile-shop\e-mobile-shop\e-mobile-shop\Views\Admin\QuanLyDonHang.cshtml"
                        Write(Url.Action("QuanLyDonHang","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \'?status=\' + document.querySelector(\'#filter\').value;\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
