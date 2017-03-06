using System;

namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    public class FornecedorViewModel
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
    }
}
