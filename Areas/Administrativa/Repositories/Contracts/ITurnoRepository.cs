using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface ITurnoRepository
    {
        List<Turno> ObterTodos();
        void Cadastrar(Turno turno);
        Turno Obter(int id);
        void Atualizar(Turno turno);
        void Excluir(int id);

    }
}
