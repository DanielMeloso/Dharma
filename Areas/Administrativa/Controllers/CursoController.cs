using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class CursoController : Controller
    {
        private ICursoRepository _cursoRepository;
        private INivelEnsinoRepository _nivelEnsinoRepository;

        public CursoController(ICursoRepository cursoRepository, INivelEnsinoRepository nivelEnsinoRepository)
        {
            _cursoRepository = cursoRepository;
            _nivelEnsinoRepository = nivelEnsinoRepository;
        }
        public IActionResult Index()
        {
            var cursos = _cursoRepository.ObterTodos();
            return View(cursos);
        }

        public IActionResult Cadastrar()
        {
            ViewBag.NiveisEnsino = _nivelEnsinoRepository.ObterTodos().Select(x => new SelectListItem(x.Nome, x.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Curso curso)
        {
            ViewBag.NiveisEnsino = _nivelEnsinoRepository.ObterTodos().Select(x => new SelectListItem(x.Nome, x.Id.ToString()));
            return View();
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var curso = _cursoRepository.Obter(id);
            ViewBag.NiveisEnsino = _nivelEnsinoRepository.ObterTodos().Select(x => new SelectListItem(x.Nome, x.Id.ToString()));
            return View(curso);
        }

        [HttpPost]
        public IActionResult Alterar(Curso curso)
        {
            _cursoRepository.Atualizar(curso);
            return RedirectToAction(nameof(Index));
        }
    }
}
