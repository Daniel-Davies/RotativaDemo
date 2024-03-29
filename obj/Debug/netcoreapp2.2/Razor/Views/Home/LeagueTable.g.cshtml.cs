#pragma checksum "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbccf5817d6b64c24d7ac098e012aaf30f9bcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LeagueTable), @"mvc.1.0.view", @"/Views/Home/LeagueTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LeagueTable.cshtml", typeof(AspNetCore.Views_Home_LeagueTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbccf5817d6b64c24d7ac098e012aaf30f9bcb3", @"/Views/Home/LeagueTable.cshtml")]
    public class Views_Home_LeagueTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RotativaDemo.Models.LeagueTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
  
    ViewData["Title"] = "LeagueTable";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(112, 131, true);
            WriteLiteral("\r\n<div class=\"jumbotron p-2 text-center border border-primary\">\r\n    <p class=\"h4\">Date created: <span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(244, 40, false);
#line 8 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
                                                             Write(Model.DateCreated.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(284, 82, true);
            WriteLiteral("</span></p><br/>\r\n    <p class=\"h4\">Match Week: <span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(367, 15, false);
#line 9 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
                                                           Write(Model.matchWeek);

#line default
#line hidden
            EndContext();
            BeginContext(382, 432, true);
            WriteLiteral(@"</span></p>
</div>
<h1>League Table</h1>
<h4 class=""text-muted"">Barclays Premier League 2019</h4>
<table class=""table table-bordered"">
    <thead style=""background-color: #37003C"">
        <tr class=""text-white"">
            <th scope=""col"">Position</th>
            <th scope=""col"">Club</th>
            <th scope=""col"">Games Played</th>
            <th scope=""col"">Points</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
         for (int i = 0; i < Model.rows.Count; i++)
        {

#line default
#line hidden
            BeginContext(878, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(929, 22, false);
#line 26 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
                           Write(Model.rows[i].position);

#line default
#line hidden
            EndContext();
            BeginContext(951, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(979, 18, false);
#line 27 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].club);

#line default
#line hidden
            EndContext();
            BeginContext(997, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1025, 22, false);
#line 28 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].numGames);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1075, 20, false);
#line 29 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].points);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\davie\source\repos\RotativaDemo\RotativaDemo\Views\Home\LeagueTable.cshtml"
        }

#line default
#line hidden
            BeginContext(1132, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RotativaDemo.Models.LeagueTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
