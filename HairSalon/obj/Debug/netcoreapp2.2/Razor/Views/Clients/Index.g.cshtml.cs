#pragma checksum "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902ef2d22e84bfae8b6d29eb3d9cfff50849bf52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 8 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902ef2d22e84bfae8b6d29eb3d9cfff50849bf52", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(124, 19, true);
            WriteLiteral("\n<h1>Clients</h1>\n\n");
            EndContext();
#line 13 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(169, 43, true);
            WriteLiteral("  <h3>No Clients have been added yet!</h3>\n");
            EndContext();
#line 16 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(215, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 foreach (Client client in Model)
{

#line default
#line hidden
            BeginContext(252, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(259, 73, false);
#line 20 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 Write(Html.ActionLink($"{client.FirstName}", "Details", new { id = client.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(332, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(336, 14, false);
#line 20 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
                                                                              Write(client.Stylist);

#line default
#line hidden
            EndContext();
            BeginContext(350, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(358, 78, true);
            WriteLiteral("<input type=\"button\" class=\"btn btn-outline-info\" value=\"Book an Appointment!\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 436, "\"", 494, 3);
            WriteAttributeValue("", 446, "location.href=\'", 446, 15, true);
#line 22 "/Users/frederickernest/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
WriteAttributeValue("", 461, Url.Action("Create", "Clients"), 461, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 493, "\'", 493, 1, true);
            EndWriteAttribute();
            BeginContext(495, 4, true);
            WriteLiteral(" />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
