using System.Diagnostics;
using Central_Sports.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;



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
        public IActionResult Winkelwagen()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Kantine()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }


        [Authorize]
        public IActionResult Betalen(string baan, string tijd)
        {
            var model = new Bevestiging
            {
                Baan = baan,
                Tijd = tijd
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BevestigBetaling(string betaalmethode)
        {

       
            Bevestiging bevestiging = new Bevestiging();
            bevestiging.Betaalmethode = betaalmethode;

            var userEmail = User.Identity.Name;
         
            bevestiging.Gebruikersnaam = userEmail; 


            return View("Bevestiging",bevestiging);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
