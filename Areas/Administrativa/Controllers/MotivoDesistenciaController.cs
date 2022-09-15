using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class MotivoDesistenciaController : Controller
    {
        private IMotivoDesistenciaRepository _motivoDesistenciaRepository;

        public MotivoDesistenciaController(IMotivoDesistenciaRepository motivoDesistenciaRepository)
        {
            _motivoDesistenciaRepository = motivoDesistenciaRepository;
        }

        public IActionResult Index()
        {
            List<MotivoDesistencia> motivosDesistencia = _motivoDesistenciaRepository.ObterTodos();
            return View(motivosDesistencia);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(MotivoDesistencia motivoDesistencia)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _motivoDesistenciaRepository.Cadastrar(motivoDesistencia);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var motivoDesistencia = _motivoDesistenciaRepository.Obter(id);
            return View(motivoDesistencia);
        }

        [HttpPost]
        public IActionResult Alterar(MotivoDesistencia motivoDesistencia)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _motivoDesistenciaRepository.Atualizar(motivoDesistencia);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = motivoDesistencia.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _motivoDesistenciaRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
