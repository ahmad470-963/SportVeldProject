using System.Diagnostics;
using Central_Sports.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;



namespace Central_Sports.Controllers
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

        public IActionResult Locatie()
        {
            return View();
        }

        public IActionResult Reserveren()
        {
            return View();
        }


        [Authorize]
        public IActionResult Betalen(string baan, string tijd)
        {
            ViewBag.Baan = baan;
            ViewBag.Tijd = tijd;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult BevestigBetaling(string betaalmethode)
        {
            ViewBag.Betaalmethode = betaalmethode;

            var userEmail = User.Identity.Name;
            ViewBag.Emailgebruiker=userEmail;

            return View("Bevestiging");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
