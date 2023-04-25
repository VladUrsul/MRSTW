using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Areas/AdminPanel/Views/Home/Index.cshtml");
        }
        public ActionResult AdminAccount()
        {
            return View("~/Areas/AdminPanel/Views/Home/AdminAccount.cshtml");
        }
    }
}