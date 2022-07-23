using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Progetto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "ordineperdata",
                "ordini/periodo/{anno}/{mese}",
                new { controller = "ordini", action = "PerData" },
                new { anno = @"\d{4}",  mese = "[1-9]|1[0-2]" } //regular expressions //anno deve avere 4 numeri //mese regex da 1 a 12
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
