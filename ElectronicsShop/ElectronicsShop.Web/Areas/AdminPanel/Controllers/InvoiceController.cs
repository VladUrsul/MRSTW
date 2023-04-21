using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicsShop.Web.Areas.AdminPanel.Controllers
{
    public class InvoiceController : Controller
    {
        public ActionResult Invoice()
        {
            return View("~/Areas/AdminPanel/Views/Invoice/Invoice.cshtml");
        }
    }
}