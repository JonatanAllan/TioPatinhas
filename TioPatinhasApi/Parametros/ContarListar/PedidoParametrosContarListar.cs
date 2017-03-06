using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class PedidoParametrosContarListar : BaseParametrosContarListar<Pedido>
    {
        public int? FornecedorCodigo { get; set; }
        public int? StatusCodigo { get; set; }
        public PedidoOrigem? PedidoOrigem { get; set; }
        public DateTime? DataInicialCompra { get; set; }
        public DateTime? DataFinalCompra { get; set; }

        public override Expression<Func<Pedido, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Pedido>();

            if (FornecedorCodigo != null)
            {
                condicoes = condicoes.And(x => x.FornecedorCodigo == FornecedorCodigo.Value);
            }

            if (StatusCodigo != null)
            {
                condicoes = condicoes.And(x => x.StatusCodigo == StatusCodigo.Value);
            }

            if (PedidoOrigem != null)
            {
                condicoes = condicoes.And(x => x.PedidoOrigem == PedidoOrigem.Value);
            }

            if (DataInicialCompra != null)
            {
                condicoes = condicoes.And(x => x.DataCompra > DataInicialCompra.Value);
            }

            if (DataFinalCompra != null)
            {
                condicoes = condicoes.And(x => x.DataCompra < DataFinalCompra.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}