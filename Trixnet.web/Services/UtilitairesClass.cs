using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            if(myFiles == null)
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
        /// 
        /// </summary>
        /// <param name="Files"></param>
        /// <returns></returns>
        /// 
        public List<Object> setDocumentsArticle(Object Files)
        {
            List<Object> arr = new List<Object>();
            IEnumerable myDocuments = Files as IEnumerable;
            if(myDocuments == null)
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

        public List<string> test(string x)
        {
            switch (x)
            {
                case "Article":
                    break;
                case "ArticleSecretariat":
                    break;
                case "ArticleRH":
                    break;
                case "ArticleSI":
                    break;
            }
            return null;
        }
    }
}

