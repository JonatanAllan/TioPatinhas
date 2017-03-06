using SimpleInjector;
using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasAplicacao.ServicosApp;
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
            container.Register<IClasseServicosApp, ClasseServicosApp>(Lifestyle.Scoped);
            container.Register<IEnderecoServicosApp, EnderecoServicosApp>(Lifestyle.Scoped);
            container.Register<IFamiliaServicosApp, FamiliaServicosApp>(Lifestyle.Scoped);
            container.Register<IFornecedorServicosApp, FornecedorServicosApp>(Lifestyle.Scoped);
            container.Register<IGrupoServicosApp, GrupoServicosApp>(Lifestyle.Scoped);
            container.Register<IMarcaServicosApp, MarcaServicosApp>(Lifestyle.Scoped);
            container.Register<IPedidoItemServicosApp, PedidoItemServicosApp>(Lifestyle.Scoped);
            container.Register<IPedidoServicosApp, PedidoServicosApp>(Lifestyle.Scoped);
            container.Register<IPedidoStatusServicosApp, PedidoStatusServicosApp>(Lifestyle.Scoped);
            container.Register<IProdutoFornecedorServicosApp, ProdutoFornecedorServicosApp>(Lifestyle.Scoped);
            container.Register<IProdutoServicosApp, ProdutoServicosApp>(Lifestyle.Scoped);
            container.Register<ISubGrupoProdutoServicosApp, SubGrupoProdutoServicosApp>(Lifestyle.Scoped);

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
            //container.Register<IClasseRepositorio, ClasseRepositorio>(Lifestyle.Scoped);
            //container.Register<IEnderecoRepositorio, EnderecoRepositorio>(Lifestyle.Scoped);
            //container.Register<IFamiliaRepositorio, FamiliaRepositorio>(Lifestyle.Scoped);
            //container.Register<IFornecedorRepositorio, FornecedorRepositorio>(Lifestyle.Scoped);
            //container.Register<IGrupoRepositorio, GrupoRepositorio>(Lifestyle.Scoped);
            //container.Register<IMarcaRepositorio, MarcaRepositorio>(Lifestyle.Scoped);
            //container.Register<IPedidoItemRepositorio, PedidoItemRepositorio>(Lifestyle.Scoped);
            //container.Register<IPedidoRepositorio, PedidoRepositorio>(Lifestyle.Scoped);
            //container.Register<IPedidoStatusRepositorio, PedidoStatusRepositorio>(Lifestyle.Scoped);
            //container.Register<IProdutoFornecedorRepositorio, ProdutoFornecedorRepositorio>(Lifestyle.Scoped);
            //container.Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Scoped);
            //container.Register<ISubGrupoProdutoRepositorio, SubGrupoProdutoRepositorio>(Lifestyle.Scoped);
        }
    }
}