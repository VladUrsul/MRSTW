using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Filters
{
    public class AdminAccessAttribute : AuthorizeAttribute
    {
        public AdminAccessAttribute()
        {
            Roles = "Admin";
        }
    }
}
