using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Models.PartialComps;

namespace TheBakeryShopper.Components
{
    public class NavBarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ButnList btns = new ButnList();
            return View("NavBar", btns.LinkBtns);
        }
    }
}
