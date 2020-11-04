using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Controllers
{
    public class DirectionTechniqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Teo Berguerre 04/11/2020
        [Route("/Index.cshtml")]
        public IActionResult Technique()
        {
            return View("Views/DirectionTechnique/Index.cshtml");
        }

        [Route("/STC")]
        public IActionResult STC()
        {
            return View("Views/DirectionTechnique/STC/SupportTechniqueClient.cshtml");
        }


        [Route("/ElectroniqueASIC")]
        public IActionResult ElectroniqueASIC()
        {
            return View("Views/DirectionTechnique/ElectroniqueASIC/ElectroniqueASIC.cshtml");
        }


        [Route("/Mecatronique")]
        public IActionResult Mecatronique()
        {
            return View("Views/DirectionTechnique/Mecatronique/Mecatronique.cshtml");
        }

        [Route("/ProjetsProduits")]
        public IActionResult ProjetsProduits()
        {
            return View("Views/DirectionTechnique/ProjetsProduits/ProjetsProduits.cshtml");
        }


        [Route("/QualifTest")]
        public IActionResult QualifTest()
        {
            return View("Views/DirectionTechnique/QualifTest/QualifTest.cshtml");
        }


        [Route("/SystemDesignOptimisation")]
        public IActionResult SystemDesignOptimisation()
        {
            return View("Views/DirectionTechnique/SystemDesignOptimisation/SystemDesignOptimisation.cshtml");
        }
    }
}
