using System.Collections.Generic;
using RestSharp;
using TioPatinhasRecursos.ViewModels;

namespace TioPatinhasRecursos.Interfaces.ServicosExternos
{
    public interface IExemploServicosExternos : IBaseServicosExternos
    {
        RespostaViewModel<IEnumerable<ExemploViewModel>> ListarExemplo(List<Parameter> parametros);
    }
}