using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Products()
        {
            return View("~/Areas/AdminPanel/Views/Products/Products.cshtml");
        }
    }
}