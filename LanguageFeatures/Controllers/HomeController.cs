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


        //    public ViewResult Index()
        //    {
        //        return View(new string[] { "C#", "Language", "Features" });
        //    }
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

        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;
                string relatedName = p?.Related?.Name;
                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
                name, price, relatedName));
            }
            return View(results);
        }

        #endregion

    }





}
