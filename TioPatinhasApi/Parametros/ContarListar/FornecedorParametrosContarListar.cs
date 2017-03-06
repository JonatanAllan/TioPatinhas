using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class FornecedorParametrosContarListar : BaseParametrosContarListar<Fornecedor>
    {
        public string RazaoSocial { get; set; }
        public bool? SomenteAtivos { get; set; }

        public override Expression<Func<Fornecedor, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Fornecedor>();

            if (RazaoSocial != null)
            {
                condicoes = condicoes.And(x => x.RazaoSocial.Contains(RazaoSocial));
            }

            if (SomenteAtivos != null)
            {
                condicoes = SomenteAtivos.Value
                    ? condicoes.And(x => x.DataDesativado == null)
                    : condicoes.And(x => x.DataDesativado != null);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}