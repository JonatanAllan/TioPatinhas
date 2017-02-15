using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Grupo : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public string Nome { get; set; }

        public DateTime DataExclusao { get; set; }

        public virtual ICollection<SubGrupoProduto> SubGrupoProduto { get; set; }
    }
}
