#pragma checksum "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd63d42fb6472953c435584b480c8a64c588bdde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GagandeepKaurA00224734_SimpleWebPage.Pages.Pages_ArrayPage), @"mvc.1.0.razor-page", @"/Pages/ArrayPage.cshtml")]
namespace GagandeepKaurA00224734_SimpleWebPage.Pages
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
#line 1 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\_ViewImports.cshtml"
using GagandeepKaurA00224734_SimpleWebPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd63d42fb6472953c435584b480c8a64c588bdde", @"/Pages/ArrayPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b3b82063d2a43db5913fa094670001d17b128d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArrayPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
  
    ViewData["Title"] = "Array Page";
    
    string[] courseNames = new string[5];
    courseNames[0] = "WEB-1001";
    courseNames[1] = "BTA-1002";
    courseNames[2] = "JAV-1001";
    courseNames[3] = "ISP-1002";
    courseNames[4] = "DBA-1000";

    string[] studentNames = { "Gagan", "Cai", "Dave", "Gurdeep", "Rasheen", "Amrit", "Jagdeep", "Youssef" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 17 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<ul>\r\n");
#nullable restore
#line 21 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
     for (int i = 0; i < courseNames.Length; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 23 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
       Write(courseNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ol>\r\n");
#nullable restore
#line 28 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
     for (int i = 0; i < studentNames.Length; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
         if (studentNames[i] != "Dave")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 32 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
           Write(studentNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 33 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\ArrayPage.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GagandeepKaurA00224734_SimpleWebPage.Pages.ArrayPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GagandeepKaurA00224734_SimpleWebPage.Pages.ArrayPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GagandeepKaurA00224734_SimpleWebPage.Pages.ArrayPageModel>)PageContext?.ViewData;
        public GagandeepKaurA00224734_SimpleWebPage.Pages.ArrayPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
