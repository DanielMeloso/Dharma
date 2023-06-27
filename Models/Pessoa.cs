using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string? Identificacao { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Nome { get; set; }
        public string? Email { get; set; }
        public int? Genero { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public string? Cpf { get; set; }
        public int Situacao { get; set; }
        public bool Aluno { get; set; }
        public bool Funcionario { get; set; }
        public string? Senha { get; set; }
        public int? Raca { get; set; }
        public int? Nacionalidade { get; set; }
        public int? Naturalidade { get; set; }
        public int? Ocupacao { get; set; }
        public int? Empresa { get; set; }
        public string? Foto { get; set; }

        public DateTime Data_Cadastro { get; set; }

        public Pessoa()
        {
            Situacao = 1;
            Data_Cadastro = DateTime.UtcNow;
        }
    }
}
