#pragma checksum "D:\TESTY\WebCalculator\Kalkulator\Views\TimeZone\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a09425d64b74c2ac7662e65239818b35686ac65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeZone_Index), @"mvc.1.0.view", @"/Views/TimeZone/Index.cshtml")]
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
#line 1 "D:\TESTY\WebCalculator\Kalkulator\Views\_ViewImports.cshtml"
using Kalkulator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TESTY\WebCalculator\Kalkulator\Views\_ViewImports.cshtml"
using Kalkulator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a09425d64b74c2ac7662e65239818b35686ac65", @"/Views/TimeZone/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e042a1af37407a7cc89811594c6653b7032534b", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeZone_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\TESTY\WebCalculator\Kalkulator\Views\TimeZone\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-16"">
    <script>

        setInterval(function () {
            var today = new Date();
            var month = today.getMonth() + 1;
            var day = today.getDate();
            if (month < 10) { month = '0' + month; }
            if (day < 10) { day = '0' + day; }
            var hours = today.getHours();
            if (hours < 10) { hours = '0' + hours; }
            var minutes = today.getMinutes();
            if (minutes < 10) { minutes = '0' + minutes; }
            var seconds = today.getSeconds();
            if (seconds < 10) { seconds = '0' + seconds; }
            var datelocal = today.getFullYear() + '-' + month + '-' + day;
            var timelocal = hours + "":"" + minutes + "":"" + seconds;
            var dateTime = datelocal + "" "" + timelocal;

            var today8 = new Date();
            today8.setHours(today8.getHours() + 8);
            var month8 = today8.getMonth() + 1;
            if (month8 < 10) { month8 = '0' + month8; }
         ");
            WriteLiteral(@"   var day8 = today8.getDate()+1;
            if (day8 < 10) { day8 = '0' + day8; }
            var hours8 = today8.getHours();
            if (hours8 < 10) { hours8 = '0' + hours8; }
            var minutes8 = today8.getMinutes();
            if (minutes8 < 10) { minutes8 = '0' + minutes8; }
            var seconds8 = today8.getSeconds();
            if (seconds8 < 10) { seconds8 = '0' + seconds8; }
            var datelocal8 = today8.getFullYear() + '-' + month8 + '-' + day8;
            var timelocal8 = hours8 + "":"" + minutes8 + "":"" + seconds8;
            var dateTime8 = datelocal8 + "" "" + timelocal8;
            document.getElementById('datetime').innerHTML = dateTime;
            document.getElementById('dateTime8').innerHTML = dateTime8;
        }, 1000);

    </script>

    <h1 style=""color:red"">Date/Time Local:<span id=""datetime""></span></h1>
    <h1 style=""color:red"">Date/Time Local+8:<span id=""dateTime8""></span></h1>



</div>
");
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
