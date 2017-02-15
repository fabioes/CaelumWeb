using AutoMapper;
using Caelum.Infra.Dados;
using Caelumweb.ViewModels;

namespace Caelumweb
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<AlunoViewModel, Aluno>();
        }
    }
}
