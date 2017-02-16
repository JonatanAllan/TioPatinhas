using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class PedidoStatusServicosApp : BaseServicosApp<PedidoStatus>, IPedidoStatusServicosApp
    {
        private readonly IPedidoStatusServicos _servicos;

        public PedidoStatusServicosApp(IPedidoStatusServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
