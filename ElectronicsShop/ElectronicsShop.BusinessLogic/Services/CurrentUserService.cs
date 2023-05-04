using ElectronicsShop.Data.Repositories;
using ElectronicsShop.Domain.Entities;
using ElectronicsShop.Data.Contexts;
using System.Web;

namespace ElectronicsShop.BusinessLogic.Services
{
    public interface ICurrentUserService
    {
        User GetCurrentUser();
        string GetCurrentUserName();
    }

    public class CurrentUserService : ICurrentUserService
    {
        private readonly UserRepository _userRepository;

        public CurrentUserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetCurrentUser()
        {
            var userId = (int?)HttpContext.Current.Session["UserId"];
            return userId.HasValue ? _userRepository.GetUserById(userId.Value) : null;
        }

        public string GetCurrentUserName()
        {
            var currentUser = GetCurrentUser();
            return currentUser?.UserName;
        }
    }
}
