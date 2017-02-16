using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class FornecedorServicosApp : BaseServicosApp<Fornecedor>, IFornecedorServicosApp
    {
        private readonly IFornecedorServicos _servicos;

        public FornecedorServicosApp(IFornecedorServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
