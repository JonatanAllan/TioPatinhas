using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class PedidoItemServicos : BaseServicos<PedidoItem>, IPedidoItemServicos
    {
        private readonly IPedidoItemRepositorio _repositorio;

        public PedidoItemServicos(IPedidoItemRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
