using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Pedido : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public int FornecedorCodigo { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public int StatusCodigo { get; set; }
        public virtual PedidoStatus Status { get; set; }

        public PedidoOrigem PedidoOrigem { get; set; }

        public double ValorPedido { get; set; }

        public double ValorFrete { get; set; }

        public double ValorEncargos { get; set; }

        public double ValorDesconto { get; set; }

        public DateTime DataCompra { get; set; }

        public DateTime DataPrazoEntrega { get; set; }

        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }

    public enum PedidoOrigem
    {
        Manual = 0,
        Automatico = 1
    }
}
