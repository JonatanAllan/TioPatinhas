using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class EnderecoParametrosContarListar : BaseParametrosContarListar<Endereco>
    {
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string CodigoIbge { get; set; }
        public string Municipio { get; set; }

        public override Expression<Func<Endereco, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Endereco>();

            if (Estado != null)
            {
                condicoes = condicoes.And(x => x.Estado.Contains(Estado));
            }

            if (Cep != null)
            {
                condicoes = condicoes.And(x => x.Cep.Contains(Cep));
            }
            if (CodigoIbge != null)
            {
                condicoes = condicoes.And(x => x.CodigoIbge.Contains(CodigoIbge));
            }

            if (Municipio != null)
            {
                condicoes = condicoes.And(x => x.Municipio.Contains(Municipio));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}