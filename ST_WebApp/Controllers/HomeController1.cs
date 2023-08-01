using Microsoft.AspNetCore.Mvc;

namespace ST_WebApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
