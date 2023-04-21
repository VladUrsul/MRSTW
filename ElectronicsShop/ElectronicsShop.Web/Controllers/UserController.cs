using ElectronicsShop.Data.Repositories;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

    }
}
