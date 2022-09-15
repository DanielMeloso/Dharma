using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Dharma.Models
{
    public class Nacionalidade
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nacionalidade")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }
    }
}
