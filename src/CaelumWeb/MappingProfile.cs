using AutoMapper;
using Caelum.Infra.Dados;
using CaelumWeb.ViewModels;

namespace CaelumWeb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<Curso, CursoViewModel>();
            CreateMap<CursoViewModel, Curso>();
        }

    }
}
