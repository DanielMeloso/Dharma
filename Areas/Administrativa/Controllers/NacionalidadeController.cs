using Dharma.Areas.Administrativa.Repositories;
using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Libraries.Lang;
using Dharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dharma.Areas.Administrativa.Controllers
{
    [Area("Administrativa")]
    public class NacionalidadeController : Controller
    {
        private INacionalidadeRepository _nacionalidadeRepository;

        public NacionalidadeController(INacionalidadeRepository nacionalidadeRepository)
        {
            _nacionalidadeRepository = nacionalidadeRepository;
        }
        public IActionResult Index()
        {
            List<Nacionalidade> nacionalidades = _nacionalidadeRepository.ObterTodos();
            return View(nacionalidades);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Nacionalidade nacionalidade)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _nacionalidadeRepository.Cadastrar(nacionalidade);
            TempData["MSG_S"] = Mensagem.MSG_S001;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var nacionalidade = _nacionalidadeRepository.Obter(id);
            return View(nacionalidade);
        }

        [HttpPost]
        public IActionResult Alterar(Nacionalidade nacionalidade)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _nacionalidadeRepository.Atualizar(nacionalidade);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Alterar), new { id = nacionalidade.Id });
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _nacionalidadeRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction("Index");
        }
    }
}
