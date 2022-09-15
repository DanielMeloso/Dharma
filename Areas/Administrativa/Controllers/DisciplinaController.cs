using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class DisciplinaController : Controller
    {
        private IDisciplinaRepository _disciplinaRepository;

        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var disciplinas = _disciplinaRepository.ObterTodas();
            return View(disciplinas);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Disciplina disciplina)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _disciplinaRepository.Cadastrar(disciplina);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var disciplina = _disciplinaRepository.Obter(id);
            return View(disciplina);
        }

        [HttpPost]
        public IActionResult Alterar(Disciplina disciplina)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _disciplinaRepository.Atualizar(disciplina);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new {id = disciplina.Id});
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _disciplinaRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}