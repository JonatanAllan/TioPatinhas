using System.Collections.Generic;
using RestSharp;
using TioPatinhasRecursos.Interfaces.ServicosExternos;
using TioPatinhasRecursos.ViewModels;

namespace TioPatinhasRecursos.ServicosExternos
{
    public class ExemploServicosExternos : BaseServicosExternos, IExemploServicosExternos
    {
        public ExemploServicosExternos()
            : base("http://localhost:3396", Servicos.TioPatinhas)
        {
            
        }

        public RespostaViewModel<IEnumerable<ExemploViewModel>> ListarExemplo(List<Parameter> parametros)
        {
            const string recurso = "/Exemplo/Listar";
            var resposta = Executar(recurso, Method.GET, parametros);

            return new RespostaViewModel<IEnumerable<ExemploViewModel>>(resposta);
        }
    }
}