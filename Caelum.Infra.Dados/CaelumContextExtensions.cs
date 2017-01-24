namespace Caelum.Infra.Dados
{
    public static class CaelumContextExtensions
    {
        public static void EnsureSeedData(this CaelumContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Curso.AddRange(
              new CursoDTO { Nome = "ASP.NET Core" },
              new CursoDTO { Nome = "Android 1" },
              new CursoDTO { Nome = "Android 2" },
              new CursoDTO { Nome = "IOS 1" },
              new CursoDTO { Nome = "IOS 2" },
              new CursoDTO { Nome = "Java Web" },
              new CursoDTO { Nome = "Design Patterns Java" }
              );
            context.SaveChanges();
            context.Aluno.AddRange(
                new AlunoDTO { Nome = "José Miranda da Silva", Cpf = "823.338.063-62" },
                new AlunoDTO { Nome = "João da Silva Medeiros", Cpf = "621.254.263-58" },
                new AlunoDTO { Nome = "Thiago Bastos Cordeiro", Cpf = "351.696.766-89" },
                new AlunoDTO { Nome = "Cláudio Quirino da Fonseca", Cpf = "955.368.767-91" },
                new AlunoDTO { Nome = "Rafael Souza de Lima", Cpf = "475.453.832-30" }
                );
            context.SaveChanges();
        }
    }
}
