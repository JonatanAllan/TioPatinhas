using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;

namespace TioPatinhasApi.Parametros.Buscar
{
    public class ExemploParametrosBuscar : BaseParametrosBuscar<Exemplo>
    {
        public int? Codigo { get; set; }
        public int? CodigoAdicional { get; set; }

        public override Expression<Func<Exemplo, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Exemplo>();

            if (Codigo != null)
            {
                condicoes = condicoes.And(x => x.Codigo == Codigo.Value);
            }

            if (CodigoAdicional != null)
            {
                condicoes = condicoes.And(x => x.CodigoAdicional == CodigoAdicional.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}