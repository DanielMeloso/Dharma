using Dharma.Areas.Administrativa.Repositories.Contracts;
using Dharma.Database;
using Dharma.Models;

namespace Dharma.Areas.Administrativa.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private DharmaContext _banco;

        public CargoRepository(DharmaContext banco)
        {
            _banco = banco;
        }
        public void Atualizar(Cargo cargo)
        {
            _banco.Update(cargo);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cargo cargo)
        {
            _banco.Add(cargo);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            var cargo = Obter(id);
            _banco.Remove(cargo);
            _banco.SaveChanges();
        }

        public Cargo Obter(int id)
        {
            return _banco.Cargos.Find(id);
        }

        public List<Cargo> ObterTodos()
        {
            return _banco.Cargos.ToList();
        }
    }
}
