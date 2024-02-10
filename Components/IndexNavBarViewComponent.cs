using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Models.Common;

namespace TheBakeryShopper.Components
{
    public class IndexNavBarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            NavBarBtnList btnList = new NavBarBtnList();
            return View("IndexBtnBar", btnList.BtnList);
        }
    }
}
