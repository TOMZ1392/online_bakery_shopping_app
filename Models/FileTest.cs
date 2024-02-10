using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models
{
    public class FileTest
    {
        public int FileId { get; set; }
        public IFormFile FileName { get; set; }
    }
}
