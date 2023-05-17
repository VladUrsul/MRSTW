using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;
using System.Web.Security;
using System.Web.SessionState;
using ElectronicsShop.Data.Contexts;
using ElectronicsShop.Data.Repositories;
using Unity.Injection;
using ElectronicsShop.Domain.Entities;
using Microsoft.Ajax.Utilities;
using System.Configuration;
using ElectronicsShop.BusinessLogic.Services;
using System.Security.Principal;

namespace ElectronicsShop.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
            BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);

            // Configure the connection string
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ElectronicsShopDb"].ConnectionString;

            // Register ShopDbContext
            Database.SetInitializer<ShopDbContext>(null);
            var dbContext = new ShopDbContext(connectionString);
            dbContext.Database.Initialize(true);

            // Create a new Unity Container instance
            var container = new UnityContainer();

            // Register the ShopDbContext with the DI container
            container.RegisterType<ShopDbContext>(new InjectionConstructor(ConfigurationManager.ConnectionStrings["ElectronicsShopDb"].ConnectionString));

            // Register the UserRepository with the DI container, with the ShopDbContext dependency injected
            container.RegisterType<UserRepository>(new InjectionConstructor(typeof(ShopDbContext)));

            var userRepository = new UserRepository(new ShopDbContext());
            var currentUserService = new CurrentUserService(userRepository);
            HttpContext.Current.Application["ICurrentUserService"] = currentUserService;

            // Set the MVC dependency resolver to use Unity
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine
            {
                PartialViewLocationFormats = new string[]
                {
                    "~/Views/{1}/{0}.cshtml",
                    "~/Views/Shared/{0}.cshtml"
                },
                ViewLocationFormats = new string[]
                {
                    "~/Views/{1}/{0}.cshtml",
                    "~/Views/Shared/{0}.cshtml"
                }
            });
        }
    }
}