using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.Atributos;

namespace TioPatinhasApi.Parametros.Buscar
{
    [AtLeastOneProperty("ProdutoCodigo")]
    [AtLeastOneProperty("FornecedorCodigo")]
    public class ProdutoFornecedorParametrosBuscar : BaseParametrosBuscar<ProdutoFornecedor>
    {
        public int? ProdutoCodigo { get; set; }
        public int? FornecedorCodigo { get; set; }

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

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}