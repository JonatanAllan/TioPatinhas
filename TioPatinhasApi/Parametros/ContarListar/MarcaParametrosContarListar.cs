using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class MarcaParametrosContarListar : BaseParametrosContarListar<Marca>
    {
        public string Nome { get; set; }

        public override Expression<Func<Marca, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Marca>();

            if (Nome != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Nome));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}