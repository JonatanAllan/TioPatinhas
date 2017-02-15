using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class ProdutoFornecedorServicos : BaseServicos<ProdutoFornecedor>, IProdutoFornecedorServicos
    {
        private readonly IProdutoFornecedorRepositorio _repositorio;

        public ProdutoFornecedorServicos(IProdutoFornecedorRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
