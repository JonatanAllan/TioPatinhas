using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class ClasseServicos : BaseServicos<Classe>, IClasseServicos
    {
        private readonly IClasseRepositorio _repositorio;

        public ClasseServicos(IClasseRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
