using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Controllers
{
    public class DirectionIndustrielleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Direction Industrielle
        [Route("/IngenierieProduits")]
        public IActionResult IngenierieProduits()
        {
            return View("Views/DirectionIndustrielle/IngenierieProduit/IngenierieProduits.cshtml");
        }

        [Route("/BackEnd")]
        public IActionResult BackEnd()
        {
            return View("Views/DirectionIndustrielle/BackEnd/BackEnd.cshtml");
        }

        [Route("/FrontEnd")]
        public IActionResult FrontEnd()
        {
            return View("Views/DirectionIndustrielle/FrontEnd/FrontEnd.cshtml");
        }

        [Route("/WeekEnd")]
        public IActionResult WeekEnd()
        {
            return View("Views/DirectionIndustrielle/WeekEnd/WeekEnd.cshtml");
        }

        [Route("/Maintenance")]
        public IActionResult Maintenance()
        {
            return View("Views/DirectionIndustrielle/Maintenance/Maintenance.cshtml");
        }

        [Route("/ProcedesMethodes")]
        public IActionResult ProcedesMethodes()
        {
            return View("Views/DirectionIndustrielle/ProcedesMethodes/ProcedesMethodes.cshtml");
        }

        [Route("/SAV")]
        public IActionResult SAV()
        {
            return View("Views/DirectionIndustrielle/SAV/SAV.cshtml");
        }
    }
}
