using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
