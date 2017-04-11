using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;
using TioPatinhasRecursos.Interfaces.ServicosExternos;
using TioPatinhasRecursos.Recursos;
using TioPatinhasRecursos.ViewModels;

namespace TioPatinhasRecursos.ServicosExternos
{
    public abstract class BaseServicosExternos : IBaseServicosExternos
    {
        private readonly RestClient _cliente;
        private readonly Servicos _servico;

        protected BaseServicosExternos(string baseUrl, Servicos servico)
        {
            _cliente = new RestClient(baseUrl);
            _servico = servico;
        }

        public Parameter CriarParametro(string nome, object valor, ParameterType tipo = ParameterType.QueryString) => new Parameter
        {
            Name = nome,
            Value = valor,
            Type = tipo
        };

        public List<Parameter> CriarParametrosPaginacao(int deslocamento, int limite, string ordenarPor, string condicoes = null)
        {
            var parametros = new List<Parameter>
            {
                CriarParametro("ordenarPor", ordenarPor),
                CriarParametro("deslocamento", deslocamento),
                CriarParametro("limite", limite)
            };

            if (!string.IsNullOrEmpty(condicoes))
            {
                parametros.Add(CriarParametro("condicoes", condicoes));
            }

            return parametros;
        }

        public IRestResponse Executar(string recurso, Method metodo, List<Parameter> cabecalhos = null, List<Parameter> parametros = null, object corpo = null)
        {
            var requisicao = new RestRequest(recurso, metodo)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new RestSharpJsonSerializer()
            };


            if (cabecalhos != null)
            {
                foreach (var cabecalho in cabecalhos)
                {
                    requisicao.AddHeader(cabecalho.Name, cabecalho.Value.ToString());
                }
            }

            if (parametros != null)
            {
                foreach (var parametro in parametros)
                {
                    requisicao.AddParameter(parametro.Name, parametro.Value, parametro.Type);
                }
            }

            if (corpo != null)
            {
                requisicao.AddParameter("application/json", corpo, ParameterType.RequestBody);
            }


            return _cliente.Execute(requisicao);
        }
    }

    public enum Servicos
    {
        TioPatinhas = 1
    }
}