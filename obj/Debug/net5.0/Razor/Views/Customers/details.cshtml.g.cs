#pragma checksum "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd45e2115b6e8c002b810e50624ea985f33e59d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_details), @"mvc.1.0.view", @"/Views/Customers/details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd45e2115b6e8c002b810e50624ea985f33e59d7", @"/Views/Customers/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6388ac10249aa9768ae45766abc36962c1f04e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<firstWebapp.ViewModels.CustomersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 3 "/home/vinicius/Documents/Projects/firstWebapp/Views/Customers/details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
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