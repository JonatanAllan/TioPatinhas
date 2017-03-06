using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TioPatinhasApi.Parametros.Buscar;
using TioPatinhasApi.Parametros.ContarListar;
using TioPatinhasAplicacao.Interfaces.ServicosApp;
using AutoMapper;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.ViewModels.TioPatinhasApi;

namespace TioPatinhasApi.Controllers
{
    public class GrupoController : ApiController
    {
        private readonly IGrupoServicosApp _servicosApp;

        public GrupoController(IGrupoServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]GrupoParametrosContarListar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(total != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, total);

        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]GrupoParametrosBuscar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(entidade != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]GrupoParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var lista = _servicosApp.Listar(condicoes.Expressao(), ordenarPor ?? "Codigo", deslocamento ?? 0, limite ?? 100);

            return Request.CreateResponse(lista.Any()? HttpStatusCode.OK : HttpStatusCode.NoContent, lista);

        }

        [HttpGet]
        public HttpResponseMessage ObterPorChave(int codigo)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var grupos = _servicosApp.ObterPorChave(codigo);

            return Request.CreateResponse(grupos != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, grupos);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]GrupoViewModel gruposVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var grupos = Mapper.Map<Grupo>(gruposVm);

            var resultado = _servicosApp.Inserir(grupos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);

        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]GrupoViewModel gruposVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var grupos = Mapper.Map<Grupo>(gruposVm);

            var resultado = _servicosApp.Atualizar(grupos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]GrupoViewModel gruposVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var grupos = Mapper.Map<Grupo>(gruposVm);

            var resultado = _servicosApp.Remover(grupos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]GrupoViewModel gruposVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var grupos = Mapper.Map<Grupo>(gruposVm);

            var resultado = _servicosApp.Mesclar(grupos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<GrupoViewModel> grupossVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var gruposs = Mapper.Map<IEnumerable<Grupo>>(grupossVm);

            var resultado = _servicosApp.InserirEmMassa(gruposs);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<GrupoViewModel> grupossVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var gruposs = Mapper.Map<IEnumerable<Grupo>>(grupossVm);

            var resultado = _servicosApp.AtualizarEmMassa(gruposs);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<GrupoViewModel> grupossVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var gruposs = Mapper.Map<IEnumerable<Grupo>>(grupossVm);

            var resultado = _servicosApp.RemoverEmMassa(gruposs);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<GrupoViewModel> grupossVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var gruposs = Mapper.Map<IEnumerable<Grupo>>(grupossVm);

            var resultado = _servicosApp.MesclarEmMassa(gruposs);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }
    }
}