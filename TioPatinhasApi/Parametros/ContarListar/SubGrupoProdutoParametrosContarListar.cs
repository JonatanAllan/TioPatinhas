using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class SubGrupoProdutoParametrosContarListar : BaseParametrosContarListar<SubGrupoProduto>
    {
        public string Nome { get; set; }
        public int? GrupoCodigo { get; set; }
        public string GrupoCodigoExterno { get; set; }

        public override Expression<Func<SubGrupoProduto, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<SubGrupoProduto>();

            if (Nome != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Nome));
            }

            if (GrupoCodigoExterno != null)
            {
                condicoes = condicoes.And(x => x.GrupoCodigoExterno.Contains(GrupoCodigoExterno));
            }

            if (GrupoCodigo != null)
            {
                condicoes = condicoes.And(x => x.GrupoCodigo == GrupoCodigo.Value);
            }

            return condicoes.Body.NodeType == ExpressionType.Constant ? null : condicoes;
        }
    }
}