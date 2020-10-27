using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Views.DirectionGenerale
{
    public class DirectionGeneraleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Teo Berguerre 25/09/2020 => Add route pour voyages.cshtml


        //RH
        [Route("/DirectionGenerale/RH/RH.cshtml")]
        public IActionResult RH()
        {
            return View("Views/DirectionGenerale/RH/RH.cshtml");
        }


        //Infras & HSE
        [Route("/DirectionGenerale/InfraHSE/InfraHSE.cshtml")]
        public IActionResult InfraHSE()
        {
            return View("Views/DirectionGenerale/InfraHSE/InfraHSE.cshtml");
        }


        //Secretariat
        [Route("/DirectionGenerale/Secretariat/Secretariat.cshtml")]
        public IActionResult Secretariat()
        {
            return View("Views/DirectionGenerale/Secretariat/Secretariat.cshtml");
        }

       
    }
}
