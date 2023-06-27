namespace Dharma.Models
{
    public class AlunoCurso
    {
        public int Id { get; set; }
        public int Aluno_Id { get; set; }
        public int Curso_Id { get; set; }
        public required DateTime Data_Cadastro { get; set; }
        public int Situacao_Id { get; set; }

        public AlunoCurso()
        {
            Situacao_Id = 0; // Aguardando
            Data_Cadastro = DateTime.UtcNow;
        }
    }
}
