#pragma checksum "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f7823cdfb2623e4fb77994bcd827086148d589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(iap2.Pages.Pages_SingleProduct), @"mvc.1.0.razor-page", @"/Pages/SingleProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f7823cdfb2623e4fb77994bcd827086148d589", @"/Pages/SingleProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f771675da74b71bf810de3818a42bbecdc0b8ce0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SingleProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("ADD TO CART"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f7823cdfb2623e4fb77994bcd827086148d5894476", async() => {
                WriteLiteral("\r\n    <div class=\"imageHalf\">\r\n        <img class=\"previewImg\"");
                BeginWriteAttribute("src", " src=\"", 134, "\"", 173, 2);
                WriteAttributeValue("", 140, "./assets/", 140, 9, true);
#nullable restore
#line 7 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 149, Model.item.ProductImage, 149, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 174, "\"", 207, 1);
#nullable restore
#line 7 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 180, Model.item.ProductImageAlt, 180, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <img class=\"previewImg\"");
                BeginWriteAttribute("src", " src=\"", 242, "\"", 286, 2);
                WriteAttributeValue("", 248, "./assets/", 248, 9, true);
#nullable restore
#line 8 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 257, Model.item.ProductImagePage2, 257, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 287, "\"", 325, 1);
#nullable restore
#line 8 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 293, Model.item.ProductImagePage2Alt, 293, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <img class=\"previewImg\"");
                BeginWriteAttribute("src", " src=\"", 360, "\"", 404, 2);
                WriteAttributeValue("", 366, "./assets/", 366, 9, true);
#nullable restore
#line 9 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 375, Model.item.ProductImagePage3, 375, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 405, "\"", 443, 1);
#nullable restore
#line 9 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
WriteAttributeValue("", 411, Model.item.ProductImagePage3Alt, 411, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"descriptionHalf\">\r\n        <p class=\"brandName\">The Ordinary</p>\r\n        <p class=\"title\">");
#nullable restore
#line 13 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
                    Write(Model.item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p id=\"size\">");
#nullable restore
#line 14 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
                Write(Model.item.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p id=\"priceProduct\">");
#nullable restore
#line 15 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
                        Write(Model.item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</p>\r\n        <p>");
#nullable restore
#line 16 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
      Write(Model.item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p id=\"ingredients\">Ingredients: ");
#nullable restore
#line 17 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
                                    Write(Model.item.Ingredients);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06f7823cdfb2623e4fb77994bcd827086148d5898862", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\SingleProduct.cshtml"
                             WriteLiteral(Model.item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iap2.Pages.SingleProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.SingleProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.SingleProductModel>)PageContext?.ViewData;
        public iap2.Pages.SingleProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
