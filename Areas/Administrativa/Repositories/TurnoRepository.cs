using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class TurnoRepository : ITurnoRepository
    {
        private DharmaContext _banco;

        public TurnoRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Turno turno)
        {
            _banco.Update(turno);
            _banco.SaveChanges();
        }

        public void Cadastrar(Turno turno)
        {
            _banco.Turnos.Add(turno);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var turno = Obter(id);
            _banco.Turnos.Remove(turno);
            _banco.SaveChanges();
        }

        public Turno Obter(int id)
        {
            return _banco.Turnos.Find(id);
        }

        public List<Turno> ObterTodos()
        {
            return _banco.Turnos.ToList();
        }
    }
}
