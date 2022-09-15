using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class MotivoDesistenciaRepository : IMotivoDesistenciaRepository
    {
        private DharmaContext _banco;

        public MotivoDesistenciaRepository(DharmaContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(MotivoDesistencia motivoDesistencia)
        {
            _banco.Update(motivoDesistencia);
            _banco.SaveChanges();
        }

        public void Cadastrar(MotivoDesistencia motivoDesistencia)
        {
            _banco.MotivosDesistencia.Add(motivoDesistencia);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var motivoDesistencia = Obter(id);
            _banco.MotivosDesistencia.Remove(motivoDesistencia);
            _banco.SaveChanges();
        }

        public MotivoDesistencia Obter(int id)
        {
            return _banco.MotivosDesistencia.Find(id);
        }

        public List<MotivoDesistencia> ObterTodos()
        {
            return _banco.MotivosDesistencia.ToList();
        }
    }
}
