using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ElectronicsShop.Web
{
    public class RouteConfig
    {
        private static object namespaces;

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ElectronicsShop.Web.Areas.AdminPanel.Controllers" }
            );

            routes.MapRoute(
                name: "Store",
                url: "Store/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", area = "Store", id = UrlParameter.Optional },

                namespaces: new[] { "ElectronicsShop.Web.Areas.AdminPanel.Controllers" }
        );

            routes.MapRoute(
                  name: "Login",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Store", action = "Login", area = "Store", id = UrlParameter.Optional },

                  namespaces: new[] { "ElectronicsShop.Web.Areas.AdminPanel.Controllers" }
          );
        }
    }
}
