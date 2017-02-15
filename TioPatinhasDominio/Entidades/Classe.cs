using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Classe : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public string Nome { get; set; }

        public DateTime DataExclusao { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
