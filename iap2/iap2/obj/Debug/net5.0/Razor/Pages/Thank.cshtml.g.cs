#pragma checksum "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Thank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea311279f282a78071b46e31086ad1ed41138a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(iap2.Pages.Pages_Thank), @"mvc.1.0.razor-page", @"/Pages/Thank.cshtml")]
namespace iap2.Pages
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
#line 1 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\_ViewImports.cshtml"
using iap2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea311279f282a78071b46e31086ad1ed41138a6", @"/Pages/Thank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f771675da74b71bf810de3818a42bbecdc0b8ce0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Thank : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"conf\">\r\n    <h1>Thank you!</h1>\r\n    <h5>We accepted your order</h5>\r\n    <h5>You should receive an email confirmation soon</h5>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iap2.Pages.ThankModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.ThankModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.ThankModel>)PageContext?.ViewData;
        public iap2.Pages.ThankModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
