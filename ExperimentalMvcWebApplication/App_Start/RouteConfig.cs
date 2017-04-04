using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExperimentalMvcWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // custom route1
            routes.MapRoute(
                name: "Custom1",
                url: "home/index/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            // student routes1
            routes.MapRoute(
                name: "StudentRetrieve",
                url: "student/index/{id}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
                );

            // student routes2
            routes.MapRoute(
                name: "StudentDelete",
                url: "student/delete/{id}",
                defaults: new { controller = "Student", action = "Delete", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
