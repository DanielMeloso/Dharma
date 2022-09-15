using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface IMotivoDesistenciaRepository
    {
        List<MotivoDesistencia> ObterTodos();
        void Cadastrar(MotivoDesistencia motivoDesistencia);
        MotivoDesistencia Obter(int id);
        void Atualizar(MotivoDesistencia motivoDesistencia);
        void Excluir(int id);
    }
}
