#pragma checksum "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ee690241d948374fbfc4d82699bb70184836966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_paybill), @"mvc.1.0.view", @"/Views/Customer/paybill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee690241d948374fbfc4d82699bb70184836966", @"/Views/Customer/paybill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd122725cd497121730ccf872ad45638414e3df", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_paybill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaybillSave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
  
    ViewData["Title"] = "Paybill";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"display-4\">Pay By, ");
#nullable restore
#line 6 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<br>\n<br>\n<div class=\"row\">\n    <div class=\"col-md-4\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee690241d948374fbfc4d82699bb701848369665431", async() => {
                WriteLiteral("\n\n            <div class=\"form-group\">\n                <label for=\"from_account\" class=\"control-label\">From Account</label>\n                <select id=\"from_account\" name=\"from_account\">\n");
#nullable restore
#line 17 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
                     foreach (var account in Model.Accounts)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee690241d948374fbfc4d82699bb701848369666246", async() => {
                    WriteLiteral("\n                            ");
#nullable restore
#line 20 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
                       Write(account.AccountNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
                           WriteLiteral(account.AccountNumber);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "customAttribute", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
AddHtmlAttributeValue("", 549, account.AccountNumber, 549, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 22 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\n            </div>\n\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee690241d948374fbfc4d82699bb701848369669236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 26 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <div class=\"form-group\">\n                <label for=\"Amount\" class=\"control-label\">Amount</label>\n                <input id=\"Amount\" name=\"Amount\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 985, "\"", 1026, 1);
#nullable restore
#line 29 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
WriteAttributeValue("", 993, ViewBag.Amount?.ToString("0.00"), 993, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                       data-val=\"true\" data-val-number=\"The field Amount must be a number.\"\n                       data-val-required=\"The Amount field is required.\" />\n                ");
#nullable restore
#line 32 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
           Write(Html.ValidationMessage("Amount", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label for=\"schedule_date\" class=\"control-label\">Schedule date</label>\n                <input id=\"schedule_date\" name=\"schedule_date\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1505, "\"", 1513, 0);
                EndWriteAttribute();
                WriteLiteral("\n                       data-val=\"true\"\n                       data-val-required=\"The Amount field is required.\" />\n                ");
#nullable restore
#line 40 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
           Write(Html.ValidationMessage("schedule_date", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label for=\"period\" class=\"control-label\">Period(i.e, 30 days)</label>\n                <input id=\"period\" name=\"period\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1932, "\"", 1940, 0);
                EndWriteAttribute();
                WriteLiteral("\n                       data-val=\"true\"\n                       data-val-required=\"The period field is required.\" />\n                ");
#nullable restore
#line 48 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
           Write(Html.ValidationMessage("period", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee690241d948374fbfc4d82699bb7018483696615253", async() => {
                WriteLiteral("Back to Accounts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 62 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Customer\paybill.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <script>\n        $.noConflict();\n        jQuery(document).ready(function ($) {\n             $(function () {\n                $(\"#schedule_date\").datepicker({ dateFormat: \'yy-mm-dd\' });\n             });\n        });\n    </script>\n\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
