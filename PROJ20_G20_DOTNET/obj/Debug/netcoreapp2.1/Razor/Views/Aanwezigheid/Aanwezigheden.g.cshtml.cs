#pragma checksum "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b83d5d0cb5911daf92eb2a7906622a567484df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aanwezigheid_Aanwezigheden), @"mvc.1.0.view", @"/Views/Aanwezigheid/Aanwezigheden.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aanwezigheid/Aanwezigheden.cshtml", typeof(AspNetCore.Views_Aanwezigheid_Aanwezigheden))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b83d5d0cb5911daf92eb2a7906622a567484df1", @"/Views/Aanwezigheid/Aanwezigheden.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4bf064eb2072c38dcd85e682058b8c4b3ecf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Aanwezigheid_Aanwezigheden : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJ20_G20_DOTNET.Models.Domain.Activiteit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aanwezigheden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("knopKaart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VoegAanwezigheidToe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aanwezigFalse aanwezigKaart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerwijderActiviteit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aanwezigTrue aanwezigKaart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
  
    ViewData["Title"] = "Aanwezigheden";

#line default
#line hidden
            BeginContext(102, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
            BeginContext(391, 119, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2 class=\"titleAanwezigheden\">Wie is er aanwezig voor <strong class=\"vetKleur\">");
            EndContext();
            BeginContext(511, 10, false);
#line 17 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                                                   Write(Model.Naam);

#line default
#line hidden
            EndContext();
            BeginContext(521, 45, true);
            WriteLiteral("?</strong></h2>\r\n        <hr />\r\n    </div>\r\n");
            EndContext();
            BeginContext(1138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1658, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1666, 380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c63086a2e344f33b65efa0fa24df893", async() => {
                BeginContext(1686, 210, true);
                WriteLiteral("\r\n        <div class=\"volledigeForm\">\r\n            <div class=\"body\">\r\n                <div class=\"wrapper\">\r\n                    <input class=\"search\" type=\"text\" name=\"Naam\" id=\"Naam\" />\r\n                    ");
                EndContext();
                BeginContext(1896, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72f0c9a733b84a5bb7abc5624b81114d", async() => {
                    BeginContext(1960, 4, true);
                    WriteLiteral("Zoek");
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
                BeginContext(1973, 66, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2046, 65, true);
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row-flex\">\r\n");
            EndContext();
#line 64 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
             foreach (var ActiviteitInschrijving in Model.ActiviteitInschrijvingen) {
                

#line default
#line hidden
#line 65 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                 if (!ActiviteitInschrijving.IsAanwezig) {



#line default
#line hidden
            BeginContext(2262, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2282, 904, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f359b216b54746a695b328fd1be905", async() => {
                BeginContext(2338, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2684, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2708, 449, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a355f3d01a4eefac758218fd61e1e3", async() => {
                    BeginContext(2960, 57, true);
                    WriteLiteral("\r\n                            <p class=\"aanwezigLidName\">");
                    EndContext();
                    BeginContext(3018, 50, false);
#line 77 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                  Write(ActiviteitInschrijving.Inschrijving.Lid.Achternaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(3068, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(3070, 48, false);
#line 77 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                                                                      Write(ActiviteitInschrijving.Inschrijving.Lid.Voornaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(3118, 30, true);
                    WriteLiteral("</p>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 75 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                  WriteLiteral(ActiviteitInschrijving.Activiteit.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 76 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                   WriteLiteral(ActiviteitInschrijving.Inschrijving.Lid.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id2"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id2", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id2"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3157, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"

                } else {

#line default
#line hidden
            BeginContext(3216, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3236, 885, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c79ac436e4d490d97a2bcbfcce67a10", async() => {
                BeginContext(3291, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3619, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3643, 449, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305bc43b7bc2434aa861f9d14db72653", async() => {
                    BeginContext(3895, 57, true);
                    WriteLiteral("\r\n                            <p class=\"aanwezigLidName\">");
                    EndContext();
                    BeginContext(3953, 50, false);
#line 91 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                  Write(ActiviteitInschrijving.Inschrijving.Lid.Achternaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(4003, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(4005, 48, false);
#line 91 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                                                                      Write(ActiviteitInschrijving.Inschrijving.Lid.Voornaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(4053, 30, true);
                    WriteLiteral("</p>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 89 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                  WriteLiteral(ActiviteitInschrijving.Activiteit.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 90 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                   WriteLiteral(ActiviteitInschrijving.Inschrijving.Lid.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id2"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id2", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id2"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4092, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 94 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                }

#line default
#line hidden
#line 94 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4157, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJ20_G20_DOTNET.Models.Domain.Activiteit> Html { get; private set; }
    }
}
#pragma warning restore 1591
