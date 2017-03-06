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
    public class SubGrupoProdutoController : ApiController
    {
        private readonly ISubGrupoProdutoServicosApp _servicosApp;

        public SubGrupoProdutoController(ISubGrupoProdutoServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]SubGrupoProdutoParametrosContarListar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(total != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, total);

        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]SubGrupoProdutoParametrosBuscar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(entidade != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]SubGrupoProdutoParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
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
            var subGrupoProduto = _servicosApp.ObterPorChave(codigo);

            return Request.CreateResponse(subGrupoProduto != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, subGrupoProduto);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]SubGrupoProdutoViewModel subGrupoProdutoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProduto = Mapper.Map<SubGrupoProduto>(subGrupoProdutoVm);

            var resultado = _servicosApp.Inserir(subGrupoProduto);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);

        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]SubGrupoProdutoViewModel subGrupoProdutoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProduto = Mapper.Map<SubGrupoProduto>(subGrupoProdutoVm);

            var resultado = _servicosApp.Atualizar(subGrupoProduto);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]SubGrupoProdutoViewModel subGrupoProdutoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProduto = Mapper.Map<SubGrupoProduto>(subGrupoProdutoVm);

            var resultado = _servicosApp.Remover(subGrupoProduto);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]SubGrupoProdutoViewModel subGrupoProdutoVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProduto = Mapper.Map<SubGrupoProduto>(subGrupoProdutoVm);

            var resultado = _servicosApp.Mesclar(subGrupoProduto);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<SubGrupoProdutoViewModel> subGrupoProdutosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProdutos = Mapper.Map<IEnumerable<SubGrupoProduto>>(subGrupoProdutosVm);

            var resultado = _servicosApp.InserirEmMassa(subGrupoProdutos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<SubGrupoProdutoViewModel> subGrupoProdutosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProdutos = Mapper.Map<IEnumerable<SubGrupoProduto>>(subGrupoProdutosVm);

            var resultado = _servicosApp.AtualizarEmMassa(subGrupoProdutos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<SubGrupoProdutoViewModel> subGrupoProdutosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var subGrupoProdutos = Mapper.Map<IEnumerable<SubGrupoProduto>>(subGrupoProdutosVm);

            var resultado = _servicosApp.RemoverEmMassa(subGrupoProdutos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<SubGrupoProdutoViewModel> subGrupoProdutosVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var subGrupoProdutos = Mapper.Map<IEnumerable<SubGrupoProduto>>(subGrupoProdutosVm);

            var resultado = _servicosApp.MesclarEmMassa(subGrupoProdutos);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }
    }
}