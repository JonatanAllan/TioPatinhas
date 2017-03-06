using System;

namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    public class PedidoViewModel
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public int FornecedorCodigo { get; set; }

        public int StatusCodigo { get; set; }

        public int PedidoOrigem { get; set; }

        public double ValorPedido { get; set; }

        public double ValorFrete { get; set; }

        public double ValorEncargos { get; set; }

        public double ValorDesconto { get; set; }

        public DateTime DataCompra { get; set; }

        public DateTime DataPrazoEntrega { get; set; }

    }
}
