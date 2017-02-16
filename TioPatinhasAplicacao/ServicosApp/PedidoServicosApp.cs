using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class PedidoServicosApp : BaseServicosApp<Pedido>, IPedidoServicosApp
    {
        private readonly IPedidoServicos _servicos;

        public PedidoServicosApp(IPedidoServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
