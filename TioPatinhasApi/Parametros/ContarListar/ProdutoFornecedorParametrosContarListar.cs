using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class ProdutoFornecedorParametrosContarListar : BaseParametrosContarListar<ProdutoFornecedor>
    {
        public int? ProdutoCodigo { get; set; }
        public int? FornecedorCodigo { get; set; }
        public int? QuantidadeDiasGarantia { get; set; }

        public override Expression<Func<ProdutoFornecedor, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<ProdutoFornecedor>();

            if (ProdutoCodigo != null)
            {
                condicoes = condicoes.And(x => x.ProdutoCodigo == ProdutoCodigo.Value);
            }

            if (FornecedorCodigo != null)
            {
                condicoes = condicoes.And(x => x.FornecedorCodigo == FornecedorCodigo.Value);
            }

            if (QuantidadeDiasGarantia != null)
            {
                condicoes = condicoes.And(x => x.QuantidadeDiasGarantia == QuantidadeDiasGarantia.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}