using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;
using Microsoft.EntityFrameworkCore;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private DharmaContext _banco;

        public CursoRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Curso curso)
        {
            _banco.Update(curso);
            _banco.SaveChanges();
        }

        public void Cadastrar(Curso curso)
        {
            _banco.Add(curso);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var curso = Obter(id);
            _banco.Cursos.Remove(curso);
            _banco.SaveChanges();
        }

        public Curso Obter(int id)
        {
            return _banco.Cursos.Include(x => x.Series)             
                .FirstOrDefault(x => x.Id == id);
        }

        public List<Curso> ObterTodos()
        {
            return _banco.Cursos.ToList();
        }
    }
}
