using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class ClasseParametrosContarListar : BaseParametrosContarListar<Classe>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override Expression<Func<Classe, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Classe>();

            if (Descricao != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Descricao));
            }

            if (Nome != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Nome));
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}