using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class ProdutoServicosApp : BaseServicosApp<Produto>, IProdutoServicosApp
    {
        private readonly IProdutoServicos _servicos;

        public ProdutoServicosApp(IProdutoServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
