using ElectronicsShop.Web.Areas.AdminPanel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    //[AdminAccess]
    public class ProdViewController : Controller
    {
        public ActionResult ProdView()
        {
            return View("~/Areas/AdminPanel/Views/ProdView/ProdView.cshtml");
        }
    }
}