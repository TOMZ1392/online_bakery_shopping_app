using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TheBakeryShopper.Components 
{
    public class RightNavBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View("RightNavBar");
        }
    }
}
