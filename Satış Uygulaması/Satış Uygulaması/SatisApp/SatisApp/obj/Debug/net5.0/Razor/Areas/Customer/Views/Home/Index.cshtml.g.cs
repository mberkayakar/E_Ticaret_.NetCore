#pragma checksum "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8966e3492dc4613503c32672283eba083ce56e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\_ViewImports.cshtml"
using SatisApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\_ViewImports.cshtml"
using SatisApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8966e3492dc4613503c32672283eba083ce56e3", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f89e58b308cf505fe97b5de450897a60052f7b6a", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SatisApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-md-3"">
    <ul class=""list-group"">
        <li class=""list-group-item active"">Cras justo odio</li>
        <li class=""list-group-item"">Dapibus ac facilisis in</li>
        <li class=""list-group-item"">Morbi leo risus</li>
        <li class=""list-group-item"">Porta ac consectetur ac</li>
        <li class=""list-group-item"">Vestibulum at eros</li>
    </ul>
</div>


");
#nullable restore
#line 21 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
 foreach (var item in Model)
{



  
        var cikti = Regex.Replace(item.Description, "<.*?>", String.Empty).Replace("&nbsp;", "");
        if (cikti.Length > 100)
            cikti = cikti.Substring(0,100);

           
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-3 col-md-6"">
                <div class=""row p-2"">
                    <div class=""col-12  p-1"" style=""border:1px solid #008cba; border-radius: 5px;"">
                        <div class=""card"" style=""border:0px;"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 1050, "\"", 1070, 1);
#nullable restore
#line 37 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1056, item.ImageUrl, 1056, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top rounded\" width=\"250\" height=\"200\" />\r\n                            <div class=\"pl-1\">\r\n                                <p class=\"card-title text-primary\"><b>");
#nullable restore
#line 39 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n\r\n\r\n\r\n                                <p class=\"card-title h5\"> <b style=\"color:#2c3e50\">");
#nullable restore
#line 43 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
                                                                              Write(cikti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            </div>\r\n\r\n                            <div style=\"padding-left:5px;\">\r\n                                <p style=\"color:maroon\"> Fiyat: <b");
            BeginWriteAttribute("class", " class=\"", 1539, "\"", 1547, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"
                                                                       Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            </div>\r\n                        </div>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8966e3492dc4613503c32672283eba083ce56e38387", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\Muhammed Berkay AKAR\Desktop\E_Ticaret_.NetCore\Satış Uygulaması\Satış Uygulaması\SatisApp\SatisApp\Areas\Customer\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SatisApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
