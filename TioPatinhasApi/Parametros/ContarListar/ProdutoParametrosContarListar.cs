using System;
using System.Linq.Expressions;
using TioPatinhasApi.Recursos;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Parametros.ContarListar
{
    public class ProdutoParametrosContarListar : BaseParametrosContarListar<Produto>
    {
        public string Nome { get; set; }
        public int? CodigoPai { get; set; }
        public bool? Kit { get; set; }
        public int? ClasseCodigo { get; set; }
        public int? FamiliaCodigo { get; set; }
        public int? MarcaCodigo { get; set; }
        public int? SubGrupoProdutoCodigo { get; set; }
        public bool? SomenteAtivos { get; set; }

        public override Expression<Func<Produto, bool>> Expressao()
        {
            var condicoes = PredicateBuilder.True<Produto>();

            if (Nome != null)
            {
                condicoes = condicoes.And(x => x.Nome.Contains(Nome));
            }

            if (CodigoPai != null)
            {
                condicoes = condicoes.And(x => x.CodigoPai == CodigoPai.Value);
            }

            if (ClasseCodigo != null)
            {
                condicoes = condicoes.And(x => x.ClasseCodigo == ClasseCodigo.Value);
            }

            if (FamiliaCodigo != null)
            {
                condicoes = condicoes.And(x => x.FamiliaCodigo == FamiliaCodigo.Value);
            }

            if (MarcaCodigo != null)
            {
                condicoes = condicoes.And(x => x.MarcaCodigo == MarcaCodigo.Value);
            }

            if (SubGrupoProdutoCodigo != null)
            {
                condicoes = condicoes.And(x => x.SubGrupoProdutoCodigo == SubGrupoProdutoCodigo.Value);
            }

            if (Kit != null)
            {
                condicoes = condicoes.And(x => x.Kit == Kit.Value);
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