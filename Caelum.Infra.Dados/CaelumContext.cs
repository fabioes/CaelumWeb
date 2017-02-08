using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Caelum.Infra.Dados
{
    public class CaelumContext : IdentityDbContext<Usuario>
    {
        public CaelumContext(DbContextOptions<CaelumContext> options)
            : base(options)
        { }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<AlunoCurso> AlunoCurso { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuração da tabela de alunos
            modelBuilder.Entity<Aluno>().HasMany(b => b.Cursos).WithOne();
            modelBuilder.Entity<Aluno>().Property(b => b.Id).HasColumnName("IdAluno");
            modelBuilder.Entity<Aluno>().Property(b => b.Nome).HasColumnName("NmAluno").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<Aluno>().Property(b => b.Cpf).ForSqlServerHasColumnType("varchar(50)");
            modelBuilder.Entity<Aluno>().Property(b => b.Cidade).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<Aluno>().Property(b => b.Endereco).ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<Aluno>().Property(b => b.Estado).ForSqlServerHasColumnType("varchar(200)");
            //Configuração da tabela de cursos
            modelBuilder.Entity<Curso>().Property(b => b.Id).HasColumnName("IdCurso");
            modelBuilder.Entity<Curso>().Property(b => b.Nome).HasColumnName("NmCurso").ForSqlServerHasColumnType("varchar(200)");
            modelBuilder.Entity<AlunoCurso>().Property(b => b.PercentualCompleto).HasColumnName("PctCompleto");
            modelBuilder.Entity<AlunoCurso>().Property(b => b.DataFinal).HasColumnName("DtFinal");

        }
    }

}
