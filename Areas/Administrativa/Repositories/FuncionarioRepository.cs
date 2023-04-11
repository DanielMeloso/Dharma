using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private DharmaContext _banco;

        public FuncionarioRepository(DharmaContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Funcionario funcionario)
        {
            _banco.Update(funcionario);
            _banco.SaveChanges();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            _banco.Add(funcionario);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var funcionario = Obter(id);
            _banco.Remove(funcionario);
            _banco.SaveChanges();
        }

        public Funcionario Obter(int id)
        {
            return _banco.Funcionarios.Find(id);
        }

        public List<Funcionario> ObterTodos()
        {
            return _banco.Funcionarios.ToList();
        }
    }
}
