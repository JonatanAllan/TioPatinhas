using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Marca : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
