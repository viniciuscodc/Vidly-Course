#pragma checksum "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05e52f9f7fcefae3a7fb3cf4ac70dcb7589c00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "/home/vinicius/Documents/Projects/firstWebapp/Views/_ViewImports.cshtml"
using firstWebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/vinicius/Documents/Projects/firstWebapp/Views/_ViewImports.cshtml"
using firstWebapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05e52f9f7fcefae3a7fb3cf4ac70dcb7589c00c", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6388ac10249aa9768ae45766abc36962c1f04e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<firstWebapp.ViewModels.CustomersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
  
    ViewData["Title"] = "Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
  
    var className = Model.Customers.Count() > 5 ? "popular" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Customers</h2>\r\n\r\n");
#nullable restore
#line 13 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
 if(Model.Customers.Count() == 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No one has rented this movie before</p>\r\n");
#nullable restore
#line 16 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"

}else{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover table-bordered\">\r\n        \r\n        <tr>\r\n            <th>Customers</th>\r\n         </tr>\r\n\r\n");
#nullable restore
#line 25 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
             foreach (var customer in Model.Customers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
                   Write(Html.ActionLink(customer.Name, "Details", "Customers", new { id = customer.Id}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </table>\r\n");
#nullable restore
#line 33 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<firstWebapp.ViewModels.CustomersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591