using System;
using Microsoft.Office.Core;
using ApplicationPPT = Microsoft.Office.Interop.PowerPoint.Application;
using Microsoft.Office.Interop.PowerPoint;
using ConvertApiDotNet;
using System.IO;
using System.Linq;
using Spire.Pdf;
using System.Text;
using System.Collections;
using Spire.Pdf.OPC;

/// <summary>
/// Avec l'utilisation de la librairie  Aspose.Slides.NET
/// On peut mettre un PPT,PPTX pour ensuite le transformer en 1 PDF ou  plusieurs images (jpeg,png,gif)
/// 
/// Le but ici : 
///     Prendre un ppt et le transformer en multiples images legeres afin de les afficher dans un carroussel
/// </summary>

namespace Trixnet.web.Services
{
    public class ConvertFilesClass
    {


        public void deleteFilesinDirectory(string path)
        {
            //Supprimer les images du Dossier Profiles pour eviter une surcharge de données
            string[] files = System.IO.Directory.GetFiles(path);
            if (files.Length != 0)
            {
                foreach (string file in files)
                {
                    try
                    {
                        System.IO.File.Delete(file);
                    }
                    catch (IOException ioExp)
                    {
                        Console.WriteLine(ioExp.Message);
                    }
                }
            }

        }

        //JPEG ou GIF car moins lourd 
        public void transformPPTIntoJPEG(string powerPoint, string pathDir, string type)
        {
            
            //marche mais ajoute du texte sur les images x) 
            /* using (Presentation presentation = new Presentation(powerPoint))
             {
                 foreach (ISlide slide in presentation.Slides)
                 {
                     //Creation d'une image non dimensionnée (max)
                     Bitmap btm = slide.GetThumbnail(1f, 1f);
                     //Sauvegarde de l'image sur le disque dans le fichier pathDir
                     btm.Save(pathDir + string.Format("Slide_{0}.jpg", slide.SlideNumber), System.Drawing.Imaging.ImageFormat.Jpeg);
                 }
             }*/
            if (System.IO.Directory.GetFiles(pathDir).Length == 0)
            {
                string typesOfFile = powerPoint.Substring(powerPoint.Length - 4, powerPoint.Length);
                switch (typesOfFile)
                {
                    case ".ppt":
                        ApplicationPPT pptApplication = new ApplicationPPT();
                        Presentation presentation = pptApplication.Presentations.Open(powerPoint, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);
                        int i = 0;
                        foreach (Microsoft.Office.Interop.PowerPoint.Slide objSlide in presentation.Slides)
                        {
                            objSlide.Export(pathDir + @"\Slide" + i + "." + type, type);
                            i++;
                        }
                        presentation.Close();
                        pptApplication.Quit();
                        break;
                        //Iterer que pour 3 .Take(3) car SpireFree ne convertis en img que les 3 premieres page du pdf
                    case ".pdf":
                       /* PdfDocument doc = new PdfDocument();
                        doc.LoadFromFile(powerPoint);
                        StringBuilder buffer = new StringBuilder();
                        IList < img > = new List<>();
                        foreach(PdfPageBase page in doc.Pages.Take(3))
                        {
                            images.Add(image);
                        }*/
                        break;
                    case ".doc":
                        break;
                    case "xls":
                        break;
                }
               
            }


            //Utilisation des commande line ? 
            /* string command = "unoconv -f png" + powerPoint;
             System.Diagnostics.Process.Start("CMD.exe", command);*/

            //Utilisation API ConvertAPI mais c'est limité !!
            /*var convertAPI = new ConvertApi("kCQp9fg7WVCIlC97");
            var convertToPNG = await convertAPI.ConvertAsync("ppt", "png",
                new ConvertApiFileParam("File",powerPoint)
                );
            await convertToPNG.SaveFilesAsync(pathDir);*/
        }

        public void compressFile(string dirPath)
        {
            var files = System.IO.Directory.GetFiles(dirPath);
            var optimizer = new ImageMagick.ImageOptimizer();
            if(files.Length > 0)
            {
                foreach (var file in files)
                {
                    try
                    {
                        optimizer.Compress(file);
                    }
                    catch(IOException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                
            }
        }

        public void ConvertFiles(string powerpoint, string dirPath, string type)
        {
            deleteFilesinDirectory(dirPath);
            transformPPTIntoJPEG(powerpoint,dirPath,type);
            compressFile(dirPath);
        }
    }

}
