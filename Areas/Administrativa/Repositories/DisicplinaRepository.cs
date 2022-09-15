using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class DisicplinaRepository : IDisciplinaRepository
    {
        private DharmaContext _banco;

        public DisicplinaRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Disciplina disciplina)
        {
            _banco.Update(disciplina);
            _banco.SaveChanges();
        }

        public void Cadastrar(Disciplina disciplina)
        {
            _banco.Add(disciplina);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var disciplina = Obter(id);
            _banco.Disciplinas.Remove(disciplina);
            _banco.SaveChanges();
        }

        public Disciplina Obter(int id)
        {
            return _banco.Disciplinas.Find(id);
        }

        public List<Disciplina> ObterTodas()
        {
            return _banco.Disciplinas.ToList();
        }



    }
}
