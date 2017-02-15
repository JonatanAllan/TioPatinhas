using SimpleInjector;
using TioPatinhasDominio.Interfaces.Servicos;
using TioPatinhasDominio.Servicos;
using TioPatinhasRecursos.Interfaces.ServicosExternos;
using TioPatinhasRecursos.ServicosExternos;
using TioPatinhasTarefa.Interfaces.Tarefas;
using TioPatinhasTarefa.Tarefas;

namespace TioPatinhasTransversal
{
    public class Bootstrapper
    {
        public static void RegisterServices(Container container)
        {
            // Crons
            container.Register<IExemploTarefa, ExemploTarefa>(Lifestyle.Scoped);

            // Recursos
            container.Register<IExemploServicosExternos, ExemploServicosExternos>(Lifestyle.Scoped);

            // Aplicacao
            //container.Register<IExemploServicosApp, ExemploServicosApp>(Lifestyle.Scoped);

            // Dominio
            container.Register<IClasseServicos, ClasseServicos>(Lifestyle.Scoped);
            container.Register<IEnderecoServicos, EnderecoServicos>(Lifestyle.Scoped);
            container.Register<IFamiliaServicos, FamiliaServicos>(Lifestyle.Scoped);
            container.Register<IFornecedorServicos, FornecedorServicos>(Lifestyle.Scoped);
            container.Register<IGrupoServicos, GrupoServicos>(Lifestyle.Scoped);
            container.Register<IMarcaServicos, MarcaServicos>(Lifestyle.Scoped);
            container.Register<IPedidoItemServicos, PedidoItemServicos>(Lifestyle.Scoped);
            container.Register<IPedidoServicos, PedidoServicos>(Lifestyle.Scoped);
            container.Register<IPedidoStatusServicos, PedidoStatusServicos>(Lifestyle.Scoped);
            container.Register<IProdutoFornecedorServicos, ProdutoFornecedorServicos>(Lifestyle.Scoped);
            container.Register<IProdutoServicos, ProdutoServicos>(Lifestyle.Scoped);
            container.Register<ISubGrupoProdutoServicos, SubGrupoProdutoServicos>(Lifestyle.Scoped);

            // Infra
            //container.Register<IExemploRepositorio, ExemploRepositorio>(Lifestyle.Scoped);
        }
    }
}