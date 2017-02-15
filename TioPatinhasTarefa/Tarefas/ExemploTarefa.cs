using System.Collections.Generic;
using RestSharp;
using TioPatinhasRecursos.Interfaces.ServicosExternos;
using TioPatinhasTarefa.Interfaces.Tarefas;

namespace TioPatinhasTarefa.Tarefas
{
    public class ExemploTarefa : IExemploTarefa
    {
        private readonly IExemploServicosExternos _exemplosSvc;

        public ExemploTarefa(IExemploServicosExternos exemploSvc)
        {
            _exemplosSvc = exemploSvc;
        }

        public void Executar()
        {
            var parametros = new List<Parameter>();
            var exemplos = _exemplosSvc.ListarExemplo(parametros);
        }
    }
}