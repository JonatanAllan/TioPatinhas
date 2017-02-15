using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class PedidoStatusServicos : BaseServicos<PedidoStatus>, IPedidoStatusServicos
    {
        private readonly IPedidoStatusRepositorio _repositorio;

        public PedidoStatusServicos(IPedidoStatusRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
