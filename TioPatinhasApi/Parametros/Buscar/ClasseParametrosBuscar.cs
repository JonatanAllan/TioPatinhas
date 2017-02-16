using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.Buscar
{
    public class ClasseParametrosBuscar : BaseParametrosBuscar<Classe>
    {
        public int? Codigo { get; set; }
        public int? CodigoAdicional { get; set; }

        public override Expression<Func<Classe, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Classe>();

            if (Codigo != null)
            {
                condicoes = condicoes.And(x => x.Codigo == Codigo.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}