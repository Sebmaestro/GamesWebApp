using Microsoft.AspNetCore.Mvc;

namespace GamesWebApp.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yatzy()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
