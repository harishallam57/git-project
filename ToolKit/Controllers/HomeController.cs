using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToolKit.Models;

namespace ToolKit.Controllers
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

        public IActionResult Age()
        {
            return View();
        }

        public IActionResult Unit()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }

        public IActionResult RandomQuote() 
        { 
        
            return View();
        }

        public IActionResult RandomName()
        {

            return View();
        }

        public IActionResult NumberGuessing()
        {
            return View();
        }

        public IActionResult ToDoList()
        {
            return View();
        }

        public IActionResult WeatherChecker()
        {
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
