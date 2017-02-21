using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TioPatinhasRecursos.Atributos;

namespace TioPatinhasRecursos.ViewModels.TioPatinhasApi
{
    [AtLeastOneProperty("Codigo", "CodigoExterno")]
    [AtLeastOneProperty("Nome", "CodigoExterno")]
    public class ClasseViewModel
    {
        public int Codigo { get; set; }

        public string CodigoExterno { get; set; }

        public string Nome { get; set; }
    }
}
