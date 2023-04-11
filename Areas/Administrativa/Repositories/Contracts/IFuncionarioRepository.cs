using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> ObterTodos();
        void Cadastrar(Funcionario funcionario);
        Funcionario Obter(int id);
        void Atualizar(Funcionario funcionario);
        void Excluir(int id);
    }
}
