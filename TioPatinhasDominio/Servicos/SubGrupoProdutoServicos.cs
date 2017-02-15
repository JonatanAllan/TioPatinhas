using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class SubGrupoProdutoServicos : BaseServicos<SubGrupoProduto>, ISubGrupoProdutoServicos
    {
        private readonly ISubGrupoProdutoRepositorio _repositorio;

        public SubGrupoProdutoServicos(ISubGrupoProdutoRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
