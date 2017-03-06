namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    public class ProdutoFornecedorViewModel
    {
        public int ProdutoCodigo { get; set; }

        public int FornecedorCodigo { get; set; }

        public string CodigoProdutoFornecedor { get; set; }

        public int QuantidadeDiasGarantia { get; set; }

        public double PrecoTabela { get; set; }

        public double PrecoPromocional { get; set; }
    }
}
