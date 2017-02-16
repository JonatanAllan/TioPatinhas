using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class PedidoItemServicosApp : BaseServicosApp<PedidoItem>, IPedidoItemServicosApp
    {
        private readonly IPedidoItemServicos _servicos;

        public PedidoItemServicosApp(IPedidoItemServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
