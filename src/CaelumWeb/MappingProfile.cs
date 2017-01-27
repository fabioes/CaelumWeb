using AutoMapper;
using Caelum.Infra.Dados;
using CaelumWeb.Models;

namespace CaelumWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, Aluno>();
            CreateMap<Aluno, Aluno>();
            CreateMap<Curso, Curso>();
            CreateMap<Curso, Curso>();
        }

    }
}
