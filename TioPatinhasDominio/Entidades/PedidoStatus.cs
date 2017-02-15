using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class PedidoStatus : BaseEntidade
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
