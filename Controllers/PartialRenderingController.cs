using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBakeryShopper.Models;

namespace TheBakeryShopper.Controllers
{
    public class PartialRenderingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LinkRender(LinkButtonPartial btn)
        {
            return View("~/Views/Shared/BtnPartials/BtnPartial.cshtml", btn);
        }
        
    }
}