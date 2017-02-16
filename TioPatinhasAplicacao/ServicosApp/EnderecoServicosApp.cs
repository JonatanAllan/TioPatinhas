using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class EnderecoServicosApp : BaseServicosApp<Endereco>, IEnderecoServicosApp
    {
        private readonly IEnderecoServicos _servicos;

        public EnderecoServicosApp(IEnderecoServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
