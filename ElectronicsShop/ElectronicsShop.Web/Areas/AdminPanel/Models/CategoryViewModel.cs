using ElectronicsShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElectronicsShop.Web.Areas.AdminPanel.Models
{
    public class CategoryViewModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
