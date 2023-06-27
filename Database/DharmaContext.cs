using Dharma.Models;
using Microsoft.EntityFrameworkCore;

namespace Dharma.Database
{
    public class DharmaContext : DbContext
    {
        public DharmaContext(DbContextOptions<DharmaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }

        public DbSet<Aluno> Alunos => Set<Aluno>();
        public DbSet<AlunoCurso> AlunoCursos => Set<AlunoCurso>();
        public DbSet<Curso> Cursos => Set<Curso>();
        public DbSet<Disciplina> Disciplinas => Set<Disciplina>();
        public DbSet<Matricula> Matriculas => Set<Matricula>();
        public DbSet<MotivoDesistencia> MotivosDesistencia => Set<MotivoDesistencia>();
        public DbSet<Nacionalidade> Nacionalidades => Set<Nacionalidade>();
        public DbSet<NivelEnsino> NiveisEnsino => Set<NivelEnsino>();
        public DbSet<Pessoa> Pessoas => Set<Pessoa>();
        public DbSet<Turno> Turnos => Set<Turno>();


    }

    //Seeds
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Disciplina>().HasData(
                   new Disciplina() { Nome = "Português", Nome_Resumido = "PORT", Id = 1, Identificacao = "1" },
                   new Disciplina() { Nome = "Matemática", Nome_Resumido = "MAT", Id = 2, Identificacao = "2" },
                   new Disciplina() { Nome = "História", Nome_Resumido = "HIST", Id = 3, Identificacao = "3" },
                   new Disciplina() { Nome = "Geografia", Nome_Resumido = "GEO", Id = 4, Identificacao = "4"  },
                   new Disciplina() { Nome = "Ciências", Nome_Resumido = "CIE", Id = 5, Identificacao = "5"  },
                   new Disciplina() { Nome = "Artes", Nome_Resumido = "ARTES", Id = 6, Identificacao = "6"  },
                   new Disciplina() { Nome = "Educação Física", Nome_Resumido = "ED FISICA", Id = 7, Identificacao = "7"  },
                   new Disciplina() { Nome = "Inglês", Nome_Resumido = "INGL", Id = 8, Identificacao = "8"  },
                   new Disciplina() { Nome = "Física", Nome_Resumido = "FISICA", Id = 9, Identificacao = "9"  },
                   new Disciplina() { Nome = "Química", Nome_Resumido = "QUIM", Id = 10, Identificacao = "10"  },
                   new Disciplina() { Nome = "Biologia", Nome_Resumido = "BIO", Id = 11, Identificacao = "11"  },
                   new Disciplina() { Nome = "Espanhol", Nome_Resumido = "ESP", Id = 12, Identificacao = "12"  }
            );

            modelBuilder.Entity<Turno>().HasData(
                new Turno() { Id = 1, Nome = "Manhã" },
                new Turno() { Id = 2, Nome = "Tarde" },
                new Turno() { Id = 3, Nome = "Noite" },
                new Turno() { Id = 4, Nome = "EAD" }
            );

            modelBuilder.Entity<NivelEnsino>().HasData(
                new NivelEnsino() { Id = 1, Nome = "Ensino Fundamental"},
                new NivelEnsino() { Id = 2, Nome = "Ensino Médio"},
                new NivelEnsino() { Id = 3, Nome = "Ensino Superior"},
                new NivelEnsino() { Id = 4, Nome = "Doutorado"},
                new NivelEnsino() { Id = 5, Nome = "Mestrado"}
            );

            modelBuilder.Entity<Nacionalidade>().HasData(
                new Nacionalidade() { Id = 1, Nome = "Brasileira" },
                new Nacionalidade() { Id = 2, Nome = "Argentina" },
                new Nacionalidade() { Id = 3, Nome = "Alemã" }
            );

            modelBuilder.Entity<MotivoDesistencia>().HasData(
                new MotivoDesistencia() { Id = 1, Nome = "Insatisfação" },
                new MotivoDesistencia() { Id = 2, Nome = "Mudança de cidade" },
                new MotivoDesistencia() { Id = 3, Nome = "Dificuldade financeira" }
            );

            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa() { Id = 1, Nome = "Daniel Alves Meloso"},
                new Pessoa() { Id = 2, Nome = "Vitória Alves Meloso"}
            );

            modelBuilder.Entity<Curso>().HasData(
                new Curso() { Id = 1, Nome = "Educação Infantil", Nome_Resumido = "Infantil"},
                new Curso() { Id = 2, Nome = "Ensino Fundamental", Nome_Resumido = "Fund."},
                new Curso() { Id = 3, Nome = "Ensino Médio", Nome_Resumido = "Médio"}
            );
        }
    }
}
