using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APCS_AdminPortal.Models;

namespace APCS_AdminPortal.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("home")]
        public IActionResult Home()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("not-implemented")]
        public IActionResult NotImplemented()
        {
            return View("Error/404Page");
        }
    }
}
