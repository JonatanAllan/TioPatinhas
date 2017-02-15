using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class FamiliaServicos : BaseServicos<Familia>, IFamiliaServicos
    {
        private readonly IFamiliaRepositorio _repositorio;

        public FamiliaServicos(IFamiliaRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
