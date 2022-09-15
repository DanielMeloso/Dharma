using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class NivelEnsinoController : Controller
    {
        private INivelEnsinoRepository _nivelEnsinoRepository;

        public NivelEnsinoController(INivelEnsinoRepository nivelEnsinoRepository)
        {
            _nivelEnsinoRepository = nivelEnsinoRepository;
        }

        public IActionResult Index()
        {
            List<NivelEnsino> niveisEnsino = _nivelEnsinoRepository.ObterTodos();
            return View(niveisEnsino);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(NivelEnsino nivelEnsino)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _nivelEnsinoRepository.Cadastrar(nivelEnsino);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var nivelEnsino = _nivelEnsinoRepository.Obter(id);
            return View(nivelEnsino);
        }

        [HttpPost]
        public IActionResult Alterar(NivelEnsino nivelEnsino)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _nivelEnsinoRepository.Atualizar(nivelEnsino);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = nivelEnsino.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _nivelEnsinoRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
