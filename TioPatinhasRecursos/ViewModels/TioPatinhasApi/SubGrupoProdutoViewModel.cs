using System;

namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    public class SubGrupoProdutoViewModel
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public int GrupoCod { get; set; }

        public string GrupoCodExterno { get; set; }

        public string Nome { get; set; }

        public DateTime DataExclusao { get; set; }
    }
}
