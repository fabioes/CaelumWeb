using AutoMapper;
using Caelum.Infra.Dados;
using CaelumWeb.Models;

namespace CaelumWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoDTO>();
            CreateMap<AlunoDTO, Aluno>();
            CreateMap<Curso, CursoDTO>();
            CreateMap<CursoDTO, Curso>();
        }

    }
}
