namespace TioPatinhasDominio.Entidades
{
    public class PedidoItem : BaseEntidade
    {
        public int PedidoCodigo { get; set; }
        public virtual Pedido Pedido { get; set; }

        public int ProdutoCodigo { get; set; }
        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double PrecoUnitario { get; set; }
    }
}
