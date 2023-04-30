using ElectronicsShop.Web.Areas.AdminPanel.Models;
using ElectronicsShop.Data.Contexts;
using ElectronicsShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopDbContext _dbContext;

        public ProductsController(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: AdminPanel/Products
        public ActionResult Products()
        {
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.ToList();
            ViewBag.Products = products;

            var viewModel = new ProductViewModel
            {
                Categories = categories
            };
            return View("~/Areas/AdminPanel/Views/Products/Products.cshtml", viewModel);
        }

        // POST: AdminPanel/Products/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var category = _dbContext.Categories.FirstOrDefault(c => c.Id == viewModel.CategoryId);
                if (category != null)
                {
                    var product = new Product
                    {
                        Name = viewModel.Name,
                        Description = viewModel.Description,
                        Price = viewModel.Price,
                        Category = category
                    };

                    _dbContext.Products.Add(product);
                    _dbContext.SaveChanges();

                    TempData["SuccessMessage"] = "Product created successfully!";
                    return RedirectToAction("Products", "Products", new { area = "AdminPanel" });
                }
            }

            // If we got this far, something failed, redisplay form
            viewModel.Categories = _dbContext.Categories.ToList();
            viewModel.Products = _dbContext.Products.ToList();
            return View("~/Areas/AdminPanel/Views/Products/Products.cshtml", viewModel);
        }


    }
}
