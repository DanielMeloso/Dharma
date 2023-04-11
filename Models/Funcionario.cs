using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Identificação")]
        public string? Identificacao { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Cargo")]
        public int? Cargo_Id { get; set; }
        public bool Ativo { get; set; }
        public bool Leciona { get; set; }

        public Funcionario()
        {
            Nome = "";
            Ativo = true;
            Leciona = false;
        }

    }
}
