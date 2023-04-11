using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface ICargoRepository
    {
        List<Cargo> ObterTodos();
        void Cadastrar(Cargo cargo);
        Cargo Obter(int id);
        void Atualizar(Cargo cargo);
        void Excluir(int id);
    }
}
