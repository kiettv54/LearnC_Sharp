#pragma checksum "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f9d5dfb17af1464d964ca7050178691624d47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f9d5dfb17af1464d964ca7050178691624d47a", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>File Upload</h1>\r\n\r\n<form method=\"post\" enctype=\"multipart/form-data\">\r\n    <input type=\"file\" name=\"file\" />\r\n\r\n    <button asp-page-handler=\"file\">Submit</button>\r\n</form>\r\n\r\n");
#nullable restore
#line 15 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
 if (Request.Method == "POST")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
     if (Model.Success)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-success\">File \'");
#nullable restore
#line 20 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                  Write(ViewData["file"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' uploaded successfully!</h3>\r\n");
#nullable restore
#line 21 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"text-danger\">Failed to upload file \'");
#nullable restore
#line 24 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                                  Write(ViewData["file"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'!</h2>\r\n");
#nullable restore
#line 25 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\c_sharp\LearnRazorPages\WebApplication1\WebApplication1\Pages\Index.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.IndexModel>)PageContext?.ViewData;
        public WebApplication1.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
