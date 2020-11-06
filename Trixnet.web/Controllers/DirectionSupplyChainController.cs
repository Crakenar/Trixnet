using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Controllers
{
    public class DirectionSupplyChainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/DirectionSupplyChain")]
        public IActionResult SupplyChain()
        {
            return View("Views/DirectionSupplyChain/Index.cshtml");
        }


        [Route("/KAM")]
        public IActionResult KAM()
        {
            return View("Views/DirectionSupplyChain/KAM/KAM.cshtml");
        }

        [Route("/Logistique")]
        public IActionResult LogistiqueSite()
        {
            return View("Views/DirectionSupplyChain/LogistiqueSite/Logistique.cshtml");
        }

        [Route("/ManagementFournisseurs")]
        public IActionResult ManagementFournisseurs()
        {
            return View("Views/DirectionSupplyChain/ManagementFournisseurs/ManagementFournisseurs.cshtml");
        }

        [Route("/PlanifSCProjet")]
        public IActionResult PlanifSCProjet()
        {
            return View("Views/DirectionSupplyChain/PlanifSCProjet/PlanifSCProjet.cshtml");
        }
    }
}
