#pragma checksum "D:\c_sharp\LearnRazorPages\RazorPages\WebApp\Pages\Thanhvien\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bd81af07a8c02de273fe6c39630db7fca57baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Thanhvien.Pages_Thanhvien_index), @"mvc.1.0.razor-page", @"/Pages/Thanhvien/index.cshtml")]
namespace WebApp.Pages.Thanhvien
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
#line 1 "D:\c_sharp\LearnRazorPages\RazorPages\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bd81af07a8c02de273fe6c39630db7fca57baf", @"/Pages/Thanhvien/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a580a236bf4511f2b8e02a6219a9844921dafb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Thanhvien_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/hinh/hinhthanhvien/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\c_sharp\LearnRazorPages\RazorPages\WebApp\Pages\Thanhvien\index.cshtml"
  
    Layout = "_Admin2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card o-hidden border-0 shadow-lg my-3\">\r\n        <div class=\"card-body p-0\">\r\n            <!-- Form thông tin tài khoản -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd81af07a8c02de273fe6c39630db7fca57baf6052", async() => {
                WriteLiteral(@"
                <div class=""row-12"">
                    <div class=""text-center p-5"">
                        <h1 class=""h2 text-gray-900"">Thông Tin Tài Khoản</h1>
                    </div>
                </div>
                <div class=""row"">
                    <!-- ảnh đại diện người dùng -->
                    <div class=""col-lg-4 p-5 border-0 shadow-lg"">
                        <div class=""form-group"">
");
                WriteLiteral("                            <div class=\"card border-0 shadow-lg my-3\" style=\"width: 180px; height: 200px;\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0bd81af07a8c02de273fe6c39630db7fca57baf6929", async() => {
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
                WriteLiteral("\r\n                            </div>\r\n                            <input type=\"file\" class=\"form-control\" name=\"hinhanh\">\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                    </div>
                    <!-- khung thông tin 1 -->
                    <div class=""col-lg-4 p-5 border-0 shadow-lg"">
                        <!-- mssv -->
                        <div class=""form-group"">
");
                WriteLiteral("                            <label>Mã số:</label>\r\n                            <input type=\"text\" class=\"form-control form-control-user\" name=\"txt_mssv\" placeholder=\"Mã số sinh viên\" readonly");
                BeginWriteAttribute("value", " value=\"", 2849, "\"", 2857, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                        </div>\r\n                        <!-- ho ten -->\r\n                        <div class=\"form-group\">\r\n                            <label>Họ tên:</label>\r\n");
                WriteLiteral("                            <input type=\"text\" class=\"form-control form-control-user\" name=\"txt_hoten\" placeholder=\"Nhập họ tên sinh viên\" required>\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                        <!-- ngày sinh -->
                        <div class=""form-group"">
                            <label>Ngày sinh:</label>
");
                WriteLiteral("                            <input type=\"date\" class=\"form-control form-control-user\" name=\"txt_ngaysinh\" required>\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                        <!-- gioi tinh -->
                        <div class=""form-group"">
                            <label>Giới tính:</label>
");
                WriteLiteral(@"                            <input class=""form-select"" type=""radio"" id=""nam"" name=""txt_gioitinh"" value=""Nam"">
                            <label for=""nam"">Nam</label>
                            <input class=""form-select"" type=""radio"" id=""nu"" name=""txt_gioitinh"" value=""Nữ"">
                            <label for=""nu"">Nữ</label>
");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                    </div>
                    <!-- khung thông tin 2 -->
                    <div class=""col-lg-4 p-5 border-0 shadow-lg"">
                        <!-- Quê Quán -->
                        <div class=""form-group"">
                            <label for=""sl_quequan"">Quê quán:</label>
                            <select name=""sl_quequan"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0bd81af07a8c02de273fe6c39630db7fca57baf11499", async() => {
                    WriteLiteral("Chọn tỉnh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"                            </select>
                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                        <!-- sdt -->
                        <div class=""form-group"">
                            <label>Số điện thoại:</label>
");
                WriteLiteral("                            <input type=\"text\" class=\"form-control form-control-user\" name=\"txt_sdt\" placeholder=\"Nhập số điện thoại\" required>\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                        <!-- email -->
                        <div class=""form-group"">
                            <label>Email:</label>
");
                WriteLiteral("                            <input type=\"email\" class=\"form-control form-control-user\" name=\"txt_email\" placeholder=\"Nhập địa chỉ Email\" required>\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                        <!-- Mã lớp -->
                        <div class=""form-group"">
                            <label>Mã lớp:</label>
");
                WriteLiteral("                            <input type=\"text\" class=\"form-control form-control-user\" name=\"txt_malop\" placeholder=\"Nhập mã lớp\" required>\r\n");
                WriteLiteral(@"                            <div class=""valid-feedback"">Xác nhận.</div>
                            <div class=""invalid-feedback"">Vui lòng điền vào trường này.</div>
                        </div>
                    </div>
                </div>
                <button type=""submit"" class=""btn btn-success btn-user btn-block"" style=""font-size: 20px"" name=""sbluu"">Lưu lại</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.Thanhvien.indexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Thanhvien.indexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Thanhvien.indexModel>)PageContext?.ViewData;
        public WebApp.Pages.Thanhvien.indexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
