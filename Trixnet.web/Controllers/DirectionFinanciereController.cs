using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Views.DirectionFinanciere
{
    public class DirectionFinanciereController : Controller
    {

        //Teo Berguerre 04/11/2020
/*        public IActionResult Index()
        {
            return View();
        }*/

        [Route("/Index")]
        public IActionResult IndexDirectionFinanciere()
        {
            return View("Views/DirectionFinanciere/Index.cshtml");
        }

        [Route("/SI")]
        public IActionResult IndexSI()
        {
            return View("Views/DirectionFinanciere/SI/Index.cshtml");
        }

        [Route("/Financiere")]
        public IActionResult IndexFinance()
        {
            return View("Views/DirectionFinanciere/Financiere/Index.cshtml");
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

