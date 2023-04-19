using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Orders()
        {
            return View("~/Areas/AdminPanel/Views/Orders/Orders.cshtml");
        }
    }
}