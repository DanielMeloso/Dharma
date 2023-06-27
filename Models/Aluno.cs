using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class Aluno : Pessoa
    {
        [Display(Name = "Código de Matrícula")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Codigo_Matricula { get; set; }

        public required List<Matricula> Matriculas { get; set; }
        public required List<AlunoCurso> Aluno_Cursos { get; set; }

    }
}
