using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Utilities;

namespace TheBakeryShopper.Models.Utilities
{
    public class UploadHelper
    {
        private string ConnectionString { get; set; }
        public UploadHelper(string _connectionString)
        {
            ConnectionString = _connectionString;
        }
        public string UploadFile(IFormFile file,int fileSpec)
        {
            
            string path="";
            int newId = 0;
            if (file == null || file.Length == 0)
                return null;
            DbPreCrudHelper dbPreCrudHelper = new DbPreCrudHelper(ConnectionString);

            try
            {
                switch (fileSpec)
                {
                    case (int)(UploadType.BakeryType):
                        newId = dbPreCrudHelper.GetLastItemId(fileSpec) + 1;
                        path = Path.Combine("D:/TheBakeryShopper/wwwroot/images/BakeType", newId.ToString() + ".jpg");
                        break;
                    case (int)(UploadType.BakeryProduct):
                        newId = dbPreCrudHelper.GetLastItemId(fileSpec) + 1;
                        path = Path.Combine("D:/TheBakeryShopper/wwwroot/images/BakeProduct", newId.ToString() + ".jpg");
                        break;
                    case (int)(UploadType.UserProfile):
                        path = Path.Combine("D:/TheBakeryShopper/wwwroot/images/ProfilePic", Path.GetFileName(file.FileName));
                        break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            try
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return path;
        }

    }
}
