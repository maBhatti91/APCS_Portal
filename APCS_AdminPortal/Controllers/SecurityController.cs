using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APCS_AdminPortal.Models;

namespace APCS_AdminPortal.Controllers
{
    [Route("")]
    public class SecurityController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        
    }
}
