using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Controllers
{
    public class SecretariatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Teo Berguerre 25/09/2020 => Ajout Route Voyage + Documents
        [Route("/DirectionGenerale/Secretariat/Voyages.cshtml")]
        public IActionResult SecretariatVoyages()
        {
            return View("Views/DirectionGenerale/Secretariat/Voyages.cshtml");
        }

        [Route("/DirectionGenerale/Secretariat/Documents.cshtml")]
        public IActionResult SecretariatDocuments()
        {
            return View("Views/DirectionGenerale/Secretariat/Documents.cshtml");
        }

        [Route("/DirectionGenerale/Secretariat/LocationVoitures.cshtml")]
        public IActionResult SecretariatLocationVoitures()
        {
            return View("Views/DirectionGenerale/Secretariat/LocationVoitures.cshtml");
        }
    }
}
