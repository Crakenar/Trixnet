using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Views.DirectionFinanciere
{
    public class DirectionFinanciereController : Controller
    {

        //Teo Berguerre 21/09/2020
        public IActionResult Index()
        {
            return View();
        }

        [Route("/DirectionFinanciere/Projets.cshtml")]
        public IActionResult Projets()
        {
            return View("Views/DirectionFinanciere/SI/Projets.cshtml");
        }

        [Route("/DirectionFinanciere/Help.cshtml")]
        public IActionResult Help()
        {
            return View("Views/DirectionFinanciere/SI/Help.cshtml");
        }

    }
}

