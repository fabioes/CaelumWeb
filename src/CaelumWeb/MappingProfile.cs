using AutoMapper;
using Caelum.Infra.Dados;
using CaelumWeb.Areas.Aluno.Models;

namespace CaelumWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoDAO>();
            CreateMap<AlunoDAO, Aluno>();
        }

    }
}
