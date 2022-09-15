using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface INivelEnsinoRepository
    {
        List<NivelEnsino> ObterTodos();
        void Cadastrar(NivelEnsino nivelEnsino);
        NivelEnsino Obter(int id);
        void Atualizar(NivelEnsino nivelEnsino);
        void Excluir(int id);

    }
}
