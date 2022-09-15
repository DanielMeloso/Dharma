using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface INacionalidadeRepository
    {
        List<Nacionalidade> ObterTodos();
        void Cadastrar(Nacionalidade nacionalidade);
        Nacionalidade Obter(int id);
        void Atualizar(Nacionalidade nacionalidade);
        void Excluir(int id);
    }
}
