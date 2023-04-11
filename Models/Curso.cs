using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dharma.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }

        [Display(Name = "Curso Resumido")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Nome_Resumido { get; set; }

        [Display(Name = "Nível de Ensino")]
        public int? Nivel_Ensino_Id { get; set; }
        [ForeignKey("Nivel_Ensino_Id")]
        public virtual NivelEnsino NiveisEnsino { get; set; }

        [Display(Name = "Grade")]
        public int Tipo_Grade_Id { get; set; }
        [ForeignKey("Tipo_Grade_Id")]
        public virtual TipoGrade TiposGrade { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }


        public ICollection<Serie> Series { get; set; }

        public Curso()
        {
            Nome_Resumido = "";
            Tipo_Grade_Id = 2;
            Ativo = true;
        }
    }

}
