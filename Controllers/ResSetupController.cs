using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheBakeryShopper.Models;
using TheBakeryShopper.Models.User;

namespace TheBakeryShopper.Controllers
{
    public class ResSetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            BakeryItem item = new BakeryItem();
            return View("~/Views/CreateResources/CreateProduct.cshtml",item);
        }
        [HttpPost]
        public IActionResult CreateProduct(BakeryItem item)
        {
            if (UploadFile(item.ImgPath) == 0)
            {

                return View("~/Views/CreateResources/FileUpload.cshtml");
            }
            else return View();
            
        }

        public int UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return 1;

            var path = Path.Combine("D:/TheBakeryShopper/uploaded", Path.GetFileName(file.FileName));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }

            return 0;
        }

        public IActionResult CreateProductType()
        {
            BakeryType item = new BakeryType();
        
            return View("~/Views/CreateResources/CreateProductType.cshtml", item);
        }
        [HttpPost]
        public IActionResult CreateProductType(BakeryType item)
        {
            return View();
        }
        public IActionResult CreateNewUser()
        {
            return View("~/Views/CreateResources/SignUpNewUser.cshtml");
        }
        [HttpPost]
        public IActionResult CreateNewUser(CustomerDetails customer)
        {
            return View();
        }

    }
}