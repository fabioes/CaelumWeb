namespace Caelum.Infra.Dados
{
    public static class CaelumContextExtensions
    {
        public static void EnsureSeedData(this CaelumContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Curso.AddRange(
              new Curso { Nome = "ASP.NET Core" },
              new Curso { Nome = "Android 1" },
              new Curso { Nome = "Android 2" },
              new Curso { Nome = "IOS 1" },
              new Curso { Nome = "IOS 2" },
              new Curso { Nome = "Java Web" },
              new Curso { Nome = "Design Patterns Java" }
              );
            context.SaveChanges();
            context.Aluno.AddRange(
                new AlunoDAO { Nome = "José Miranda da Silva", Cpf = "823.338.063-62" },
                new AlunoDAO { Nome = "João da Silva Medeiros", Cpf = "621.254.263-58" },
                new AlunoDAO { Nome = "Thiago Bastos Cordeiro", Cpf = "351.696.766-89" },
                new AlunoDAO { Nome = "Cláudio Quirino da Fonseca", Cpf = "955.368.767-91" },
                new AlunoDAO { Nome = "Rafael Souza de Lima", Cpf = "475.453.832-30" }
                );
            context.SaveChanges();
        }
    }
}
