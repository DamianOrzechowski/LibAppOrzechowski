#pragma checksum "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39657a404c22394dd57a880a74774eaf426acc0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Random), @"mvc.1.0.view", @"/Views/Books/Random.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39657a404c22394dd57a880a74774eaf426acc0a", @"/Views/Books/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2fb8e93ab7995e8677168095981ec368e5d1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibAppOrzechowski.ViewModels.RandomBookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
 if (Model.Customers.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>No one has borrowed this book before</li>\r\n");
#nullable restore
#line 14 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
     foreach (var customer in Model.Customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 19 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
       Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\fujitsu\source\repos\LibAppOrzechowski\Views\Books\Random.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibAppOrzechowski.ViewModels.RandomBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591