#pragma checksum "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "425f1fec56aea3b7d707e61574d5c9f6c7b9eacb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavBar), @"mvc.1.0.view", @"/Views/Shared/NavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NavBar.cshtml", typeof(AspNetCore.Views_Shared_NavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425f1fec56aea3b7d707e61574d5c9f6c7b9eacb", @"/Views/Shared/NavBar.cshtml")]
    public class Views_Shared_NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 141, true);
            WriteLiteral("<div class=\"nav-bar-container\">\n  <nav class=\"navbar navbar-expand-sm bg-info navbar\">\n    <ul class=\"navbar-nav\">\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 141, "\"", 195, 3);
            WriteAttributeValue("", 151, "location.href=\'", 151, 15, true);
#line 4 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 166, Url.Action("Index", "Home"), 166, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 194, "\'", 194, 1, true);
            EndWriteAttribute();
            BeginContext(196, 130, true);
            WriteLiteral(">\n      <div class =\"weHateRazorStyling\">\n        <a class=\"nav-link\">Home</a>\n      </div>\n      </li>\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 326, "\"", 385, 3);
            WriteAttributeValue("", 336, "location.href=\'", 336, 15, true);
#line 9 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 351, Url.Action("Create", "Stylists"), 351, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 384, "\'", 384, 1, true);
            EndWriteAttribute();
            BeginContext(386, 84, true);
            WriteLiteral(">\n        <a class=\"nav-link\">Add Stylist</a>\n      </li>\n      <li class=\"nav-item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 470, "\"", 527, 3);
            WriteAttributeValue("", 480, "location.href=\'", 480, 15, true);
#line 12 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Shared/NavBar.cshtml"
WriteAttributeValue("", 495, Url.Action("Index", "Clients"), 495, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 526, "\'", 526, 1, true);
            EndWriteAttribute();
            BeginContext(528, 91, true);
            WriteLiteral(">\n        <a class=\"nav-link\">Booked Appointments</a>\n      </li>\n    </ul>\n  </nav>\n</div>");
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
