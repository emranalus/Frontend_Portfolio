using Microsoft.AspNetCore.Mvc;

namespace WebCore5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Referanslar()
        {
            return View();
        }

    }
}
