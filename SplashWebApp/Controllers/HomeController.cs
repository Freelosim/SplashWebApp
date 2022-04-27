using Microsoft.AspNetCore.Mvc;
using SplashWebApp.Logic;
using SplashWebApp.Models;
using System.Diagnostics;


namespace SplashWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Hardcoded profiles & comments for testing purposes
        static List<Profile> profileList = new List<Profile>();
        private static void LoadProfiles()
        {
            Profile profile1 = new Profile(1, "Rakan", "The Charmer", "Rakan#1234", "RakanYT");
            Profile profile2 = new Profile(2, "Xayah", "The Rebel", "Xayah#5678", "XayahYT");
            Profile profile3 = new Profile(3, "Kai'Sa", "Daugther of the Void", "Kaisa#2138", "KaisaYT");
            Profile profile4 = new Profile(4, "Lee Sin", "The Blind Monk", "LeeSin#9873", "LeeSinYT");
            Profile profile5 = new Profile(5, "Riven", "The Broken Blade", "Riven#0420", "RivenYT");
            profileList.Add(profile1);
            profileList.Add(profile2);
            profileList.Add(profile3);
            profileList.Add(profile4);
            profileList.Add(profile5);
        }  
        private static Profile ProfileByName(string name)
        {
            LoadProfiles();
            foreach (Profile profile in profileList)
            {
                if(profile.ProfileName.ToLower() == name.ToLower())
                {
                    return profile;
                }
            }
            return null;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {

            var profile = ProfileByName("Xayah");
            return View(profile);
        }

        public IActionResult Login()
        {
            return RedirectToAction("Profile");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}