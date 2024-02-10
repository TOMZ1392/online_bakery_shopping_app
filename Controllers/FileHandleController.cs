using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBakeryShopper.Models;

namespace TheBakeryShopper.Controllers
{
    public class FileHandleController : Controller
    {
        public IActionResult UploadFileForm()
        {
            return View("~/Views/CreateResources/FileUpload.cshtml");
        }
        [HttpPost]
        public IActionResult UploadFileForm(FileTest fileDet)
        {
            if (UploadFile(fileDet.FileName) == 0)
            {

                return View("~/Views/CreateResources/FileUpload.cshtml");
            }
            else return View();
        }
        
        public  int UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return 1;

            var path = Path.Combine("D:/TheBakeryShopper/uploaded",Path.GetFileName(file.FileName));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                 file.CopyToAsync(stream);
            }

            return 0;
        }

    }
}