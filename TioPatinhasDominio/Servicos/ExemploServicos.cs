using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class ExemploServicos : BaseServicos<Exemplo>, IExemploServicos
    {
        private readonly IExemploRepositorio _repositorio;

        public ExemploServicos(IExemploRepositorio repositorio)
            : base (repositorio)
        {
            _repositorio = repositorio;
        }
    }
}