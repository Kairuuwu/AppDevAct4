using AppDevAct4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppDevAct4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Catalogue()
        {
            return View();
        }
        public IActionResult Application(string name, string type)
        {
            ViewBag.Name = name;
            ViewBag.Type = type;
            return View();
        }

        public IActionResult SubmitApplication()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
