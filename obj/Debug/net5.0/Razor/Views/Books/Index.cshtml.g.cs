#pragma checksum "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d15555d4e4768dfd9053f6f88371a688071d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\_ViewImports.cshtml"
using LibAppOrzechowski;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\_ViewImports.cshtml"
using LibAppOrzechowski.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d15555d4e4768dfd9053f6f88371a688071d22", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2fb8e93ab7995e8677168095981ec368e5d1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibAppOrzechowski.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Index.cshtml"
  
    ViewBag.Title = "Books";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Books</h2>\r\n\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Book</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Index.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Index.cshtml"
               Write(Html.DisplayFor(modelItem => book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibAppOrzechowski.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591