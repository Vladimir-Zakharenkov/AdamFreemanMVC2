using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        #region Initial text

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        #endregion

        #region Change for Hello World

        //public string Index()
        //{
        //    return "Hello World";
        //}

        #endregion

        #region Change for View "MyView"

        //public ViewResult Index()
        //{
        //    return View("MyView");
        //}

        #endregion

        #region Change for ViewBag

        //public ViewResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

        //    return View("MyView");
        //}

        #endregion

        #region Append method RsvpForm()

        //public ViewResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

        //    return View("MyView");
        //}

        //public ViewResult RsvpForm()
        //{
        //    return View();
        //}

        #endregion

        #region Append method RsvpForm() [HttpPost]

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // Что сделать: сохранить ответ от гостя
            return View();
        }

        #endregion


    }
}
