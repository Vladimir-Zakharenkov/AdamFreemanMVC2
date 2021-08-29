using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        #region Append first controller

        //public ViewResult Index()
        //{
        //    return View(new string[] { "C#", "Language", "Features" });
        //}

        #endregion

        #region Detecting null Values in the HomeController.cs File

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name;
        //        decimal? price = p?.Price;
        //        results.Add(string.Format("Name: {0}, Price: {1}", name, price));
        //    }

        //    return View(results);
        //}

        #endregion

        #region Detecting Nested null Values in the HomeController.cs File

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name;
        //        decimal? price = p?.Price;
        //        string relatedName = p?.Related?.Name;
        //        results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
        //        name, price, relatedName));
        //    }
        //    return View(results);
        //}

        #endregion

        #region Combining Null Operators

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name ?? "<No Name>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<None>";
        //        results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
        //        name, price, relatedName));
        //    }

        //    return View(results);
        //}

        #endregion

        #region Using String Interpolation

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name ?? "<No Name>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<None>";

        //        results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
        //    }
        //    return View(results);
        //}

        #endregion

        #region Initializing an Object

        //public ViewResult Index()
        //{
        //    string[] names = new string[3];

        //    names[0] = "Bob";
        //    names[1] = "Joe";
        //    names[2] = "Alice";

        //    return View("Index", names);
        //}

        #endregion

        #region Using a Collection Initializer

        //public ViewResult Index()
        //{
        //    return View("Index", new string[] { "Bob", "Joe", "Alice" });
        //}

        #endregion

        #region Initializing a Dictionary

        //public ViewResult Index()
        //{
        //    Dictionary<string, Product> products = new Dictionary<string, Product>
        //    {
        //        { "Kayak", new Product { Name = "Kayak", Price = 275M } },
        //        { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
        //    };

        //    return View("Index", products.Keys);
        //}

        #endregion

        #region Using the C# Collection Initializer Syntax

        //public ViewResult Index()
        //{
        //    Dictionary<string, Product> products = new Dictionary<string, Product>
        //    {
        //        ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //        ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //    };

        //    return View("Index", products.Keys);
        //}

        #endregion

        #region Performing a check with "is"

        //public ViewResult Index()
        //{
        //    object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };

        //    decimal total = 0;

        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        if (data[i] is decimal d)
        //        {
        //            total += d;
        //        }
        //    }

        //    return View("Index", new string[] { $"Total: {total:C2}" });
        //}

        #endregion

        #region Comparison with type

        //public ViewResult Index()
        //{
        //    object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };

        //    decimal total = 0;

        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        switch (data[i])
        //        {
        //            case decimal decimalValue:
        //                total += decimalValue;
        //                break;

        //            case int intValue when intValue > 50:
        //                total += intValue;
        //                break;
        //        }
        //    }

        //    return View("Index", new string[] { $"Total: {total:C2}" });
        //}

        #endregion

        #region Applying an Extension Method

        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //    decimal cartTotal = cart.TotalPrices();

        //    return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        //}

        #endregion

        #region Applying an Extension Method to an Array

        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "LifeJacket", Price = 48.95M}
            };

            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new string[]
            {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}"
            });
        }

        #endregion

    }
}