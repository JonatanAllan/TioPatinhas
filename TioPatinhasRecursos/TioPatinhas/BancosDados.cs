using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TioPatinhasRecursos.Models;

namespace TioPatinhasRecursos.TioPatinhas
{
    public class BancosDados
    {
        // Servidores
        private static readonly Servidor Desenvolvimento = new Servidor
        {
            Usuario = "usuario",
            Senha = "senha",
            IpInterno = "192.168.0.10",
            IpExterno = "exemplo.database.com.br,8080"
        };

        // Bancos de Dados
        public static string TioPatinhas(TipoConexao? tipoConexao = null) =>
            ObterStringConexao(tipoConexao, Desenvolvimento, "TioPatinhas");

        // Helpers
        private static string ObterStringConexao(TipoConexao? tipoConexao, Servidor servidor, string nomeBancoDados)
        {
            switch (tipoConexao)
            {
                case TipoConexao.Local:
                    return @"Data Source=.\SQLEXPRESS;Integrated Security=True;Initial Catalog=" + nomeBancoDados;
                case TipoConexao.Externa:
                    return servidor.ObterStringConexaoExterna(nomeBancoDados);
                default:
                    return servidor.ObterStringConexaoInterna(nomeBancoDados);
            }
        }

        public enum TipoConexao
        {
            Local,
            Interna,
            Externa
        }
    }
}
