#pragma checksum "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c58d80198ed8f6b3c5fe1cb2abd38d6e113df7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lid_Index), @"mvc.1.0.view", @"/Views/Lid/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lid/Index.cshtml", typeof(AspNetCore.Views_Lid_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c58d80198ed8f6b3c5fe1cb2abd38d6e113df7e", @"/Views/Lid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4bf064eb2072c38dcd85e682058b8c4b3ecf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Lid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROJ20_G20_DOTNET.Models.Domain.Lid>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
  
    ViewData["Title"] = "Gegevens";

#line default
#line hidden
            BeginContext(90, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 8 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
     if (TempData["Success"] != null) {

#line default
#line hidden
            BeginContext(140, 55, true);
            WriteLiteral("        <br />\r\n        <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(196, 19, false);
#line 10 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                                  Write(TempData["Success"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
    }
    else if (TempData["Error"] != null) {

#line default
#line hidden
            BeginContext(271, 54, true);
            WriteLiteral("        <br />\r\n        <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(326, 17, false);
#line 14 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                                 Write(TempData["Error"]);

#line default
#line hidden
            EndContext();
            BeginContext(343, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(356, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(365, 14, false);
#line 16 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
   Write(Model.Voornaam);

#line default
#line hidden
            EndContext();
            BeginContext(379, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(381, 16, false);
#line 16 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                   Write(Model.Achternaam);

#line default
#line hidden
            EndContext();
            BeginContext(397, 42, true);
            WriteLiteral("</h2>\r\n    <hr />\r\n    <div>\r\n        <h3>");
            EndContext();
            BeginContext(440, 13, false);
#line 19 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
       Write(Model.Functie);

#line default
#line hidden
            EndContext();
            BeginContext(453, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(457, 11, false);
#line 19 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                        Write(Model.Graad);

#line default
#line hidden
            EndContext();
            BeginContext(468, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(472, 18, false);
#line 19 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                                       Write(Model.PuntenAantal);

#line default
#line hidden
            EndContext();
            BeginContext(490, 63, true);
            WriteLiteral(" punten</h3>\r\n        <div>\r\n            <label>Geboortedatum: ");
            EndContext();
            BeginContext(554, 39, false);
#line 21 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                             Write(Model.GeboorteDatum.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(593, 51, true);
            WriteLiteral("</label><br />\r\n            <label>Geboorteplaats: ");
            EndContext();
            BeginContext(645, 20, false);
#line 22 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                              Write(Model.GeboortePlaats);

#line default
#line hidden
            EndContext();
            BeginContext(665, 45, true);
            WriteLiteral("</label><br />\r\n            <label>Geslacht: ");
            EndContext();
            BeginContext(711, 14, false);
#line 23 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                        Write(Model.Geslacht);

#line default
#line hidden
            EndContext();
            BeginContext(725, 50, true);
            WriteLiteral("</label><br />\r\n            <label>Nationaliteit: ");
            EndContext();
            BeginContext(776, 19, false);
#line 24 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                             Write(Model.Nationaliteit);

#line default
#line hidden
            EndContext();
            BeginContext(795, 55, true);
            WriteLiteral("</label><br />\r\n            <br />\r\n            <label>");
            EndContext();
            BeginContext(851, 12, false);
#line 26 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
              Write(Model.Straat);

#line default
#line hidden
            EndContext();
            BeginContext(863, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(865, 12, false);
#line 26 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                            Write(Model.HuisNr);

#line default
#line hidden
            EndContext();
            BeginContext(877, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(880, 34, false);
#line 26 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                                           Write(Model.Bus != null ? Model.Bus : "");

#line default
#line hidden
            EndContext();
            BeginContext(915, 35, true);
            WriteLiteral("</label><br />\r\n            <label>");
            EndContext();
            BeginContext(951, 14, false);
#line 27 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
              Write(Model.PostCode);

#line default
#line hidden
            EndContext();
            BeginContext(965, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(967, 20, false);
#line 27 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                              Write(Model.Stad.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(987, 60, true);
            WriteLiteral("</label><br />\r\n            <br />\r\n            <label>GSM: ");
            EndContext();
            BeginContext(1048, 11, false);
#line 29 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                   Write(Model.GsmNr);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 40, true);
            WriteLiteral("</label><br />\r\n            <label>TEL: ");
            EndContext();
            BeginContext(1101, 59, false);
#line 30 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                    Write(Model.VasteTelefoonNr != null ? Model.VasteTelefoonNr : "/");

#line default
#line hidden
            EndContext();
            BeginContext(1161, 63, true);
            WriteLiteral("</label><br />\r\n            <br />\r\n            <label>E-mail: ");
            EndContext();
            BeginContext(1225, 11, false);
#line 32 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 49, true);
            WriteLiteral("</label><br />\r\n            <label>E-mail vader: ");
            EndContext();
            BeginContext(1287, 49, false);
#line 33 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                             Write(Model.EmailVader != null ? Model.EmailVader : "/");

#line default
#line hidden
            EndContext();
            BeginContext(1337, 50, true);
            WriteLiteral("</label><br />\r\n            <label>E-mail moeder: ");
            EndContext();
            BeginContext(1389, 52, false);
#line 34 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                              Write(Model.EmailMoeder != null ? @Model.EmailMoeder : "/");

#line default
#line hidden
            EndContext();
            BeginContext(1442, 63, true);
            WriteLiteral("</label><br />\r\n            <br />\r\n            <label>Beroep: ");
            EndContext();
            BeginContext(1507, 42, false);
#line 36 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                       Write(Model.Beroep != null ? @Model.Beroep : "/");

#line default
#line hidden
            EndContext();
            BeginContext(1550, 60, true);
            WriteLiteral("</label><br />\r\n            <br />\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1610, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c929297e5a4736891effdbddb8ef9e", async() => {
                BeginContext(1616, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1630, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5e7f89127094a5ab16cd1f7ccc342c7", async() => {
                    BeginContext(1705, 8, true);
                    WriteLiteral("Wijzigen");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 40 "E:\School\2YS2\Projecten2\dotnet-g20\PROJ20_G20_DOTNET\Views\Lid\Index.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1722, 10, true);
                WriteLiteral("\r\n        ");
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
            BeginContext(1739, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJ20_G20_DOTNET.Models.Domain.Lid> Html { get; private set; }
    }
}
#pragma warning restore 1591
