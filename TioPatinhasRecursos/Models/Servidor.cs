namespace TioPatinhasRecursos.Models
{
    public class Servidor
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string IpInterno { get; set; }
        public string IpExterno { get; set; }

        public string ObterStringConexaoInterna(string nomeBancoDados)
        {
            return $@"Data Source={IpInterno};Persist Security Info=True;MultipleActiveResultSets=true;User ID={Usuario};Password={Senha};Initial Catalog={nomeBancoDados}";
        }

        public string ObterStringConexaoExterna(string nomeBancoDados)
        {
            return $@"Data Source={IpExterno};Persist Security Info=True;MultipleActiveResultSets=true;User ID={Usuario};Password={Senha};Initial Catalog={nomeBancoDados}";
        }

        public Servidor()
        {

        }

        public Servidor(string usuario, string senha, string ipInterno, string ipExterno)
        {
            Usuario = usuario;
            Senha = senha;
            IpInterno = ipInterno;
            IpExterno = ipExterno;
        }
    }
}
