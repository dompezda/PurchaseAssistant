#pragma checksum "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b4f17a1212fb07f164d1734861276140dab88e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Load_List), @"mvc.1.0.view", @"/Views/Home/Load_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Load_List.cshtml", typeof(AspNetCore.Views_Home_Load_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b4f17a1212fb07f164d1734861276140dab88e", @"/Views/Home/Load_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110e558799c3d02561421fcec4dd805c189751e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Load_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit_List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Edit_list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/cross.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
  
    ViewData["Title"] = "Wczytaj Liste";

#line default
#line hidden
            BeginContext(49, 110, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h4>Wybierz Liste do Wczytania</h4>\r\n\r\n\r\n    <input type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 159, "\"", 217, 3);
            WriteAttributeValue("", 169, "location.href=\'", 169, 15, true);
#line 9 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
WriteAttributeValue("", 184, Url.Action("Main_menu", "Home"), 184, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 216, "\'", 216, 1, true);
            EndWriteAttribute();
            BeginContext(218, 143, true);
            WriteLiteral(" value=\"Wroć\" style=\"margin-bottom:3px; width:60px; margin-left:10%;\" />\r\n</div>\r\n\r\n            <div class=\"accordion\" id=\"accordionExample\">\r\n");
            EndContext();
#line 13 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                  int k = 0;

#line default
#line hidden
            BeginContext(392, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 14 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                 foreach (var list in ViewBag.Lists)
                {

#line default
#line hidden
            BeginContext(465, 44, true);
            WriteLiteral("                    <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 509, "\"", 527, 2);
            WriteAttributeValue("", 514, "headingOne_", 514, 11, true);
#line 16 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
WriteAttributeValue("", 525, k, 525, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 217, true);
            WriteLiteral(">\r\n                        <h5 class=\"mb-0\">\r\n                            <div class=\"row\">\r\n                                <button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapseOne_");
            EndContext();
            BeginContext(746, 1, false);
#line 19 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                                                                                                                       Write(k);

#line default
#line hidden
            EndContext();
            BeginContext(747, 95, true);
            WriteLiteral("\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                                    Lista ");
            EndContext();
            BeginContext(843, 1, false);
#line 20 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                                     Write(k);

#line default
#line hidden
            EndContext();
            BeginContext(844, 40, true);
            WriteLiteral("\r\n\r\n                                    ");
            EndContext();
            BeginContext(884, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b4f17a1212fb07f164d1734861276140dab88e9056", async() => {
                BeginContext(946, 179, true);
                WriteLiteral("\r\n                                        <button class=\"btn-primary\" style=\"margin-bottom:3px; width:100px; margin-left:5%;\">Edytuj</button>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1132, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1170, 351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b4f17a1212fb07f164d1734861276140dab88e11400", async() => {
                BeginContext(1210, 77, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"list.Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1287, "\"", 1303, 1);
#line 26 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
WriteAttributeValue("", 1295, list.Id, 1295, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1304, 111, true);
                WriteLiteral(" />\r\n                                        \r\n\r\n                                        <button type=\"submit\">");
                EndContext();
                BeginContext(1415, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44b4f17a1212fb07f164d1734861276140dab88e12393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1467, 47, true);
                WriteLiteral("</button>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1521, 142, true);
            WriteLiteral("\r\n\r\n                                </button>\r\n                            </div>\r\n                        </h5>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(1665, 40, true);
            WriteLiteral("                    <div class=\"card\">\r\n");
            EndContext();
#line 38 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                         foreach (var productList in list.ProductList)
                        {
                            //var prods = productList.Select(w => w.Product).ToList();

#line default
#line hidden
            BeginContext(1892, 32, true);
            WriteLiteral("                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1924, "\"", 1943, 2);
            WriteAttributeValue("", 1929, "collapseOne_", 1929, 12, true);
#line 41 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
WriteAttributeValue("", 1941, k, 1941, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1944, 17, true);
            WriteLiteral(" class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1961, "\"", 1992, 2);
            WriteAttributeValue("", 1979, "headingOne_", 1979, 11, true);
#line 41 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
WriteAttributeValue("", 1990, k, 1990, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1993, 130, true);
            WriteLiteral(" data-parent=\"#accordionExample\">\r\n                                <div class=\"card-body\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(2124, 24, false);
#line 44 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                               Write(productList.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2148, 116, true);
            WriteLiteral("\r\n                                    \r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 48 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                        }

#line default
#line hidden
            BeginContext(2291, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 50 "C:\Users\Dominik\Desktop\Praca_aktualna\PracaInz\Views\Home\Load_List.cshtml"
                    k++;
                }

#line default
#line hidden
            BeginContext(2364, 36, true);
            WriteLiteral("            </div>\r\n\r\n          \r\n\r\n");
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
