#pragma checksum "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d123a3654e93224e31c9d25cd93899938c20c89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Trixnet.web.Pages.Views_TestAnnuaire), @"mvc.1.0.razor-page", @"/Views/TestAnnuaire.cshtml")]
namespace Trixnet.web.Pages
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
#line 1 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\_ViewImports.cshtml"
using Trixnet.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
using Trixnet.web.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/TestAnnuaire/{nom}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d123a3654e93224e31c9d25cd93899938c20c89", @"/Views/TestAnnuaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966f79433173acc870926076680348238a8b7f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_TestAnnuaire : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
  
    var serviceAnnuaire = new ServiceAnnuaire();

    var resultatRecherche = serviceAnnuaire.getRechercheNom(Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d123a3654e93224e31c9d25cd93899938c20c894018", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Secteur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Statut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
           Write(Html.DisplayNameFor(model => model.Fonction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Secteur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Statut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fonction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\TestAnnuaire.cshtml"
 
    [FromRoute]
    public string Nom { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.IOrchardHelper Orchard { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Trixnet.web.Models.Annuaire>> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<Trixnet.web.Models.Annuaire>> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<Trixnet.web.Models.Annuaire>>)PageContext?.ViewData;
        public IEnumerable<Trixnet.web.Models.Annuaire> Model => ViewData.Model;
    }
}
#pragma warning restore 1591
