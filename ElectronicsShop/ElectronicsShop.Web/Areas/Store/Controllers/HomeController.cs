using ElectronicsShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Data;
using ElectronicsShop.Web.Areas.AdminPanel.Models;
using System.Web.Configuration;
using ElectronicsShop.Data.Contexts;

namespace ElectronicsShop.Web.Areas.Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext _dbContext;

        public HomeController(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: Store/Home
        public ActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            var viewModel = new ProductViewModel
            {
                Categories = categories
            };

            ViewBag.ShowCategoriesView = false;
            return View("~/Areas/Store/Views/Home/Index.cshtml", viewModel);
        }

        public ActionResult ProductGrid(string categoryName)
        {
            var selectedCategory = _dbContext.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (selectedCategory == null)
            {
                // Handle the case when the selected category does not exist
                return RedirectToAction("Index");
            }

            var products = _dbContext.Products.Where(p => p.CategoryId == selectedCategory.Id).ToList();

            var categories = _dbContext.Categories.ToList(); // Retrieve all categories

            var viewModel = new ProductViewModel
            {
                Categories = categories,
                Products = products
            };

            ViewBag.ShowCategoriesView = true;
            ViewBag.SelectedCategoryName = selectedCategory.Name;
            ViewBag.Products = products; // Set the ViewBag.Products property

            return PartialView("~/Areas/Store/Views/Shared/_ProductGrid.cshtml", viewModel);
        }

<<<<<<< HEAD
=======
        public ActionResult StoreLogin()
        {
        
            return View("~/Views/Account/StoreLogin.cshtml");
        }
>>>>>>> 4c2676d4e3ff70ee0ebf5fb6cf7cb0b7e91275ec
    }
}
