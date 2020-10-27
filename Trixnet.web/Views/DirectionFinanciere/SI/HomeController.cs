using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Views.DirectionFinanciere.SI
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/DirectionFinanciere/SI/Projets.cshtml")]
        public IActionResult Projets()
        {
            return View("Views/DirectionFinanciere/SI/Projets.cshtml");
        }

        [Route("/DirectionFinanciere/SI/Help.cshtml")]
        public IActionResult Help()
        {
            return View("Views/DirectionFinanciere/SI/Help.cshtml");
        }

        [Route("/DirectionFinanciere/SI/ArchivesProjets.cshtml")]
        public IActionResult ArchivesProjets()
        {
            return View("Views/DirectionFinanciere/SI/ArchivesProjets.cshtml");
        }

        [Route("/blogpost/{id}")]
        public IActionResult DetailsProjet()
        {
            return View("Views/BlogPost.cshtml");
        }

    }
}
