using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class MarcaServicos : BaseServicos<Marca>, IMarcaServicos
    {
        private readonly IMarcaRepositorio _repositorio;

        public MarcaServicos(IMarcaRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
