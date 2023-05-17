using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class ProdBrowserController : Controller
    {
        public ActionResult ProdBrowser()
        {
            return View("~/Areas/AdminPanel/Views/ProdBrowser/ProdBrowser.cshtml");
        }
    }
}