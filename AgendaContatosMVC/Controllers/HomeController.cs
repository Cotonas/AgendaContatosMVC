using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AgendaContatosMVC.Models.ViewModel;

namespace AgendaContatosMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Descrições sobre sistema Agenda Client.";
            ViewData["Developer"] = "Guilherme Bandeira Ludovico";

            return View();
        }

        public IActionResult Support()
        {
            ViewData["Message"] = "Tilt System Developer";

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
