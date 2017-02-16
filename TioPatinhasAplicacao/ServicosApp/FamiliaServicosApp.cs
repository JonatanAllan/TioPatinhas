using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class FamiliaServicosApp : BaseServicosApp<Familia>, IFamiliaServicosApp
    {
        private readonly IFamiliaServicos _servicos;

        public FamiliaServicosApp(IFamiliaServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
