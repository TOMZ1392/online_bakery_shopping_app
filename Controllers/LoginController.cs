using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBakeryShopper.Models;

namespace TheBakeryShopper.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginForm()
        {


            return View("~/Views/Login/LoginForm.cshtml");
        }
        [HttpPost]
        public IActionResult LoginForm(UserDetails user)
        {
            // do login stuff here
            return View();
        }
    }
}