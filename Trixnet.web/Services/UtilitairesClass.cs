using OrchardCore.ContentManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;


namespace Trixnet.web.Services
{
    public class UtilitairesClass
    {
        // Téo Berguerre 14/10/2020 j'étais trop chaud cherchais pas à comprendre même toi mon moi du futur

        /// <summary>
        /// 
        /// </summary>
        class image
        {
            public string imageShow { get; set; }
            public string downloadLink { get; set; }
            public string nameDoc { get; set; }
        }


        /// <summary>
        /// Cette fonction permet d'afficher l'image principale d'un article.
        /// Elle prend en parametre l'ensemble des images des articles articles.Content.Article.Media.Paths (Objet d'Array d'objet)
        /// Pour chaque image on recupere son type cad qu'on regarde les 3 derniers charactere du Paths
        /// Si ce n'est pas une image/gif... alors on met une image par default sinon on utilise l'image courante
        ///
        /// </summary>
        /// <param name="File">File is an object</param>
        /// <returns>List of Strings</returns>

        public List<string> setImageTitleArticle(Object File)
        {
            List<string> arr = new List<string>();
            IEnumerable myFiles = File as IEnumerable;
            if (myFiles == null)
            {
                arr.Add("img/bg-masthead.jpg");
            }
            else
            {
                foreach (var images in myFiles)
                {
                    string type = null; //extension de l'image
                    string imgShow = null; //chemin de l'image que l'on va afficher
                    string path = "../../../../Media/"; //chemin dur où orchard enregistre les images

                    string stopAt = ".";
                    int indexChar = images.ToString().IndexOf(stopAt, StringComparison.Ordinal);
                    type = images.ToString().Substring(indexChar);
                    if (images.ToString() == null || images.ToString() == "" || String.Compare(type, ".pdf") == 0 || String.Compare(type, ".word") == 0 || String.Compare(type, ".ppt") == 0 || String.Compare(type, ".excel") == 0)
                    {
                        imgShow = "img/bg-masthead.jpg";
                    }
                    else
                    {
                        imgShow = path + images.ToString();
                    }
                    arr.Add(imgShow);
                }
            }

            return arr;
        }


        /// <summary>
        /// Cette fonction permet de determiner si un documents est un pdf, excel, word...
        /// On pourrait utiliser map = new Dictionnary <string,string>() {
        ///     {".pdf","/img/pdf.jpeg"}
        ///     ....
        /// }
        /// pour ensuite envoyer une image avec son icone et son lien pour telecharger
        /// </summary>
        /// <param name="Files"></param>
        /// <returns>Object(image)</returns>
        /// 
        public List<Object> setDocumentsArticle(Object Files)
        {
            List<Object> arr = new List<Object>();
            IEnumerable myDocuments = Files as IEnumerable;
            if (myDocuments == null)
            {
            }
            else
            {
                foreach (var docs in myDocuments)
                {
                    string path = "../../../../Media/"; //chemin dur où orchard enregistre les images
                    string type = null; //extension du doc
                    string docShow = null; //chemin de du documents que l'on va afficher
                    string stopAt = ".";
                    int indexChar = docs.ToString().IndexOf(stopAt, StringComparison.Ordinal);
                    type = docs.ToString().Substring(indexChar);

                    if (String.Compare(type, ".pdf") == 0)
                    {
                        docShow = "../../../../img/pdf.jpeg";
                    }
                    else if ((String.Compare(type, ".word") == 0))
                    {
                        docShow = "../../../../img/word.jpeg";
                    }
                    else if ((String.Compare(type, ".ppt") == 0))
                    {
                        docShow = "../../../../img/powerpoint.jpg";
                    }
                    else if ((String.Compare(type, ".excel") == 0))
                    {
                        docShow = "../../../../img/excel.png";
                    }
                    arr.Add(new image { imageShow = docShow, downloadLink = path + docs, nameDoc = docs.ToString() });
                }
            }

            return arr;
        }

        /// <summary>
        /// Teo Berguerre 27 Octobre 2020
        /// Cette fonction recupere l'image princpale d'un article en fonction de son type : ArticleRH, ArticleSI...
        ///  
        /// </summary>
        /// <param name="type"></param>
        /// <param name="articles"></param>
        /// <returns>List<string>()</returns>

        public List<string> getImagePrincipale(string type, ContentItem articles)
        {
            var map = new Dictionary<string, List<string>>();
            List<string> imagesPrincipales = new List<string>();
            string defaultImage = "../../img/bg-masthead.jpg";
            switch (type)
            {
                case "Article":
                    map.Add(type, setImageTitleArticle(articles.Content.Article.Media.Paths));
                    break;
                case "ArticleSecretariat":
                    map.Add(type, setImageTitleArticle(articles.Content.ArticleSecretariat.MediaArticle.Paths));
                    break;
                case "ArticleRH":
                    map.Add(type, setImageTitleArticle(articles.Content.ArticleRH.MediaArticle.Paths));
                    break;
                case "ArticleSI":
                    map.Add(type, setImageTitleArticle(articles.Content.ArticleSI.MediaArticle.Paths));
                    break;
            }
            if (map.TryGetValue(type, out List<string> commande))
            {
                if (commande.Count == 0)
                {
                    imagesPrincipales.Add(defaultImage);
                }
                else
                {
                    imagesPrincipales = commande;
                }
            }
            return imagesPrincipales;
        }

    }
}

