using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class AuthentificationController : Controller
    {
        // GET: AdminPanel/Authentification
        public ActionResult Login()
        {
            return View();
        }
        // GET: AdminPanel/Authentification
        public ActionResult Register()
        {
            return View();
        }
    }
}