using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TTHKgamejam2023.Models;

namespace TTHKgamejam2023.Controllers
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

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult GameJam2023()
        {
            return View();
        }
        public IActionResult ItchIo()
        {
            return View();
        }
        public IActionResult Voting()
        {
            return View();
        }
        public IActionResult Results()
        {
            return View();
        }
        public IActionResult SecretPage()
        {
            return View();
        }
        public IActionResult Projects2023()
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