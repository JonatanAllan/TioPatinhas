using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TioPatinhasApi.Parametros.Buscar;
using TioPatinhasApi.Parametros.ContarListar;
using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasApi.Controllers
{
    public class ClasseController : ApiController
    {
        private readonly IClasseServicosApp _servicosApp;

        public ClasseController(IClasseServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]ClasseParametrosContarListar condicoes)
        {
            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(HttpStatusCode.OK, total);
        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]ClasseParametrosBuscar condicoes)
        {
            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(HttpStatusCode.OK, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]ClasseParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
        {
            var lista = _servicosApp.Listar(condicoes.Expressao(), ordenarPor ?? "Codigo", deslocamento ?? 0, limite ?? 100);

            return Request.CreateResponse(HttpStatusCode.OK, lista);
        }

        [HttpGet]
        public HttpResponseMessage ObterPorChave(object id)
        {
            var Classe = _servicosApp.ObterPorChave(id);

            return Request.CreateResponse(HttpStatusCode.OK, Classe);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]Classe Classe)
        {
            _servicosApp.Inserir(Classe);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]Classe Classe)
        {
            _servicosApp.Atualizar(Classe);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]Classe Classe)
        {
            _servicosApp.Remover(Classe);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]Classe Classe)
        {
            _servicosApp.Mesclar(Classe);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<Classe> Classes)
        {
            _servicosApp.InserirEmMassa(Classes);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<Classe> Classes)
        {
            _servicosApp.AtualizarEmMassa(Classes);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<Classe> Classes)
        {
            _servicosApp.RemoverEmMassa(Classes);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<Classe> Classes)
        {
            _servicosApp.MesclarEmMassa(Classes);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}