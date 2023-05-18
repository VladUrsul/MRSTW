using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Data.Contexts;
using ElectronicsShop.Web.Areas.AdminPanel.Filters;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    //[AdminAccess]
    public class UsersController : Controller
    {
        // GET: AdminPanel/User
        private readonly ShopDbContext _context;

        public UsersController(ShopDbContext context)
        {
            _context = context;
        }
        public ActionResult Users()
        {
            var users = _context.Users.ToList();
            return View("~/Areas/AdminPanel/Views/Users/Users.cshtml", users);
        }
    }
}