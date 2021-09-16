﻿using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Product myproduct = new()
            //{
            //    ProductId = 1,
            //    Name = "Kayak",
            //    Description = "A boat for one person",
            //    Category = "Watersports",
            //    Price = 275M
            //};

            //ViewBag.StockLevel = 2;

            //return View(myproduct);

            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "LifeJacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            return View(array);
        }
    }
}
