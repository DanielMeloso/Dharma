using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories.Contracts
{
    public interface IPessoaRepository
    {
        List<Pessoa> ObterTodas();
        void Cadastrar(Pessoa pessoa);
        Pessoa Obter(int id);
        void Atualizar(Pessoa pessoa);
        void Excluir(int id);
    }
}
