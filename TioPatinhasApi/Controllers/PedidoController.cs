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
    public class PedidoController : ApiController
    {
        private readonly IPedidoServicosApp _servicosApp;

        public PedidoController(IPedidoServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]PedidoParametrosContarListar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(total != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, total);

        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]PedidoParametrosBuscar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(entidade != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]PedidoParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
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
            var pedido = _servicosApp.ObterPorChave(codigo);

            return Request.CreateResponse(pedido != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, pedido);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]PedidoViewModel pedidoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedido = Mapper.Map<Pedido>(pedidoVm);

            var resultado = _servicosApp.Inserir(pedido);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);

        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]PedidoViewModel pedidoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedido = Mapper.Map<Pedido>(pedidoVm);

            var resultado = _servicosApp.Atualizar(pedido);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]PedidoViewModel pedidoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedido = Mapper.Map<Pedido>(pedidoVm);

            var resultado = _servicosApp.Remover(pedido);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]PedidoViewModel pedidoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedido = Mapper.Map<Pedido>(pedidoVm);

            var resultado = _servicosApp.Mesclar(pedido);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<PedidoViewModel> pedidosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidos = Mapper.Map<IEnumerable<Pedido>>(pedidosVm);

            var resultado = _servicosApp.InserirEmMassa(pedidos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<PedidoViewModel> pedidosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidos = Mapper.Map<IEnumerable<Pedido>>(pedidosVm);

            var resultado = _servicosApp.AtualizarEmMassa(pedidos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<PedidoViewModel> pedidosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var pedidos = Mapper.Map<IEnumerable<Pedido>>(pedidosVm);

            var resultado = _servicosApp.RemoverEmMassa(pedidos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<PedidoViewModel> pedidosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var pedidos = Mapper.Map<IEnumerable<Pedido>>(pedidosVm);

            var resultado = _servicosApp.MesclarEmMassa(pedidos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }
    }
}