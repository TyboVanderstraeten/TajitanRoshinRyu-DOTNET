#pragma checksum "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181914a2724cc586ff9273424de31a0e23b1284f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aanwezigheid_Index), @"mvc.1.0.view", @"/Views/Aanwezigheid/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aanwezigheid/Index.cshtml", typeof(AspNetCore.Views_Aanwezigheid_Index))]
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
#line 1 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\_ViewImports.cshtml"
using PROJ20_G20_DOTNET;

#line default
#line hidden
#line 2 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\_ViewImports.cshtml"
using PROJ20_G20_DOTNET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181914a2724cc586ff9273424de31a0e23b1284f", @"/Views/Aanwezigheid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4bf064eb2072c38dcd85e682058b8c4b3ecf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Aanwezigheid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROJ20_G20_DOTNET.Models.Domain.Activiteit>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("test"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
  
    ViewData["Title"] = "Aanwezigheden";

#line default
#line hidden
            BeginContext(117, 80, true);
            WriteLiteral("\r\n<div>\r\n    <h2>Activiteiten</h2>\r\n    <hr />\r\n    <div class=\"test\">\r\n        ");
            EndContext();
            BeginContext(197, 843, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d1cd83c3ed84fffb126e1869d121a5d", async() => {
                BeginContext(230, 151, true);
                WriteLiteral("\r\n\r\n            <label for=\"BeginDatum\" class=\"control-label\">Begindatum</label>\r\n            <input type=\"date\" name=\"BeginDatum\" id=\"BeginDatum\" />\r\n");
                EndContext();
                BeginContext(631, 280, true);
                WriteLiteral(@"
            <label for=""EindDatum"" class=""control-label"">Einddatum</label>
            <input type=""date"" name=""EindDatum"" id=""EindDatum"" />
            <label for=""Naam"" class=""control-label"">Naam</label>
            <input type=""text"" name=""Naam"" id=""Naam"" />
            ");
                EndContext();
                BeginContext(911, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d64a6c59bdb46c3bbf209bfa8e1aa1d", async() => {
                    BeginContext(976, 38, true);
                    WriteLiteral("\r\n                Filter\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1023, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1040, 416, true);
            WriteLiteral(@"
    </div>
    <div class=""limiter"">
            <div class=""tabelWrap"">
                <table class=""tabel"">
                    <tr class=""rij header"">
                        <th class=""cell"">Naam activiteit</th>
                        <th class=""cell"">Datum</th>
                        <th class=""cell"">Tijdstip</th>
                        <th class=""cell"">Formule</th>
                    </tr>
");
            EndContext();
#line 40 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                     foreach (var Activiteit in Model) {

#line default
#line hidden
            BeginContext(1514, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1541, "\"", 1643, 5);
            WriteAttributeValue("", 1551, "location.href", 1551, 13, true);
            WriteAttributeValue(" ", 1564, "=", 1565, 2, true);
            WriteAttributeValue(" ", 1566, "\'", 1567, 2, true);
#line 41 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
WriteAttributeValue("", 1568, Url.Action("Aanwezigheden", "Aanwezigheid", new { Id = Activiteit.Id }), 1568, 74, false);

#line default
#line hidden
            WriteAttributeValue("", 1642, "\'", 1642, 1, true);
            EndWriteAttribute();
            BeginContext(1644, 60, true);
            WriteLiteral(" class=\"rij\">\r\n                            <td class=\"cell\">");
            EndContext();
            BeginContext(1705, 15, false);
#line 42 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                                        Write(Activiteit.Naam);

#line default
#line hidden
            EndContext();
            BeginContext(1720, 52, true);
            WriteLiteral("</td>\r\n                            <td class=\"cell\">");
            EndContext();
            BeginContext(1773, 41, false);
#line 43 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                                        Write(Activiteit.BeginDatum.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1814, 52, true);
            WriteLiteral("</td>\r\n                            <td class=\"cell\">");
            EndContext();
            BeginContext(1867, 41, false);
#line 44 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                                        Write(Activiteit.BeginDatum.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(1908, 52, true);
            WriteLiteral("</td>\r\n                            <td class=\"cell\">");
            EndContext();
            BeginContext(1961, 18, false);
#line 45 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                                        Write(Activiteit.Formule);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 40, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2042, 68, true);
            WriteLiteral("                </table>\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROJ20_G20_DOTNET.Models.Domain.Activiteit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
