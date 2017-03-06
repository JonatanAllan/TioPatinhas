using System;

namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    public class ProdutoViewModel
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

        public int FamiliaCodigo { get; set; }

        public int MarcaCodigo { get; set; }

        public int SubGrupoProdutoCodigo { get; set; }
    }
}
