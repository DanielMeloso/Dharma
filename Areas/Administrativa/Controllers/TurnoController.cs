using Dharma.Areas.Administrativa.Repositories;
using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class TurnoController : Controller
    {
        private ITurnoRepository _turnoRepository;

        public TurnoController(ITurnoRepository turnoRepository)
        {
            _turnoRepository = turnoRepository;
        }
        
        public IActionResult Index()
        {
            List<Turno> turnos = _turnoRepository.ObterTodos();
            return View(turnos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Turno turno)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _turnoRepository.Cadastrar(turno);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var turno = _turnoRepository.Obter(id);
            return View(turno);
        }

        [HttpPost]
        public IActionResult Alterar(Turno turno)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _turnoRepository.Atualizar(turno);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = turno.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _turnoRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
