using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private DharmaContext _banco;

        public PessoaRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Pessoa pessoa)
        {
            _banco.Update(pessoa);
            _banco.SaveChanges();
        }

        public void Cadastrar(Pessoa pessoa)
        {
            _banco.Add(pessoa);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var pessoa = Obter(id);
            _banco.Pessoas.Remove(pessoa);
            _banco.SaveChanges();
        }

        public Pessoa Obter(int id)
        {
            return _banco.Pessoas.Find(id);
        }

        public List<Pessoa> ObterTodas()
        {
            return _banco.Pessoas.ToList();
        }
    }
}
