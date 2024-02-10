using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Common
{
    public class NavBarBtnList
    {
        public List<NavLinkBtn> BtnList;
        public NavBarBtnList()
        {
            BtnList = new List<NavLinkBtn>()
            {
                new NavLinkBtn() { LinkName="Login",ActName="LoginForm",CtrlName="Login"},
                new NavLinkBtn() { LinkName="Signup",ActName="CreateNewUser",CtrlName="CreateResource"},
                new NavLinkBtn() { LinkName="Add New Product",ActName="CreateProduct",CtrlName="CreateResource"},
                new NavLinkBtn() { LinkName="Upload file",ActName="UploadFileForm",CtrlName="FileHandle"},
                new NavLinkBtn() {LinkName="Add New Category",ActName="CreateProductType",CtrlName="CreateResource"} 
             };
        }
    }
}
