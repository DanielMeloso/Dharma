using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class NivelEnsinoRepository : INivelEnsinoRepository
    {
        private DharmaContext _banco;

        public NivelEnsinoRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(NivelEnsino nivelEnsino)
        {
            _banco.Update(nivelEnsino);
            _banco.SaveChanges();
        }

        public void Cadastrar(NivelEnsino nivelEnsino)
        {
            _banco.NiveisEnsino.Add(nivelEnsino);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var turno = Obter(id);
            _banco.NiveisEnsino.Remove(turno);
            _banco.SaveChanges();
        }

        public NivelEnsino Obter(int id)
        {
            return _banco.NiveisEnsino.Find(id);
        }

        public List<NivelEnsino> ObterTodos()
        {
            return _banco.NiveisEnsino.ToList();
        }
    }
}
