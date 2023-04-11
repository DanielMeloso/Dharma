using Dharma.Areas.Administrativa.Repositories;
using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class CargoController : Controller
    {
        private ICargoRepository _cargoRepository;

        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        public IActionResult Index()
        {
            List<Cargo> cargos = _cargoRepository.ObterTodos();
            return View(cargos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cargo cargo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _cargoRepository.Cadastrar(cargo);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var cargo = _cargoRepository.Obter(id);
            return View(cargo);
        }

        [HttpPost]
        public IActionResult Alterar(Cargo cargo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _cargoRepository.Atualizar(cargo);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = cargo.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _cargoRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
