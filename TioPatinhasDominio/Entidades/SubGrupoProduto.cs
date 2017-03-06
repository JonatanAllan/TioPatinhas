using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class SubGrupoProduto : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public int GrupoCodigo { get; set; }
        public virtual Grupo Grupo { get; set; }

        public string GrupoCodigoExterno { get; set; }

        public string Nome { get; set; }

        public DateTime DataExclusao { get; set; }


        public virtual ICollection<Produto> Produto { get; set; }
    }
}
