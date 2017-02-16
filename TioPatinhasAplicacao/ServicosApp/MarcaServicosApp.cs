using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class MarcaServicosApp : BaseServicosApp<Marca>, IMarcaServicosApp
    {
        private readonly IMarcaServicos _servicos;

        public MarcaServicosApp(IMarcaServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
