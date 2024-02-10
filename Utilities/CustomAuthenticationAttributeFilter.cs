using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.DbLayer.Crud;

namespace TheBakeryShopper.Utilities
{
    public class ShopperAuthorizationActionFilter: ActionFilterAttribute, IActionFilter
    {
        private AuthorizationDbContext FilterDbContext { get; set; }
        public ShopperAuthorizationActionFilter(AuthorizationDbContext dbContext)
        {
            FilterDbContext = dbContext;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {


        }

    }
}   
    

