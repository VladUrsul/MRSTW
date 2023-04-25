using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class UsersController : Controller
    {
        // GET: AdminPanel/User
        public ActionResult Index()
        {
            return View();
        }
    }
}