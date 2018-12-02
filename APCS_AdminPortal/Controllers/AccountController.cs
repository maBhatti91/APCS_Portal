using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APCS_AdminPortal.Models;

namespace APCS_AdminPortal.Controllers
{
    [Route("accounts")]
    public class AccountController : Controller
    {
        public IActionResult GetAccounts()
        {
            return View();
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetUsers()
        {
            return View("Users");
        }

        [HttpGet]
        [Route("users/new")]
        public IActionResult CreateNewUser()
        {
            return View("NewUser");
        }
    }
}
