using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class GrupoServicos : BaseServicos<Grupo>, IGrupoServicos
    {
        private readonly IGrupoRepositorio _repositorio;

        public GrupoServicos(IGrupoRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
