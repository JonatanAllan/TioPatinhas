using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasAplicacao.ServicosApp
{
    public class ClasseServicosApp: BaseServicosApp<Classe>, IClasseServicosApp
    {
        private readonly IClasseServicos _servicos;

        public ClasseServicosApp(IClasseServicos servicos)
            : base (servicos)
        {
            _servicos = servicos;
        }
    }
}
