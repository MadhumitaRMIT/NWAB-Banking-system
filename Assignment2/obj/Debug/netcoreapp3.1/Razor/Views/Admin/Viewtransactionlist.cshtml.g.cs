#pragma checksum "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e84f9c763a0242ce504b4a35b8408ff592a5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Viewtransactionlist), @"mvc.1.0.view", @"/Views/Admin/Viewtransactionlist.cshtml")]
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
#line 1 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e84f9c763a0242ce504b4a35b8408ff592a5ce", @"/Views/Admin/Viewtransactionlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd122725cd497121730ccf872ad45638414e3df", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Viewtransactionlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
  
    ViewData["Title"] = "Viewtransaction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View Transaction</h1>\r\n\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 15 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 16 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
           Write(Html.DisplayNameFor(model => model.DestinationAccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 18 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransactionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransactionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
               Write(Html.DisplayFor(modelItem => item.DestinationAccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admin\Viewtransactionlist.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
