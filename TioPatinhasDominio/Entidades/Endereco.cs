﻿namespace TioPatinhasDominio.Entidades
{
    public class Endereco : BaseEntidade
    {
        public int Codigo { get; set; }

        public int FornecedorCodigo { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Referencia { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string Estado { get; set; }

        public string Cep { get; set; }

        public string CodigoIbge { get; set; }
    }
}
