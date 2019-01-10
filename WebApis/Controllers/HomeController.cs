using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApis.Models;

namespace WebApis.Controllers
{
    public class HomeController : Controller
    {
        private IDateTime _dateTime;
        public HomeController(IDateTime dateTime)
        {
            this._dateTime = dateTime;
        }
        public IActionResult Index()
        {
            var dateTime = this._dateTime; 
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page." + dateTime.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
