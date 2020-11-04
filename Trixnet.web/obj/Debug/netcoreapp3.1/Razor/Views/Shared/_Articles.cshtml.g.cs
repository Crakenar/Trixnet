#pragma checksum "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a595908d14ebfcbf4a60e9415f51509645a59fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Trixnet.web.Pages.Shared.Views_Shared__Articles), @"mvc.1.0.view", @"/Views/Shared/_Articles.cshtml")]
namespace Trixnet.web.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a595908d14ebfcbf4a60e9415f51509645a59fc0", @"/Views/Shared/_Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966f79433173acc870926076680348238a8b7f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
  
    //Permet de savoir le type d'article à afficher
    string type = ViewContext.ViewBag.TypeOfArticle;
    //Combien d'article prendre de la BD Orchard
    int how_many_retreived = 3;
    var tab_articles = await Orchard.GetRecentContentItemsByContentTypeAsync(type, how_many_retreived);

    int maxCharacterDescription = 200;
    int maxCharacterTitle = 60;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Probleme; load le css pour toute la page et non pas juste pour le template _Article.cshtml-->\r\n<link");
            BeginWriteAttribute("href", " href=\"", 649, "\"", 697, 1);
#nullable restore
#line 17 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 656, Url.Content("~/css/ArticleTemplate.css"), 656, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" rel=""stylesheet"" type=""text/css"" />
<div class=""bg-white"">
    <div class=""trixell-X AppSection SectionGD SectionHB"">
        <div class=""container showcase-text"">
            <h2 class=""jaapooki"" style=""font-size: 1.5rem; color: rgb(19, 133,203);""><i class=""fas fa-newspaper""></i>   Actualités</h2>
        </div>
");
#nullable restore
#line 23 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
         foreach (var articles in tab_articles)
        {
            List<string> imagesPrincipales = new List<string>();
            string articleText = articles.Content.MarkdownBodyPart.Markdown;
            string articleTitre = articles.DisplayText;
            //si le texte est null alors on met "pas de description"
            articleText ??= "pas de description";

            Trixnet.web.Services.UtilitairesClass utils = new Services.UtilitairesClass();
            //Permet de recuperer l'ensemble des documents d'un article
            var documents = utils.setDocumentsArticle(articles.Content.BagPart.Media.Paths);
            imagesPrincipales = utils.getImagePrincipale(type, articles);
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
             foreach (var item in imagesPrincipales)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1846, "\"", 1882, 2);
            WriteAttributeValue("", 1851, "article-", 1851, 8, true);
#nullable restore
#line 37 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 1859, articles.ContentItemId, 1859, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""articleModal"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-lg"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title title-overflow"" id=""articleModal"">");
#nullable restore
#line 41 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                                                     Write(articleTitre.Length > maxCharacterTitle ? articleTitre.Substring(0, maxCharacterTitle) : articleTitre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">");
#nullable restore
#line 46 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                               Write(articleText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 47 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                             if (documents.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr />\r\n                                <div class=\"row\">\r\n                                    <!--Affichage de l\'ensemble des documents liés à l\'article-->\r\n");
#nullable restore
#line 52 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                     for (int p = 0; p < documents.Count; p++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"col-lg-4\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3192, "\"", 3275, 1);
#nullable restore
#line 55 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 3198, documents[p].GetType().GetProperty("imageShow").GetValue(@documents[p],null), 3198, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"30\" />\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3350, "\"", 3437, 1);
#nullable restore
#line 56 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 3357, documents[p].GetType().GetProperty("downloadLink").GetValue(@documents[p],null), 3357, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 56 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                                                                                                                  Write(documents[p].GetType().GetProperty("nameDoc").GetValue(@documents[p], null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </span>\r\n");
#nullable restore
#line 58 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 60 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                            </div>
                        </div>
                    </div>
                </div>
                <!--Ici c'est l'affichage simple dans page HTML-->
                <div class=""container showcase-text"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 4134, "\"", 4173, 2);
            WriteAttributeValue("", 4141, "#article-", 4141, 9, true);
#nullable restore
#line 69 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 4150, articles.ContentItemId, 4150, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"row link-news\" data-toggle=\"modal\" data-target=\"#article-");
#nullable restore
#line 69 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                                                                                          Write(articles.ContentItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"col-lg-4 text-white img-news\"");
            BeginWriteAttribute("style", " style=\"", 4331, "\"", 4370, 4);
            WriteAttributeValue("", 4339, "background-image:", 4339, 17, true);
            WriteAttributeValue(" ", 4356, "url(\'", 4357, 6, true);
#nullable restore
#line 70 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 4362, item, 4362, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4367, "\');", 4367, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"col-lg-8 text-news\">\r\n                            <h2 class=\"title-overflow\">");
#nullable restore
#line 72 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                   Write(articleTitre.Length > maxCharacterTitle ? articleTitre.Substring(0, maxCharacterTitle) : articleTitre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p class=\"lead mb-0\" style=\"text-justify: distribute;\">");
#nullable restore
#line 73 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                                               Write(articleText.Length > maxCharacterDescription ?  articleText.Substring(0, maxCharacterDescription) :  articleText);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 76 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                     if (documents.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <!--Affichage de l\'ensemble des documents liés à l\'article-->\r\n");
#nullable restore
#line 80 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                             for (int p = 0; p < documents.Count; p++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--<span>-->\r\n                                <div class=\"col-lg-4\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 5315, "\"", 5398, 1);
#nullable restore
#line 84 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 5321, documents[p].GetType().GetProperty("imageShow").GetValue(@documents[p],null), 5321, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"30\" loading=\"lazy\" />\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5480, "\"", 5567, 1);
#nullable restore
#line 85 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
WriteAttributeValue("", 5487, documents[p].GetType().GetProperty("downloadLink").GetValue(@documents[p],null), 5487, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 85 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                                                                                                                                          Write(documents[p].GetType().GetProperty("nameDoc").GetValue(@documents[p], null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n");
#nullable restore
#line 87 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 89 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 91 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Shared\_Articles.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
