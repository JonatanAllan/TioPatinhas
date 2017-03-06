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
    public class ProdutoFornecedorController : ApiController
    {
        private readonly IProdutoFornecedorServicosApp _servicosApp;

        public ProdutoFornecedorController(IProdutoFornecedorServicosApp servicosApp)
        {
            _servicosApp = servicosApp;
        }

        [HttpGet]
        public HttpResponseMessage Contar([FromUri]ProdutoFornecedorParametrosContarListar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var total = _servicosApp.Contar(condicoes.Expressao());

            return Request.CreateResponse(total != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, total);

        }

        [HttpGet]
        public HttpResponseMessage Buscar([FromUri]ProdutoFornecedorParametrosBuscar condicoes)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var entidade = _servicosApp.Buscar(condicoes.Expressao());

            return Request.CreateResponse(entidade != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, entidade);
        }

        [HttpGet]
        public HttpResponseMessage Listar([FromUri]ProdutoFornecedorParametrosContarListar condicoes, [FromUri]string ordenarPor = null, [FromUri]int? deslocamento = null, [FromUri]int? limite = null)
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
            var produtosFornecedor = _servicosApp.ObterPorChave(codigo);

            return Request.CreateResponse(produtosFornecedor != null ? HttpStatusCode.OK : HttpStatusCode.NoContent, produtosFornecedor);
        }

        [HttpPost]
        public HttpResponseMessage Inserir([FromBody]ProdutoFornecedorViewModel produtosFornecedorVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedor = Mapper.Map<ProdutoFornecedor>(produtosFornecedorVm);

            var resultado = _servicosApp.Inserir(produtosFornecedor);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);

        }

        [HttpPost]
        public HttpResponseMessage Atualizar([FromBody]ProdutoFornecedorViewModel produtosFornecedorVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedor = Mapper.Map<ProdutoFornecedor>(produtosFornecedorVm);

            var resultado = _servicosApp.Atualizar(produtosFornecedor);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Remover([FromBody]ProdutoFornecedorViewModel produtosFornecedorVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedor = Mapper.Map<ProdutoFornecedor>(produtosFornecedorVm);

            var resultado = _servicosApp.Remover(produtosFornecedor);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage Mesclar([FromBody]ProdutoFornecedorViewModel produtosFornecedorVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedor = Mapper.Map<ProdutoFornecedor>(produtosFornecedorVm);

            var resultado = _servicosApp.Mesclar(produtosFornecedor);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage InserirEmMassa([FromBody]IEnumerable<ProdutoFornecedorViewModel> produtosFornecedorsVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedors = Mapper.Map<IEnumerable<ProdutoFornecedor>>(produtosFornecedorsVm);

            var resultado = _servicosApp.InserirEmMassa(produtosFornecedors);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage AtualizarEmMassa([FromBody]IEnumerable<ProdutoFornecedorViewModel> produtosFornecedorsVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedors = Mapper.Map<IEnumerable<ProdutoFornecedor>>(produtosFornecedorsVm);

            var resultado = _servicosApp.AtualizarEmMassa(produtosFornecedors);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage RemoverEmMassa([FromBody]IEnumerable<ProdutoFornecedorViewModel> produtosFornecedorsVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            var produtosFornecedors = Mapper.Map<IEnumerable<ProdutoFornecedor>>(produtosFornecedorsVm);

            var resultado = _servicosApp.RemoverEmMassa(produtosFornecedors);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }

        [HttpPost]
        public HttpResponseMessage MesclarEmMassa([FromBody]IEnumerable<ProdutoFornecedorViewModel> produtosFornecedorsVm)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var produtosFornecedors = Mapper.Map<IEnumerable<ProdutoFornecedor>>(produtosFornecedorsVm);

            var resultado = _servicosApp.MesclarEmMassa(produtosFornecedors);

            return Request.CreateResponse(resultado ? HttpStatusCode.OK : HttpStatusCode.NoContent);
        }
    }
}