using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Produto : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public int CodigoPai { get; set; }

        public string CodigoBarras { get; set; }

        public string Nome { get; set; }

        public decimal Peso { get; set; }

        public int Comprimento { get; set; }

        public int Largura { get; set; }

        public int Altura { get; set; }

        public bool Kit { get; set; }

        public DateTime DataAlteracao { get; set; }

        public DateTime DataDesativado { get; set; }

        public int ClasseCodigo { get; set; }
        public virtual Classe Classe { get; set; }

        public int FamiliaCodigo { get; set; }
        public virtual Familia Familia { get; set; }

        public int MarcaCodigo { get; set; }
        public virtual Marca Marca { get; set; }

        public int SubGrupoProdutoCodigo { get; set; }
        public virtual SubGrupoProduto SubGrupoProduto { get; set; }
        
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
