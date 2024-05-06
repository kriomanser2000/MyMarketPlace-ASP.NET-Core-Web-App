using LAB9_Module4_MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAB9_Module4_MarketPlace.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult UserEnter()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View();
        }
        public IActionResult ForgetPassword()
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
