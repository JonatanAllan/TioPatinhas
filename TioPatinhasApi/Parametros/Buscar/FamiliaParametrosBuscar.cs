using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.Atributos;

namespace TioPatinhasApi.Parametros.Buscar
{
    [AtLeastOneProperty("Codigo", "CodigoExterno")]
    public class FamiliaParametrosBuscar : BaseParametrosBuscar<Familia>
    {
        public int? Codigo { get; set; }
        public string CodigoExterno { get; set; }

        public override Expression<Func<Familia, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Familia>();

            if (Codigo != null)
            {
                condicoes = condicoes.And(x => x.Codigo == Codigo.Value);
            }

            if (!string.IsNullOrWhiteSpace(CodigoExterno))
            {
                condicoes = condicoes.And(x => x.CodigoExterno.Equals(CodigoExterno));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}