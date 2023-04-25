using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: AdminPanel/Categories
        public ActionResult Categories()
        {
            return View("~/Areas/AdminPanel/Views/Categories/Categories.cshtml");
        }
    }
}