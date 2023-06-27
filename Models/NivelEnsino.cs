using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class NivelEnsino
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nível de Ensino")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Nome { get; set; }
    }
}
