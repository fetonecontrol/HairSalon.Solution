#pragma checksum "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "683af4607468f12ac6e3d08aec79a904b25d3923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
#line 5 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683af4607468f12ac6e3d08aec79a904b25d3923", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 45, true);
            WriteLiteral("\n\n<h2>Clients currently booked with</h2>\n<h3>");
            EndContext();
            BeginContext(131, 41, false);
#line 10 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(172, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(174, 40, false);
#line 10 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(214, 20, true);
            WriteLiteral(":</h3>\n<hr />\n\n<ul>\n");
            EndContext();
#line 14 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
 if (@Model.Clients.Count == 0)
{

#line default
#line hidden
            BeginContext(268, 46, true);
            WriteLiteral("  <p>This stylist has no current bookings</p>\n");
            EndContext();
#line 17 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
}

#line default
#line hidden
            BeginContext(316, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 19 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
 foreach (Client client in Model.Clients)
{

#line default
#line hidden
            BeginContext(361, 12, true);
            WriteLiteral("  <li>Name: ");
            EndContext();
            BeginContext(374, 16, false);
#line 21 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
       Write(client.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(390, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(392, 15, false);
#line 21 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
                         Write(client.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(407, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 22 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
}

#line default
#line hidden
            BeginContext(415, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(426, 40, false);
#line 25 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(466, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(475, 69, false);
#line 26 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Edit Stylist", "Edit", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(544, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(553, 73, false);
#line 27 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(626, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(635, 62, false);
#line 28 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Book with this Stylist", "Create", "Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(697, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
