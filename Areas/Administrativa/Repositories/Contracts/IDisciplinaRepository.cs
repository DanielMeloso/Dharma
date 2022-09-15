using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface IDisciplinaRepository
    {
        List<Disciplina> ObterTodas();
        void Cadastrar(Disciplina disciplina);
        Disciplina Obter(int id);
        void Atualizar(Disciplina disciplina);
        void Excluir(int id);
    }
}
