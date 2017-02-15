namespace TioPatinhasDominio.Entidades
{
    public class ProdutoFornecedor : BaseEntidade
    {
        public int ProdutoCodigo { get; set; }
        public virtual Produto Produto { get; set; }

        public int FornecedorCodigo { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public string CodigoProdutoFornecedor { get; set; }

        public int QuantidadeDiasGarantia { get; set; }

        public double PrecoTabela { get; set; }

        public double PrecoPromocional { get; set; }
    }
}
