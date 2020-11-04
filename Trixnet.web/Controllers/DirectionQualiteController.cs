using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Trixnet.web.Controllers
{
    public class DirectionQualiteController : Controller
    {
        [Route("/Qualite")]
        public IActionResult Index()
        {
            return View("Views/DirectionQualite/Qualite.cshtml");
        }
    }
}
