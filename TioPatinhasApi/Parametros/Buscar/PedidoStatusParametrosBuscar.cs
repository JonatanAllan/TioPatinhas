using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.Atributos;

namespace TioPatinhasApi.Parametros.Buscar
{
    [AtLeastOneProperty("Codigo")]
    public class PedidoStatusParametrosBuscar : BaseParametrosBuscar<PedidoStatus>
    {
        public int? Codigo { get; set; }

        public override Expression<Func<PedidoStatus, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<PedidoStatus>();

            if (Codigo != null)
            {
                condicoes = condicoes.And(x => x.Codigo == Codigo.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}