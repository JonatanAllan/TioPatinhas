using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class GrupoServicosApp : BaseServicosApp<Grupo>, IGrupoServicosApp
    {
        private readonly IGrupoServicos _servicos;

        public GrupoServicosApp(IGrupoServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
