using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Caelum.Infra.Dados
{
    public class CaelumContext : DbContext
    {
        public CaelumContext(DbContextOptions<CaelumContext> options)
            : base(options)
        { }
        public DbSet<AlunoDTO> Aluno { get; set; }
        public DbSet<CursoDTO> Curso { get; set; }
        public DbSet<AlunoCursoDTO> AlunoCurso { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuração da tabela de alunos
            modelBuilder.Entity<AlunoDTO>().HasMany(b => b.Cursos).WithOne();
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Id).HasColumnName("IdAluno");
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Nome).HasColumnName("NmAluno").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Cpf).ForSqlServerHasColumnType("varchar(50)");
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Cidade).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Endereco).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDTO>().Property(b => b.Estado).ForSqlServerHasColumnType("varchar(200)");
            //Configuração da tabela de cursos
            modelBuilder.Entity<CursoDTO>().Property(b => b.Id).HasColumnName("IdCurso");
            modelBuilder.Entity<CursoDTO>().Property(b => b.Nome).HasColumnName("NmCurso").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoCursoDTO>().Property(b => b.PercentualCompleto).HasColumnName("PctCompleto");
            modelBuilder.Entity<AlunoCursoDTO>().Property(b => b.DataFinal).HasColumnName("DtFinal");
         
        }
    }

}
