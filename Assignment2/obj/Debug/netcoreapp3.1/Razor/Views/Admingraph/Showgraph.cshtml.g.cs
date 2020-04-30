#pragma checksum "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d22347ba0395b9772f43094cd23c6def831a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admingraph_Showgraph), @"mvc.1.0.view", @"/Views/Admingraph/Showgraph.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d22347ba0395b9772f43094cd23c6def831a15", @"/Views/Admingraph/Showgraph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd122725cd497121730ccf872ad45638414e3df", @"/Views/_ViewImports.cshtml")]
    public class Views_Admingraph_Showgraph : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
  
    ViewData["Title"] = "Showgraph";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Showgraph</h1>

<div class=""box-body"">
    <div>Bar Chart</div>
    <div class=""chart-container"" style=""width:400px; height:600px;"">
        <canvas id=""bar_chart"" style=""width:100%; height:500px""></canvas>
    </div>

    <div>Polar Chart</div>
    <div class=""chart-container"" style=""width:400px; height:600px;"">
        <canvas id=""polar_chart"" style=""width:100%; height:500px""></canvas>
    </div>

    <div>Pie Chart</div>
    <div class=""chart-container"" style=""width:400px; height:600px;"">
        <canvas id=""pie_chart"" style=""width:100%; height:500px""></canvas>
    </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n<script>\nvar city = ");
#nullable restore
#line 31 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
      Write(Html.Raw(ViewBag.city));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    var Rep = ");
#nullable restore
#line 32 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
         Write(Html.Raw(ViewBag.Rep));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n\n    var Transactiontype = ");
#nullable restore
#line 34 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
                     Write(Html.Raw(ViewBag.Transactiontype));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n    var terms = ");
#nullable restore
#line 35 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
           Write(Html.Raw(ViewBag.terms));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

window.chartColors = {
	red: 'rgb(255, 99, 132)',
	orange: 'rgb(255, 159, 64)',
	yellow: 'rgb(255, 205, 86)',
	green: 'rgb(75, 192, 192)',
	blue: 'rgb(54, 162, 235)',
	purple: 'rgb(153, 102, 255)',
	grey: 'rgb(201, 203, 207)'
};
 $(document).ready(function () {
    var ctx = $(""#bar_chart"");
    var myBarChart = new Chart(ctx, {
        type: 'bar',
        data: {
            //labels: ['Melbourne', 'Sydney'],
            labels: city,
            //labels: [");
#nullable restore
#line 53 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
                  Write(Html.Raw(ViewBag.city));

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n            datasets: [{\n                label: \"Customer City\",\n                //data: [");
#nullable restore
#line 56 "C:\Users\sifte\Downloads\a3-s3706786-s3631518-master\a3-s3706786-s3631518-master\Assignment-3\Assignment2\Views\Admingraph\Showgraph.cshtml"
                    Write(ViewBag.Rep);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                //data: [2, 1],
                data: Rep,
                backgroundColor: [""rgba(242,166,54,5)"", ""rgba(145,65,72,.5)"", ""rgba(74,25,92,.5)""],
                borderColor:[""rgb(242,166,54)"", ""rgb(145,65,72)"", ""rgb(74,25,92)""]
            }]
        },
       options: {
          scales: {
             xAxes: [{
                stacked: true
             }],
             yAxes: [{
                stacked: true
             }]
          }
        }


    });


     piedata = {
        datasets: [{
           //data: [10, 20, 30]
            data: terms
         }],
         backgroundColor: [
						window.chartColors.red,
						window.chartColors.orange,
						window.chartColors.yellow,
						window.chartColors.green,
						window.chartColors.blue,
					],
        // These labels appear in the legend and in the tooltips when hovering different arcs
        // labels: ['Red', 'Yellow', 'Blue']
        labels: Transactiontype
     };

     //Pie Chart start here
     var ctx1 = $");
                WriteLiteral(@"(""#pie_chart"");
     var myPieChart = new Chart(ctx1, {
       type: 'pie',
       data: piedata,
       options: {
				responsive: true
			}
     });




     //Pollar Charts starts here
     var polardata = {
        datasets: [{
           data: [10, 20, 30]
        }],
         backgroundColor: [""rgba(242,166,54,5)"", ""rgba(145,65,72,.5)"", ""(74,25,92,.5)""],
        // These labels appear in the legend and in the tooltips when hovering different arcs
        labels: [
           'Red',
           'Yellow',
           'Blue'
        ]
     };

     var ctx2 = $(""#polar_chart"");
     new Chart(ctx2, {
         data: polardata,
         type: 'polarArea',
         options: {
             responsive: true,
             legend: {
                 position: 'right',
             },
             title: {
                 display: true,
                 text: 'Polar Area Chart'
             },
             scale: {
                 ticks: {
                     beginAtZero: true
    ");
                WriteLiteral("             },\r\n                 reverse: false\r\n             },\r\n             animation: {\r\n                 animateRotate: false,\r\n                 animateScale: true\r\n             }\r\n         }\r\n\r\n     });\n\n\n});\n\n\n\n\n\n\n\n\n    </script> \n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
