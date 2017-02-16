using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class SubGrupoProdutoServicosApp : BaseServicosApp<SubGrupoProduto>, ISubGrupoProdutoServicosApp
    {
        private readonly ISubGrupoProdutoServicos _servicos;

        public SubGrupoProdutoServicosApp(ISubGrupoProdutoServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
