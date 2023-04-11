using Dharma.Libraries.Lang;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dharma.Models
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Descricao { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        public bool Ativo { get; set; }

        public Serie()
        {
            Descricao = "";
        }
    }
}
