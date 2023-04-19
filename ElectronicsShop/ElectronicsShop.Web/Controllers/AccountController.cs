using System.Threading.Tasks;
using System.Web.Mvc;
using ElectronicsShop.Web.Models;


namespace ElectronicsShop.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            // handle user login logic here

            return RedirectToAction("Index", "Home"); // or wherever you want to redirect after login
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Signup(SignupViewModel model)
        {
            // handle user signup logic here

            return RedirectToAction("Index", "Home"); // or wherever you want to redirect after signup
        }
    }
}
