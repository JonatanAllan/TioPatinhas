using AutoMapper;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.ViewModels.TioPatinhasApi;

namespace TioPatinhasTransversal
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(map => map.AddProfile<PerfilMapeamento>());
        }
    }

    public class PerfilMapeamento : Profile
    {
        public override string ProfileName => "TioPatinhas";
        public PerfilMapeamento()
        {
            CreateMap<Classe, ClasseViewModel>();
        }
    }
}
