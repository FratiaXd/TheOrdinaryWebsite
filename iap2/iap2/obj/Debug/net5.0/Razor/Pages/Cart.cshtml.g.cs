#pragma checksum "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0685202491f71b8e03df8ab9baf4d6377f1dee17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(iap2.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0685202491f71b8e03df8ab9baf4d6377f1dee17", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f771675da74b71bf810de3818a42bbecdc0b8ce0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"itemsBox\">\r\n");
#nullable restore
#line 6 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
     foreach (var cartItem in Model.cartItemsList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"singleItem\">\r\n            <h4>Quantity: </h4>\r\n            <P>");
#nullable restore
#line 10 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
          Write(cartItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0685202491f71b8e03df8ab9baf4d6377f1dee174047", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
                                 WriteLiteral(cartItem.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h4>Name: </h4>\r\n            <p>");
#nullable restore
#line 13 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
          Write(cartItem.Products.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h4>Price: </h4>\r\n            <p>");
#nullable restore
#line 15 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
          Write(cartItem.Products.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n            <h4>Sub-total price: </h4>\r\n            <p>");
#nullable restore
#line 17 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
          Write(Model.totalForProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n            <img class=\"previewImg\"");
            BeginWriteAttribute("src", " src=\"", 603, "\"", 649, 2);
            WriteAttributeValue("", 609, "./assets/", 609, 9, true);
#nullable restore
#line 18 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
WriteAttributeValue("", 618, cartItem.Products.ProductImage, 618, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 650, "\"", 690, 1);
#nullable restore
#line 18 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
WriteAttributeValue("", 656, cartItem.Products.ProductImageAlt, 656, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <h4>Total: </h4>\r\n    <p>");
#nullable restore
#line 24 "C:\Users\Owner\source\repos\TheOrdinaryWebsite\iap2\iap2\Pages\Cart.cshtml"
  Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iap2.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iap2.Pages.CartModel>)PageContext?.ViewData;
        public iap2.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
