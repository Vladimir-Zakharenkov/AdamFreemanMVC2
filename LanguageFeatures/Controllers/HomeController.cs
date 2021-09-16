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

        //public ViewResult Index() => View(new string[] { "C#", "Language", "Features" });


        #endregion

        #region Detecting null Values

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

        #region Detecting Nested null Values

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        string name = p?.Name;
        //        decimal? price = p?.Price;
        //        string relatedName = p?.Related?.Name;
        //        results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
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
        //        results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
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

        //        results.Add($"Name: {name}, Price: {price:C2}, Related: {relatedName}");
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

        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //    Product[] productArray =
        //    {
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "LifeJacket", Price = 48.95M}
        //    };

        //    decimal cartTotal = cart.TotalPrices();
        //    decimal arrayTotal = productArray.TotalPrices();

        //    return View("Index", new string[]
        //    {
        //        $"Cart Total: {cartTotal:C2}",
        //        $"Array Total: {arrayTotal:C2}"
        //    });
        //}

        #endregion

        #region Using the Filtering Extension Method

        //public ViewResult Index()
        //{
        //    Product[] productArray =
        //    {
        //        new Product{Name = "Kayak", Price = 275M},
        //        new Product{Name = "Lifejacket", Price = 48.95M},
        //        new Product{Name = "Soccer ball", Price = 19.95M},
        //        new Product{Name = "Corner flag", Price = 34.95M}
        //    };

        //    decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

        //    return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        //}

        #endregion

        #region Using Two Filter Methods

        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "Lifejacket", Price = 48.95M},
        //        new Product {Name = "Soccer ball", Price = 19.50M},
        //        new Product {Name = "Corner flag", Price = 34.95M}
        //        };

        //    decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();

        //    decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

        //    return View("Index", new string[] {
        //        $"Price Total: {priceFilterTotal:C2}",
        //        $"Name Total: {nameFilterTotal:C2}" });
        //}

        #endregion

        #region Using a Function to Filter Product Objects

        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "Lifejacket", Price = 48.95M},
        //        new Product {Name = "Soccer ball", Price = 19.50M},
        //        new Product {Name = "Corner flag", Price = 34.95M}
        //     };

        //    Func<Product, bool> nameFilter = delegate (Product prod)
        //    {
        //        return prod?.Name?[0] == 'S';
        //    };

        //    decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();

        //    decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

        //    return View("Index", new string[] {
        //        $"Price Total: {priceFilterTotal:C2}",
        //        $"Name Total: {nameFilterTotal:C2}" });
        //    }

        #endregion

        #region Using Lambda Expression

        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "Lifejacket", Price = 48.95M},
        //        new Product {Name = "Soccer ball", Price = 19.50M},
        //        new Product {Name = "Corner flag", Price = 34.95M}
        //     };

        //    decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();

        //    decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

        //    return View("Index", new string[] {
        //        $"Price Total: {priceFilterTotal:C2}",
        //        $"Name Total: {nameFilterTotal:C2}" });
        //}

        #endregion

        #region Creating a Common Action Pattern

        //public ViewResult Index()
        //{
        //    return View(Product.GetProducts().Select(p => p?.Name));
        //}

        #endregion

        #region Expressing an Action Method as a Lambda Expression

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        #endregion

        #region Using Type Inference

        //public ViewResult Index()
        //{
        //    var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };

        //    return View(names);
        //}

        #endregion

        #region Creating an Anonymous Type

        //public ViewResult Index()
        //{
        //    var products = new[] {
        //        new { Name = "Kayak", Price = 275M },
        //        new { Name = "Lifejacket", Price = 48.95M },
        //        new { Name = "Soccer ball", Price = 19.50M },
        //        new { Name = "Corner flag", Price = 34.95M }
        //    };

        //    return View(products.Select(p => p.Name));
        //}

        #endregion

        #region Displaying the Anonymous Type Name

        //public ViewResult Index()
        //{
        //    var products = new[] {
        //        new { Name = "Kayak", Price = 275M },
        //        new { Name = "Lifejacket", Price = 48.95M },
        //        new { Name = "Soccer ball", Price = 19.50M },
        //        new { Name = "Corner flag", Price = 34.95M }
        //    };

        //    return View(products.Select(p => p.GetType().Name));
        //}

        #endregion

        #region Defining an Asynchronous Action Methods

        //public async Task<ViewResult> index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();

        //    return View(new string[] { $"Length: {length}" });

        //}

        #endregion

        #region Hard-Coding a Name

        //public ViewResult Index()
        //{
        //    var products = new[]
        //    {
        //        new {Name = "Kayak", Price = 275M},
        //        new {Name = "Lifejacket", Price = 48.95M},
        //        new {Name = "Soccer ball", Price = 19.50M},
        //        new {Name = "Corner flag", Price = 34.95M}
        //    };

        //    return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        //}

        #endregion

        #region Using nameof Expressions

        public ViewResult Index()
        {
            var products = new[]
            {
                new {Name = "Kayak", Price = 275M},
                new {Name = "Lifejacket", Price = 48.95M},
                new {Name = "Soccer ball", Price = 19.50M},
                new {Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        #endregion
    }
}