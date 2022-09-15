using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class NaciondalideRepository : INacionalidadeRepository
    {
        private DharmaContext _banco;

        public NaciondalideRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Nacionalidade nacionalidade)
        {
            _banco.Update(nacionalidade);
            _banco.SaveChanges();
        }

        public void Cadastrar(Nacionalidade nacionalidade)
        {
            _banco.Nacionalidades.Add(nacionalidade);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var nacionalidade = Obter(id);
            _banco.Nacionalidades.Remove(nacionalidade);
            _banco.SaveChanges();
        }

        public Nacionalidade Obter(int id)
        {
            return _banco.Nacionalidades.Find(id);
        }

        public List<Nacionalidade> ObterTodos()
        {
            return _banco.Nacionalidades.ToList();
        }
    }
}
