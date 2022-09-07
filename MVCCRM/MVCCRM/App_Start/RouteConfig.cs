using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCCRM.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.IRouter(
            //    name: "Default",
            //   // url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Dashboard", action = "Index" }
           // );
        }
    }
}
