﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Cart()
        {
            return View("~/Areas/AdminPanel/Views/Cart/Cart.cshtml");
        }
    }
}