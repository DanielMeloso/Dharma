using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface ICursoRepository
    {
        List<Curso> ObterTodos();
        void Cadastrar(Curso curso);
        Curso Obter(int id);
        void Atualizar(Curso curso);
        void Excluir(int id);
    }
}
