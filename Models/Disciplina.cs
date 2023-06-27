using Dharma.Libraries.Lang;
using System.ComponentModel.DataAnnotations;

namespace Dharma.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Disciplina")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Nome { get; set; }

        [Display(Name = "Disciplina Resumida")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Nome_Resumido { get; set; }

        [Display(Name = "Identificação")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public required string Identificacao { get; set; }

        [Display(Name = "Código do MEC")]
        public string? Codigo_Mec { get; set; }

        public string? Ementa { get; set; }

        [Display(Name = "Objetivo Geral")]
        public string? Objetivo_Geral { get; set; }

        [Display(Name = "Objetivo Específico")]
        public string? Objetivo_Especifico { get; set; }

        [Display(Name = "Bibliografia Básica")]
        public string? Bibliografia_Basica { get; set; }

        [Display(Name = "Bibliografia Complementar")]
        public string? Bibliografia_Complementar { get; set; }

        [Display(Name = "Conteúdo Programatico")]
        public string? Conteudo_Programatico { get; set; }

        [Display(Name = "Atividade Fora de Aula")]
        public string? Atividade_Fora_Aula { get; set; }

        [Display(Name = "Método de Avaliação")]
        public string? Metodo_Avaliacao { get; set; }

        [Display(Name = "CH Presencial Teórica")]
        [Range(0, int.MaxValue, ErrorMessage = "Informe um número válido")]
        public int Ch_Presencial_Teorica { get; set; }

        [Display(Name = "CH Presencial Prática")]
        public int Ch_Presencial_Pratica { get; set; }

        [Display(Name = "CH EAD Teórica")]
        public int Ch_Ead_Teorica { get; set; }

        [Display(Name = "CH EAD Prática")]
        public int Ch_Ead_Pratica { get; set; }

        [Display(Name = "CH de Estudos")]
        public int Ch_Estudo { get; set; }

        [Display(Name = "Carga Horária")]

        public int Ch { get; set; }

        public bool? Ativo { get; set; }

        public Disciplina()
        {
            Codigo_Mec = "";
            Ementa = "";
            Objetivo_Geral = "";
            Objetivo_Especifico = "";
            Bibliografia_Basica = "";
            Bibliografia_Complementar = "";
            Conteudo_Programatico = "";
            Atividade_Fora_Aula = "";
            Metodo_Avaliacao = "";
            Ch_Presencial_Pratica = 0;
            Ch_Presencial_Teorica = 0;
            Ch_Ead_Pratica = 0;
            Ch_Ead_Teorica = 0;
            Ch_Estudo = 0;
            Ch = 0;
            Ativo = true;
        }
    }
}
