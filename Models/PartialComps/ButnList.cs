using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.PartialComps
{
    public class ButnList
    {
        public List<LinkButtonPartial> LinkBtns;
        public ButnList()
        {
            LinkBtns = new List<LinkButtonPartial>() {
                new LinkButtonPartial() { LinkName="Login",ActName="LoginForm",CtrlName="Login"},
            new LinkButtonPartial() { LinkName="Signup",ActName="CreateNewUser",CtrlName="ResSetup"},
            new LinkButtonPartial() { LinkName="Add New Product",ActName="CreateProduct",CtrlName="ResSetup"},
            new LinkButtonPartial() { LinkName="Upload file",ActName="UploadFileForm",CtrlName="FileHandle"},
             new LinkButtonPartial() {LinkName="Add New Category",ActName="CreateProductType",CtrlName="ResSetup"} };

        }
    }
}
