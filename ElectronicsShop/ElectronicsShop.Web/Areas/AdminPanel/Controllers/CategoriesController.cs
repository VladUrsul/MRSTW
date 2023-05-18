using ElectronicsShop.Domain.Entities;
using System.Linq;
using System.Web.Mvc;
using ElectronicsShop.Data.Contexts;
using ElectronicsShop.Web.Areas.AdminPanel.Models;
using ElectronicsShop.Web.Areas.AdminPanel.Filters;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    //[AdminAccess]
    public class CategoriesController : Controller
    {
        private readonly ShopDbContext _dbContext;

        public CategoriesController(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /AdminPanel/Categories
        public ActionResult Categories()
        {
            var categories = _dbContext.Categories.ToList();
            ViewBag.Categories = categories;
            return View("~/Areas/AdminPanel/Views/Categories/Categories.cshtml");
        }


        // POST: /AdminPanel/Categories/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Areas/AdminPanel/Views/Categories/Categories.cshtml", viewModel);
            }

            var newCategory = new Category
            {
                Name = viewModel.Name,
                Description = viewModel.Description
            };

            _dbContext.Categories.Add(newCategory);
            _dbContext.SaveChanges();

            TempData["SuccessMessage"] = "Category created successfully.";

            return RedirectToAction("Categories");
        }

    }
}
