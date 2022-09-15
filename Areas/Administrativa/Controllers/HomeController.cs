using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    public class HomeController : Controller
    {
        [Area("Administrativa")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
