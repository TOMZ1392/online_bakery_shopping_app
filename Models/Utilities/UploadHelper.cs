using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Utilities
{
    public class UploadHelper
    {

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

    }
}
