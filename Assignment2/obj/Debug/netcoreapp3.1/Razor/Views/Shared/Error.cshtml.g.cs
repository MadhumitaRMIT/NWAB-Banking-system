#pragma checksum "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1ac397a8aac521ca3126cede3c4baab0c764fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1ac397a8aac521ca3126cede3c4baab0c764fc", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd122725cd497121730ccf872ad45638414e3df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 8 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">Error.</h1>\n    <h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n");
#nullable restore
#line 13 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
     if (Model.ShowRequestId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            <strong>Request ID:</strong> <code>");
#nullable restore
#line 16 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
                                          Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n        </p>\n");
#nullable restore
#line 18 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h3>Development Mode</h3>
    <p>
        Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
    </p>
    <p>
        <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
        It can result in displaying sensitive information from exceptions to end users.
        For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
        and restarting the app.
    </p>
");
#nullable restore
#line 30 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">");
#nullable restore
#line 34 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <h6 class=\"text-danger\">");
#nullable restore
#line 35 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n");
#nullable restore
#line 36 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Shared\Error.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
