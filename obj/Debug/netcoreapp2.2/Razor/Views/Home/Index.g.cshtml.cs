#pragma checksum "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7636e2b61fab311dd68bd31da46f3a1772fa2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/_ViewImports.cshtml"
using reportNPO;

#line default
#line hidden
#line 2 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/_ViewImports.cshtml"
using reportNPO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7636e2b61fab311dd68bd31da46f3a1772fa2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bb7f64f232ae45fc273640a6b6d60373e84a99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "NPO Report";
    double sum = 0;

#line default
#line hidden
            BeginContext(67, 100, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"h1\">Non-profit Donation Report </h1>\r\n    <p>Fund Raised: ");
            EndContext();
            BeginContext(168, 3, false);
#line 8 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
               Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(171, 243, true);
            WriteLiteral("</p>\r\n    <table class=\"table table-bodered\">\r\n        <thead class=\"thead-dark\">\r\n            <th>Order#</th>\r\n            <th>Org Name</th>\r\n            <th>Order Value</th>\r\n            <th>Donation</th>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 17 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
             foreach (var row in ViewBag.NPOReport)
            {

#line default
#line hidden
            BeginContext(482, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(529, 16, false);
#line 20 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
                   Write(row.OrderNumbers);

#line default
#line hidden
            EndContext();
            BeginContext(545, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(577, 11, false);
#line 21 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
                   Write(row.NPOName);

#line default
#line hidden
            EndContext();
            BeginContext(588, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(620, 9, false);
#line 22 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
                   Write(row.Total);

#line default
#line hidden
            EndContext();
            BeginContext(629, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 23 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
                       
                        double donation = row.Total* 1.18 / 100;
                        sum+= donation;
                    

#line default
#line hidden
            BeginContext(791, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(816, 8, false);
#line 27 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
                   Write(donation);

#line default
#line hidden
            EndContext();
            BeginContext(824, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "/Users/kenjilam/AllPeople/projects/reportNPO/Views/Home/Index.cshtml"
            } 

#line default
#line hidden
            BeginContext(870, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
            EndContext();
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