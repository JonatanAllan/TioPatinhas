using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class ExemploServicosApp : BaseServicosApp<Exemplo>, IExemploServicosApp
    {
        private readonly IExemploServicos _servicos;

        public ExemploServicosApp(IExemploServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}