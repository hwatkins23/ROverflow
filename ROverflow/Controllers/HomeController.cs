using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ROverflow.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ROverflow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conditionals()
        {
            return View();
        }
        public IActionResult DataCleaning()
        {
            return View();
        }
        public IActionResult Dataframes()
        {
            return View();
        }
        public IActionResult ErrorHandling()
        {
            return View();
        }
        public IActionResult Loops()
        {
            return View();
        }
        public IActionResult Packages()
        {
            return View();
        }
        public IActionResult About ()
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
