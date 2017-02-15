using System;
using System.Collections.Generic;

namespace TioPatinhasDominio.Entidades
{
    public class Fornecedor : BaseEntidade
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public string Email { get; set; }

        public string Cnpj { get; set; }

        public string InscricaoEstadual { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string RazaoSocial { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public DateTime DataAlteracao { get; set; }

        public DateTime DataDesativado { get; set; }

        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedor { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
