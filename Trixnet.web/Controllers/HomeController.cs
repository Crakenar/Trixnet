using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Trixnet.web.Models;

namespace Trixnet.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectionStringClass _connection;

        public HomeController(ConnectionStringClass connection)
        {
            _connection = connection;
            /* Transforme le .ppt en multiples png (1 slide = 1 image)
             Probleme :
             Chemin en dur / Objectif => lier cela à OrchardCore ?
             Combien de powerpoint doit-on afficher ? Si c'est 1 seul créer par l'admin ou il met plusieurs ppt et je dois effectuer l'opération ?             
             */
            string typeSortie = "gif";
            //string pathDir = "wwwroot/img/Profiles/";
            string path = "wwwroot/img/Profiles/";
            //string ppt = "C:/Users/BURINDUS44/Documents/Webmaster/Trixnet - Copie/Trixnet.web/Trixnet.web/wwwroot/img/RH/LiensPratiques/Bonnes_pratiques_utilisation_du mail(1).pptx";
            string ppt2 = "wwwroot/img/RH/LiensPratiques/HVI-2013312_V2(1).ppt";
            if(System.IO.Directory.GetFiles(path).Length == 0)
            {
                Services.ConvertFilesClass utils = new Services.ConvertFilesClass();
                utils.ConvertFiles(ppt2, path, typeSortie);
            }
           
        }

        [Route("/")]
        public IActionResult Index()
        {
            string val1 = ConfigurationManager.variablesSettings["App:LinkHelpHSE:Value"];
            ViewBag.LinkHSE = val1;
            // var results = _connection.trix_Document.ToList();
            //recuperer les images pour le caroussel
            string pathDir = "wwwroot/img/Profiles/";
            string[] files = System.IO.Directory.GetFiles(pathDir);
            ViewBag.ImageCaroussel = files; //pas ouf, à refaire ???
            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View("Views/Home/Contact.cshtml");
        }

        //Derniere modif Teo Berguerre 08/10/2020

        //Liens Pratiques
        [Route("/LiensPratiques")]
        public IActionResult LiensPratiques()
        {
            string val1 = ConfigurationManager.variablesSettings["App:LinkHelpHSE:Value"];
            ViewBag.LinkHSE = val1;
            return View("Views/LiensPratiques/LiensPratiques.cshtml");
        }


        [Route("/Formulaires")]
        public IActionResult Formulaires()
        {
            return View("Views/Formulaires/Formulaire.cshtml");
        }



        [Route("/Products")]
        public IActionResult Products()
        {
            return View("Views/Products/Products.cshtml");
        }

        [Route("/Org")]
        public IActionResult Organigramme()
        {
            return View("Views/Home/Organigramme.cshtml");
        }



        //Fonction annuaire Teo berguerre 12/10/2020
        public IActionResult Annuaire(string search, string optionAnnuaire)
        {
            //ne sauvegarde pas les parametres envoyés par le input si refresh de la page en faisant Enter sur l'URL
            if (optionAnnuaire == "eDir")
            {
                var url = "https://ddm.corp.thales/eDir/portals/std/index-portal.jsp?ps="; //url Annuaire eDir
                return Redirect(url + search);
            }
            else //if (optionAnnuaire == "Trixell")
            {
                var results = _connection.Annuaire.ToList();
                if (!String.IsNullOrEmpty(search))
                {
                    ViewBag.ErrorMessage = "Aucune correspondance avec l'annuaire";
                    results = results.FindAll(r => r.Nom.Contains(search.ToUpper()) || r.Nom.Contains(search.ToLower())
                    || r.Prenom.Contains(search.ToUpper()) || r.Prenom.Contains(search.ToLower())
                    || r.Email.Contains(search.ToUpper()) || r.Email.Contains(search.ToLower())
                    || r.Tel.Contains(search)
                    );
                    return View(results);
                }
                else
                {

                    return View(results);
                }
            }
        }
    }
}
