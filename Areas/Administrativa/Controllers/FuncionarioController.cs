using Dharma.Areas.Administrativa.Repositories;
using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class FuncionarioController : Controller
    {
        private IFuncionarioRepository _funcionarioRepository;
        private ICargoRepository _cargoRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository, ICargoRepository cargoRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _cargoRepository = cargoRepository;
        }

        public IActionResult Index()
        {
            var funcionarios = _funcionarioRepository.ObterTodos();
            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Cargos = _cargoRepository.ObterTodos().Select(x => new SelectListItem(x.Descricao, x.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _funcionarioRepository.Cadastrar(funcionario);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int Id)
        {
            var funcionario = _funcionarioRepository.Obter(Id);
            return View(funcionario);
        }

        [HttpPost]
        public IActionResult Alterar(Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _funcionarioRepository.Atualizar(funcionario);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = funcionario.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _funcionarioRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
