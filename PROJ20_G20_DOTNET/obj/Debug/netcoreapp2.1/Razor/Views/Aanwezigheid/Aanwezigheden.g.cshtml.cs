#pragma checksum "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9cb7e05cff78572535de1300e209bc50f1492f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9cb7e05cff78572535de1300e209bc50f1492f", @"/Views/Aanwezigheid/Aanwezigheden.cshtml")]
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
            BeginContext(367, 94, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2 class=\"titleAanwezigheden\">Wie is er aanwezig voor ");
            EndContext();
            BeginContext(462, 20, false);
#line 17 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                          Write(Model.Naam.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(482, 36, true);
            WriteLiteral("?</h2>\r\n        <hr />\r\n    </div>\r\n");
            EndContext();
            BeginContext(1090, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1610, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1618, 380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f8ddd589c249f480f870c9d7bc89c3", async() => {
                BeginContext(1638, 210, true);
                WriteLiteral("\r\n        <div class=\"volledigeForm\">\r\n            <div class=\"body\">\r\n                <div class=\"wrapper\">\r\n                    <input class=\"search\" type=\"text\" name=\"Naam\" id=\"Naam\" />\r\n                    ");
                EndContext();
                BeginContext(1848, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13398bcdf4c4c5787f21c8b2ba137b3", async() => {
                    BeginContext(1912, 4, true);
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
                BeginContext(1925, 66, true);
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
            BeginContext(1998, 65, true);
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
            BeginContext(2210, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2230, 633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f269d748949044c490ffac2bcd4e1888", async() => {
                BeginContext(2286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2361, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2385, 449, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d472d6531d6949d386b362be2f2bf93e", async() => {
                    BeginContext(2637, 57, true);
                    WriteLiteral("\r\n                            <p class=\"aanwezigLidName\">");
                    EndContext();
                    BeginContext(2695, 50, false);
#line 71 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                  Write(ActiviteitInschrijving.Inschrijving.Lid.Achternaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(2745, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2747, 48, false);
#line 71 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                                                                      Write(ActiviteitInschrijving.Inschrijving.Lid.Voornaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(2795, 30, true);
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
#line 69 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                  WriteLiteral(ActiviteitInschrijving.Activiteit.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 70 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
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
                BeginContext(2834, 22, true);
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
            BeginContext(2863, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                } else {

#line default
#line hidden
            BeginContext(2891, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2911, 634, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1110d8f681b422c8b19cdd34a2215e0", async() => {
                BeginContext(2966, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3041, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3065, 451, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da1888fd9ce6467dabbca1bcbe85f078", async() => {
                    BeginContext(3317, 57, true);
                    WriteLiteral("\r\n                            <p class=\"aanwezigLidName\">");
                    EndContext();
                    BeginContext(3375, 50, false);
#line 80 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                  Write(ActiviteitInschrijving.Inschrijving.Lid.Achternaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(3425, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(3427, 48, false);
#line 80 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                                                                                      Write(ActiviteitInschrijving.Inschrijving.Lid.Voornaam);

#line default
#line hidden
                    EndContext();
                    BeginContext(3475, 32, true);
                    WriteLiteral("</p>\r\n\r\n                        ");
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
#line 78 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                                  WriteLiteral(ActiviteitInschrijving.Activiteit.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 79 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
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
                BeginContext(3516, 22, true);
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
            BeginContext(3545, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                }

#line default
#line hidden
#line 84 "C:\Users\florianlanduyt\source\project\dotnet-g20\PROJ20_G20_DOTNET\Views\Aanwezigheid\Aanwezigheden.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3581, 38, true);
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
