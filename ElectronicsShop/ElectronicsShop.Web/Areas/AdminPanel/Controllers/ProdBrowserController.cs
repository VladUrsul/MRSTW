using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class ProdBrowserController : Controller
    {
        public ActionResult ProdBrowserLaptops()
        {
            return View("~/Areas/AdminPanel/Views/ProdBrowser/ProdBrowserLaptops.cshtml");
        }
        public ActionResult ProdBrowserDesktops()
        {
            return View("~/Areas/AdminPanel/Views/ProdBrowser/ProdBrowserDesktops.cshtml");
        }
        public ActionResult ProdBrowserPhones()
        {
            return View("~/Areas/AdminPanel/Views/ProdBrowser/ProdBrowserPhones.cshtml");
        }
        public ActionResult ProdBrowserOthers()
        {
            return View("~/Areas/AdminPanel/Views/ProdBrowser/ProdBrowserOthers.cshtml");
        }
    }
}