namespace Caelum.Infra.Dados
{
    public static class CaelumContextExtensions
    {
        public static void EnsureSeedData(this CaelumContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Curso.AddRange(
              new Curso { Nome = "ASP.NET Core", Ativo = false },
              new Curso { Nome = "Android 1", Ativo = true },
              new Curso { Nome = "Android 2", Ativo = true },
              new Curso { Nome = "IOS 1", Ativo = true },
              new Curso { Nome = "IOS 2", Ativo = false },
              new Curso { Nome = "Java Web", Ativo = true },
              new Curso { Nome = "Design Patterns Java", Ativo = true }
              );
            context.SaveChanges();
            context.Aluno.AddRange(
                new Aluno { Nome = "José Miranda da Silva", Cpf = "823.338.063-62", Endereco = "Rua Cataventos, 340" },
                new Aluno { Nome = "João da Silva Medeiros", Cpf = "621.254.263-58", Endereco = "Rua Vergueiro, 11" },
                new Aluno { Nome = "Thiago Bastos Cordeiro", Cpf = "351.696.766-89", Endereco = "Avenida Ver. José Diniz, 1438" },
                new Aluno { Nome = "Cláudio Quirino da Fonseca", Cpf = "955.368.767-91", Endereco = "Al. dos Jurupis, 57" },
                new Aluno { Nome = "Rafael Souza de Lima", Cpf = "475.453.832-30", Endereco = "Av. Brasil, 1345" }
                );
            context.SaveChanges();
        }
    }
}
