using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class FornecedorServicos : BaseServicos<Fornecedor>, IFornecedorServicos
    {
        private readonly IFornecedorRepositorio _repositorio;

        public FornecedorServicos(IFornecedorRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
