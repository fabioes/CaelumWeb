using Microsoft.EntityFrameworkCore;

namespace Caelum.Infra.Dados
{
    public class CaelumContext : DbContext
    {
        public CaelumContext(DbContextOptions<CaelumContext> options)
            : base(options)
        { }
        public DbSet<AlunoDAO> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<AlunoCurso> AlunoCurso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuração da tabela de alunos
            modelBuilder.Entity<AlunoDAO>().HasMany(b => b.Curso).WithOne();
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Id).HasColumnName("IdAluno");
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Nome).HasColumnName("NmAluno").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Cpf).ForSqlServerHasColumnType("varchar(50)");
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Cidade).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Endereco).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoDAO>().Property(b => b.Estado).ForSqlServerHasColumnType("varchar(200)");
            //Configuração da tabela de cursos
            modelBuilder.Entity<Curso>().Property(b => b.Id).HasColumnName("IdCurso");
            modelBuilder.Entity<Curso>().Property(b => b.Nome).HasColumnName("NmCurso").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoCurso>().Property(b => b.PercentualCompleto).HasColumnName("PctCompleto");
            modelBuilder.Entity<AlunoCurso>().Property(b => b.DataFinal).HasColumnName("DtFinal");

        }
    }

}
