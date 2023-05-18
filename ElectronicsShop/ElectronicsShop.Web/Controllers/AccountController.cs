using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;
using ElectronicsShop.Data.Repositories;
using ElectronicsShop.Web.Models;
using ElectronicsShop.Domain.Entities;
using ElectronicsShop.Domain.Enums;
using System.Data.Entity.Validation;
using System;
using ElectronicsShop.Helpers;
using System.Web.Security;
using System.Web;

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

                if (user != null && PasswordHasher.VerifyPassword(model.Password, user.PasswordHash))
                {
                    Session["UserId"] = user.Id;
                    Session["Username"] = user.UserName;

                    // Retrieve the user's role
                    var role = user.Role.ToString();

                    // Store the user's role in the authentication cookie
                    var authTicket = new FormsAuthenticationTicket(
                        1,
                        user.UserName,
                        DateTime.Now,
                        DateTime.Now.AddMinutes(30),
                        false,
                        role
                    );
                    var encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    Response.Cookies.Add(authCookie);

                    if (role == "User")
                    {
                        return RedirectToAction("Index", "Home", new { area = "Store" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
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

                user.Role = URole.User;

                _userRepository.AddUser(user);

                Session["UserId"] = user.Id;
                Session["Username"] = user.UserName;
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

    }
}
