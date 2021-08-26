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

        public ViewResult Index()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            };

            return View("Index", products.Keys);
        }

        #endregion


    }
}