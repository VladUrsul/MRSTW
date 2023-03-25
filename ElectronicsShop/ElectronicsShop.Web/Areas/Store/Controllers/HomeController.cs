using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Store/Home
        public ActionResult Index()
        {
            return View("~/Areas/Store/Views/Home/Index.cshtml");
        }
    }
}