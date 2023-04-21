using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;
using ElectronicsShop.Data.Repositories;
using ElectronicsShop.Web.Models;
using ElectronicsShop.Domain.Entities;
using System.Data.Entity.Validation;
using System;

namespace ElectronicsShop.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserRepository _userRepository;

        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userRepository.GetUserByUsername(model.Username);
                if (user != null && user.PasswordHash == model.Password)
                {
                    Session["UserId"] = user.Id;
                    return RedirectToAction("~/Areas/Store/Views/Home/Index.cshtml");
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username, Email = model.Email, PasswordHash = model.Password };
                _userRepository.AddUser(user);
                Session["UserId"] = user.Id;
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }


    }
}
