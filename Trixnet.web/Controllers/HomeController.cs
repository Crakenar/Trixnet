﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using OrchardCore.Admin.Controllers;
using OrchardCore.Data;
using OrchardCore.Environment.Shell;
using SixLabors.ImageSharp;

using Trixnet.web.Models;
using Lucene.Net.Store;

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
            string typeSortie = "GIF";
            string pathDir = "wwwroot/img/Profiles/";
            string path = "C:\\Users\\BURINDUS44\\Documents\\Webmaster\\Trixnet - Copie\\Trixnet.web\\Trixnet.web\\wwwroot\\img\\Profiles\\";
            string ppt = "C:/Users/BURINDUS44/Documents/Webmaster/Trixnet - Copie/Trixnet.web/Trixnet.web/wwwroot/img/RH/LiensPratiques/Bonnes_pratiques_utilisation_du mail(1).pptx";
            string ppt2 = "C:\\Users\\BURINDUS44\\Documents\\Webmaster\\Trixnet - Copie\\Trixnet.web\\Trixnet.web\\wwwroot\\img\\RH\\LiensPratiques\\HVI-2013312_V2(1).ppt";
            Services.ConvertFilesClass utils = new Services.ConvertFilesClass();
            utils.ConvertFiles(ppt2, path, typeSortie);
        }

        [Route("/")]
        public IActionResult Index()
        {
            // var results = _connection.trix_Document.ToList();
            //recuperer les images pour le caroussel
            string pathDir = "wwwroot/img/Profiles/";
            string[] files = System.IO.Directory.GetFiles(pathDir);
            ViewBag.ImageCaroussel = files; //pas ouf, à refaire ???
            return View();
        }

        //Derniere modif Teo Berguerre 08/10/2020

        //Liens Pratiques
        [Route("/LiensPratiques/LiensPratiques.cshtml")]
        public IActionResult LiensPratiques()
        {
            return View("Views/LiensPratiques/LiensPratiques.cshtml");
        }


        //Direction Generale
        [Route("/DirectionGenerale/IndexDirectionGenerale.cshtml")]
        public IActionResult Secretariat()
        {
            return View("Views/DirectionGenerale/IndexDirectionGenerale.cshtml");
        }

        //Direction Financiere donc les 'finances' et le departement SI
        [Route("/DirectionFinanciere/Index.cshtml")]
        public IActionResult IndexDirectionFinanciere()
        {
            return View("Views/DirectionFinanciere/Index.cshtml");
        }

        [Route("/DirectionFinanciere/SI/Index.cshtml")]
        public IActionResult IndexSI()
        {
            return View("Views/DirectionFinanciere/SI/Index.cshtml");
        }

        [Route("/DirectionFinanciere/Financiere/Index.cshtml")]
        public IActionResult IndexFinance()
        {
            return View("Views/DirectionFinanciere/Financiere/Index.cshtml");
        }
        ///////////

        //Teo Berguerre 21/09/2020

        [Route("/DirectionIndustrielle/Index.cshtml")]
        public IActionResult Indu()
        {
            return View("Views/DirectionIndustrielle/Index.cshtml");
        }

        [Route("/DirectionSupplyChain/Index.cshtml")]
        public IActionResult SupplyChain()
        {
            return View("Views/DirectionSupplyChain/Index.cshtml");
        }


        [Route("/DirectionTechnique/Index.cshtml")]
        public IActionResult Technique()
        {
            return View("Views/DirectionTechnique/Index.cshtml");
        }


        [Route("/DirectionQualite/Index.cshtml")]
        public IActionResult Qualite()
        {
            return View("Views/DirectionQualite/Index.cshtml");
        }

        [Route("/Formulaires/Formulaire.cshtml")]
        public IActionResult Formulaires()
        {
            return View("Views/Formulaires/Formulaire.cshtml");
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
