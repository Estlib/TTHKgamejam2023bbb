using Microsoft.AspNetCore.Mvc;

namespace TTHKgamejam2023.Controllers
{
    public class ShowcaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
