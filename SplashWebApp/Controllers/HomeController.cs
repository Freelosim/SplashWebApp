using Microsoft.AspNetCore.Mvc;
using SplashWebApp.Logic;
using SplashWebApp.Models;
using System.Diagnostics;


namespace SplashWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Hardcoded profiles & comments for testing purposes
        Profile profile1 = new Profile(1, "Rakan","The Charmer", "Rakan#1234", "RakanYT");
        Profile profile2 = new Profile(2, "Xayah", "The Rebel", "Xayah#5678", "XayahYT");
        Profile profile3 = new Profile(3, "Kai'Sa", "Daugther of the Void", "Kaisa#2138", "KaisaYT");
        Profile profile4 = new Profile(4, "Lee Sin", "The Blind Monk", "LeeSin#9873", "LeeSinYT");
        Profile profile5 = new Profile(5, "Riven", "The Broken Blade", "Riven#0420", "RivenYT");

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
            var profile = profile1;
            return View(profile);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}