using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class ProdutoFornecedorServicosApp : BaseServicosApp<ProdutoFornecedor>, IProdutoFornecedorServicosApp
    {
        private readonly IProdutoFornecedorServicos _servicos;

        public ProdutoFornecedorServicosApp(IProdutoFornecedorServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
