#pragma checksum "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Main_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab69cdc83bc3413184e58d7637a0961233c227fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main_menu), @"mvc.1.0.view", @"/Views/Home/Main_menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main_menu.cshtml", typeof(AspNetCore.Views_Home_Main_menu))]
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
#line 1 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\_ViewImports.cshtml"
using PracaInz;

#line default
#line hidden
#line 2 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\_ViewImports.cshtml"
using PracaInz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab69cdc83bc3413184e58d7637a0961233c227fc", @"/Views/Home/Main_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110e558799c3d02561421fcec4dd805c189751e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main_menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Main_menu.cshtml"
      
        ViewData["Title"] = "Main_menu";
    

#line default
#line hidden
            BeginContext(59, 159, true);
            WriteLiteral("\r\n    <h2>Assystent Zakupów</h2>\r\n\r\n    <h6>Wybierz tryb</h6>\r\n\r\n\r\n\r\n\r\n    <div class=\"col-sm-3 text-center\">\r\n        <input type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 218, "\"", 276, 3);
            WriteAttributeValue("", 228, "location.href=\'", 228, 15, true);
#line 14 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Main_menu.cshtml"
WriteAttributeValue("", 243, Url.Action("Load_list", "Home"), 243, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 275, "\'", 275, 1, true);
            EndWriteAttribute();
            BeginContext(277, 121, true);
            WriteLiteral(" value=\"Edytuj liste zakupów\" style=\"margin-bottom:3px; width:200px\" />\r\n        <input type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 398, "\"", 458, 3);
            WriteAttributeValue("", 408, "location.href=\'", 408, 15, true);
#line 15 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Main_menu.cshtml"
WriteAttributeValue("", 423, Url.Action("Create_list", "Home"), 423, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 457, "\'", 457, 1, true);
            EndWriteAttribute();
            BeginContext(459, 118, true);
            WriteLiteral(" value=\"Stworz nowa listę\" style=\" margin-bottom:3px;width:200px\" />\r\n        <input type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 577, "\"", 639, 3);
            WriteAttributeValue("", 587, "location.href=\'", 587, 15, true);
#line 16 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Main_menu.cshtml"
WriteAttributeValue("", 602, Url.Action("Generate_list", "Home"), 602, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 638, "\'", 638, 1, true);
            EndWriteAttribute();
            BeginContext(640, 97, true);
            WriteLiteral(" value=\"Wygeneruj listę zakupów\" style=\" margin-bottom:3px; width:200px\" />\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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
