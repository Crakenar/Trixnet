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


        //Direction Generale
        [Route("/DirectionGenerale")]
        public IActionResult DirectionGenerale()
        {
            return View("Views/DirectionGenerale/IndexDirectionGenerale.cshtml");
        }

        //RH
        [Route("/RH")]
        public IActionResult RH()
        {
            return View("Views/DirectionGenerale/RH/RH.cshtml");
        }


        //Infras & HSE
        [Route("/InfraHSE/InfraHSE.cshtml")]
        public IActionResult InfraHSE()
        {
            return View("Views/DirectionGenerale/InfraHSE/InfraHSE.cshtml");
        }


        //Secretariat
        /* [Route("Trixnet.web/DirectionGeneraleController/Secretariat")]*/
        [Route("/Secretariat")]
        public IActionResult Secretariat()
        {
            return View("Views/DirectionGenerale/Secretariat/Secretariat.cshtml");
        }

       
    }
}
