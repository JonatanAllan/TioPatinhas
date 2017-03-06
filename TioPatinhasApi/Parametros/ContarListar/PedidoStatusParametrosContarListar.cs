using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class PedidoStatusParametrosContarListar : BaseParametrosContarListar<PedidoStatus>
    {
        public string Descricao { get; set; }

        public override Expression<Func<PedidoStatus, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<PedidoStatus>();

            if (Descricao != null)
            {
                condicoes = condicoes.And(x => x.Descricao.Contains(Descricao));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}