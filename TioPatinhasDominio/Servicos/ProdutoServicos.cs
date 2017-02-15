using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class ProdutoServicos : BaseServicos<Produto>, IProdutoServicos
    {
        private readonly IProdutoRepositorio _repositorio;

        public ProdutoServicos(IProdutoRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
