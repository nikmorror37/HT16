using HomeTask16LoginPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeTask16LoginPage.Controllers
{
    public class HomeController : Controller
    {
        string userNameExisted = "Leonardo";
        string passwordExisted = "1234567890";

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

        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult LoginPageError()
        {
            return NotFound("Неверно(ы) Имя_пользователя или(и) Пароль");
        }

        [HttpPost]
        public RedirectResult Login(string userName, string password)
        {
            if (userNameExisted.Equals(userName) && passwordExisted.Equals(password))
            {
                return Redirect("~/Home/Index");
            }
            else
                return Redirect("~/Home/LoginPageError");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}