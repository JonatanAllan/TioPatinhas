using TioPatinhasDominio.Entidades;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;

namespace TioPatinhasDominio.Servicos
{
    public class EnderecoServicos : BaseServicos<Endereco>, IEnderecoServicos
    {
        private readonly IEnderecoRepositorio _repositorio;

        public EnderecoServicos(IEnderecoRepositorio repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
