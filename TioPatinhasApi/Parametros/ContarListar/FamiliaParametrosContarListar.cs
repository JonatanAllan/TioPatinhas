using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class FamiliaParametrosContarListar : BaseParametrosContarListar<Familia>
    {
        public string Nome { get; set; }

        public override Expression<Func<Familia, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Familia>();

            if (Nome != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Nome));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}