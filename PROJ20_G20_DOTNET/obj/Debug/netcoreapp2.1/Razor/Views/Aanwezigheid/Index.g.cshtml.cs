#pragma checksum "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3acd0470eea2b8d01df358c7340afc7d14776711"
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
#line 1 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\_ViewImports.cshtml"
using PROJ20_G20_DOTNET;

#line default
#line hidden
#line 2 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\_ViewImports.cshtml"
using PROJ20_G20_DOTNET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3acd0470eea2b8d01df358c7340afc7d14776711", @"/Views/Aanwezigheid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4bf064eb2072c38dcd85e682058b8c4b3ecf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Aanwezigheid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROJ20_G20_DOTNET.Models.Domain.Activiteit>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aanwezigheden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
  
    ViewData["Title"] = "Aanwezigheden";

#line default
#line hidden
            BeginContext(115, 285, true);
            WriteLiteral(@"
<div>
    <h2>Activiteiten</h2>
    <hr />
    <table class=""table table-bordered table-striped"">
        <tr>
            <th>Naam activiteit</th>
            <th>Datum</th>
            <th>Tijdstip</th>
            <th>Formule</th>
            <th></th>
        </tr>

");
            EndContext();
#line 19 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
         foreach (var Activiteit in Model) {

#line default
#line hidden
            BeginContext(446, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(485, 15, false);
#line 21 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
               Write(Activiteit.Naam);

#line default
#line hidden
            EndContext();
            BeginContext(500, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(528, 41, false);
#line 22 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
               Write(Activiteit.BeginDatum.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(569, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(597, 41, false);
#line 23 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
               Write(Activiteit.BeginDatum.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(638, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(666, 18, false);
#line 24 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
               Write(Activiteit.Formule);

#line default
#line hidden
            EndContext();
            BeginContext(684, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(752, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e116aa16cf1a4a12a976910f922196c2", async() => {
                BeginContext(758, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(784, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c238386933e4f36891f207a597003d3", async() => {
                    BeginContext(844, 13, true);
                    WriteLiteral("Aanwezigheden");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 27 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
                                                        WriteLiteral(Activiteit.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(861, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(890, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(945, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
