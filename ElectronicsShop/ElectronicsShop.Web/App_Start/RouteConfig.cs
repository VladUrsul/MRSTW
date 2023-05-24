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
                name: "Category",
                url: "Categories/{action}/{id}",
                defaults: new { controller = "Categories", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Invoice",
               url: "Invoice/{action}/{id}",
               defaults: new { controller = "Invoice", action = "Invoice", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Orders",
              url: "Orders/{action}/{id}",
              defaults: new { controller = "Orders", action = "Orders", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "Login",
              url: "StoreLogin/{action}/{id}",
              defaults: new { controller = "StoreLogin", action = "StoreLogin", id = UrlParameter.Optional }
          );
        }
    }
}
