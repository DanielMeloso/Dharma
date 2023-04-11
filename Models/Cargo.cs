using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Cargo()
        {
            Descricao = "";
        }
    }
}
