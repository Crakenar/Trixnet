#pragma checksum "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3404390a3313fc76f403639742b77cda3543e010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Trixnet.web.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Trixnet.web.Pages.Home
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
#line 3 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
using OrchardCore.ContentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
using OrchardCore.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
using OrchardCore.Widgets;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3404390a3313fc76f403639742b77cda3543e010", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966f79433173acc870926076680348238a8b7f4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DirectionFinanciere/SI/Help.cshtml"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/wwwroot/js/rss.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
  
    //PAGE D'ACCUEIL
    //ViewData["Title"] = "Accueil";
    var heure = DateTime.Now.ToString();
    int how_many_retreived = 3;
    /*Tableaux contenant les items en fonctions de leur ContentType */
    var tab_articles = await Orchard.GetRecentContentItemsByContentTypeAsync("Article", how_many_retreived);
    var x = Orchard.GetContentItemByIdAsync("4qq5pg1x8n9n75w5a2rhg313cb");
    //var tab_news = tab_articles + tab_projets;

    /*Ensemble des items TODO : Trouver un razor help pour tout recuperer d'un coup
    Ici : un tableau de tableau d'objets => articles[tab_articles[Objets]] */
    var tab_AllArticles = new System.Collections.ArrayList();
    tab_AllArticles.Add(tab_articles);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
Write(Orchard.ConsoleLog(tab_articles));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Body -->
<section class=""showcase"">
    <div class=""container-fluid p-0"">
        <div class=""row no-gutters"">

            <!-- Menu de Droite -->
            <div class=""col-lg-3 order-lg-3 showcase-img bg-white"">
                <div class=""showcase-text"" style=""padding: 0"">


                    <!-- Tableau de bord -->
                    <div class=""SectionHB SectionGD AppSection"">
                        <div class=""titreSection"">
                            <h2 class=""jaapooki"" style=""font-size: 1.5rem; color: rgb(19, 133,203);""><i class=""fas fa-cloud-sun""></i>  Tableau de bord</h2>
                        </div>

                        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                            <ol class=""carousel-indicators"">
                                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""bg-blue active"" style=""background-color: rgb(19, 133,203)""></li>
                                <li");
            WriteLiteral(@" data-target=""#carouselExampleIndicators"" data-slide-to=""1"" class=""bg-blue"" style=""background-color: rgb(19, 133,203)""></li>
                            </ol>
                            <div class=""carousel-inner"">
                                <div class=""carousel-item tableauDeBordItem active"">
                                    <h2>Moirans</h2>
                                    <p>");
#nullable restore
#line 52 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
                                  Write(heure);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <p>Ensoleillé</p>
                                    <div class=""meteoContainer"">
                                        <i class=""fas fa-sun meteoPicto""></i>
                                        <h2 class=""temperature"">20°</h2>
                                    </div>
                                    <!--<img class=""d-block w-100"" src=""img/météo.PNG"" alt=""First slide"">-->
                                </div>
                                <div class=""carousel-item tableauDeBordItem"">
                                    <h2>Météo SI</h2>
                                    <div class=""cadreEtat"">
                                        <p class=""TexteEtat"">Aucun incident à déclarer actuellement.</p>
                                    </div>
                                    <!--<img class=""d-block w-100"" src=""img/météoSI.png"" alt=""Second slide"">-->
                                </div>
                            </div>
                ");
            WriteLiteral(@"            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                                <span aria-hidden=""true""><i class=""fas fa-angle-left"" style=""color: rgb(19, 133,203); font-size: 25px;""></i></span>
                                <span class=""sr-only"">Previous</span>
                            </a>
                            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                <span aria-hidden=""true"">
                                    <i class=""fas fa-angle-right"" style=""color : rgb(19, 133,203); font-size: 25px;""></i>
                                </span>
                                <span class=""sr-only"">Next</span>
                            </a>
                        </div>
                    </div>

                    <!-- Applications -->
                    <div class=""SectionHB SectionGD AppSection"">
                        <div clas");
            WriteLiteral(@"s=""titreSection"">
                            <h2 class=""jaapooki"" style=""font-size: 1.5rem; color: rgb(19, 133,203);""><i class=""fas fa-th-large""></i>  Application</h2>
                        </div>
                        <ul class=""nav flex-column"">
                            <li class=""app-item"">
                                <a class=""app-link"">Accueil</a>
                            </li>
                            <li class=""app-item"">
                                <a class=""app-link"">Actualités</a>
                            </li>
                            <li class=""app-item"">
                                <a class=""app-link"">Support</a>
                            </li>
                            <li class=""app-item"">
                                <a class=""app-link"">Fonctions</a>
                            </li>
                            <li class=""app-item"">
                                <a class=""app-link"">People Online</a>
                            </li>
 ");
            WriteLiteral(@"                           <li class=""app-item"">
                                <a class=""app-link"">Messagerie</a>
                            </li>
                        </ul>
                    </div>

                    <!-- Support -->
                    <div class=""SectionHB SectionGD AppSection"">
                        <div class=""titreSection"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3404390a3313fc76f403639742b77cda3543e01011320", async() => {
                WriteLiteral(@"
                                <h2 class=""jaapooki"" style=""font-size: 1.3rem; color: rgb(19, 133,203);"">
                                    <i class=""fas fa-headset""></i>      Support informatique <i class=""fas fa-angle-right""></i>
                                </h2>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                </div>
            </div>

            <!-- Caroussel  -->
            <div class=""col-lg-9 order-lg-2 bg-white"">

                <div id=""carouselExampleControls"" class=""carousel slide SectionHB SectionGD"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img class=""d-block w-100"" src=""img/bg-masthead.jpg"" alt=""First slide"">
                            <div class=""carousel-caption d-none d-md-block"">
                                <h5>Bientot un nouvel intranet !</h5>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
                            </div>
                        </div>
                        <div class=""carousel-item"">
                            <img class");
            WriteLiteral(@"=""d-block w-100"" src=""img/bg-showcase-2.jpg"" alt=""Second slide"">
                            <div class=""carousel-caption d-none d-md-block"">
                                <h5>Bientot un nouvel intranet !</h5>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
                            </div>
                        </div>
                    </div>
                    <a class=""archive-btn"" href=""PageSecretariat.html"">
                        <i class=""fas fa-archive"" style=""font-size: 1,4rem;""> <span class=""font-special"">Archive</span> </i>
                    </a>
                    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>");
            WriteLiteral(@"
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>

                <!-- Section Actualités -->

                <div class=""bg-white"">
                    <div class=""trixell-X AppSection SectionGD SectionHB"">
                        <div class=""container showcase-text"">
                            <h2 class=""jaapooki"" style=""font-size: 1.5rem; color: rgb(19, 133,203);""><i class=""fas fa-newspaper""></i>   Actualités</h2>
                        </div>

");
#nullable restore
#line 163 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
                         foreach (var articles in tab_articles)
                        {
                            string articleText = articles.Content.MarkdownBodyPart.Markdown;
                            //Si le texte de l'article est supérieur a 200 caractere alors il est rogné pour l'affichage sur l'accueil
                            if (articleText.Length > 200)
                            {
                                articleText = articleText.Substring(0, 200);
                            }
                            //Image par défaut si aucun média n'est séléctionné dnas l'article
                            //string imgLink = "img/bg-masthead.jpg";
                            //string imgLink = articles.ContentItem
                            string imgLink = null;
                                                if (imgLink == null || imgLink == "")
                            {
                                imgLink = "img/bg-masthead.jpg";
                            }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"container showcase-text\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 10347, "\"", 10387, 2);
            WriteAttributeValue("", 10354, "/blogpost/", 10354, 10, true);
#nullable restore
#line 187 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10364, articles.ContentItemId, 10364, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"row link-news\">\r\n                                    <div class=\"col-lg-4 text-white img-news\"");
            BeginWriteAttribute("style", " style=\"", 10490, "\"", 10532, 4);
            WriteAttributeValue("", 10498, "background-image:", 10498, 17, true);
            WriteAttributeValue(" ", 10515, "url(\'", 10516, 6, true);
#nullable restore
#line 188 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10521, imgLink, 10521, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10529, "\');", 10529, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                    <div class=\"col-lg-8 text-news\">\r\n                                        <h2>");
#nullable restore
#line 190 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
                                       Write(articles.DisplayText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p class=\"lead mb-0\" style=\"text-justify: distribute;\">");
#nullable restore
#line 191 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
                                                                                          Write(articleText);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 195 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3404390a3313fc76f403639742b77cda3543e01019625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 243 "C:\Users\BURINDUS44\Documents\Webmaster\Trixnet - Copie\Trixnet.web\Trixnet.web\Views\Home\Index.cshtml"
 
    [FromRoute]
    public string Slug { get; set; }


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
