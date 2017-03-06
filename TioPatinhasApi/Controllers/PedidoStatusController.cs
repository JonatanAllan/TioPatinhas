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
    public class PedidoStatusController : ApiController
    {
        private readonly IPedidoStatusServicosApp _servicosApp;

        public PedidoStatusController(IPedidoStatusServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]PedidoStatusParametrosContarListar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(total != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, total);

        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]PedidoStatusParametrosBuscar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(entidade != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]PedidoStatusParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
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
            var pedidoStatus = _servicosApp.ObterPorChave(codigo);

            return Request.CreateResponse(pedidoStatus != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, pedidoStatus);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]PedidoStatusViewModel pedidoStatusVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatus = Mapper.Map<PedidoStatus>(pedidoStatusVm);

            var resultado = _servicosApp.Inserir(pedidoStatus);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);

        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]PedidoStatusViewModel pedidoStatusVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatus = Mapper.Map<PedidoStatus>(pedidoStatusVm);

            var resultado = _servicosApp.Atualizar(pedidoStatus);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]PedidoStatusViewModel pedidoStatusVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatus = Mapper.Map<PedidoStatus>(pedidoStatusVm);

            var resultado = _servicosApp.Remover(pedidoStatus);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]PedidoStatusViewModel pedidoStatusVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatus = Mapper.Map<PedidoStatus>(pedidoStatusVm);

            var resultado = _servicosApp.Mesclar(pedidoStatus);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<PedidoStatusViewModel> pedidoStatussVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatuss = Mapper.Map<IEnumerable<PedidoStatus>>(pedidoStatussVm);

            var resultado = _servicosApp.InserirEmMassa(pedidoStatuss);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<PedidoStatusViewModel> pedidoStatussVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatuss = Mapper.Map<IEnumerable<PedidoStatus>>(pedidoStatussVm);

            var resultado = _servicosApp.AtualizarEmMassa(pedidoStatuss);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<PedidoStatusViewModel> pedidoStatussVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidoStatuss = Mapper.Map<IEnumerable<PedidoStatus>>(pedidoStatussVm);

            var resultado = _servicosApp.RemoverEmMassa(pedidoStatuss);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<PedidoStatusViewModel> pedidoStatussVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var pedidoStatuss = Mapper.Map<IEnumerable<PedidoStatus>>(pedidoStatussVm);

            var resultado = _servicosApp.MesclarEmMassa(pedidoStatuss);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }
    }
}