using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class PedidoServicos : BaseServicos<Pedido>, IPedidoServicos
    {
        private readonly IPedidoRepositorio _repositorio;

        public PedidoServicos(IPedidoRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
