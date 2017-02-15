﻿using TioPatinhasRecursos.ViewModels;

namespace TioPatinhasApi.Recursos
{
    public class WebApiExceptionHandler : ExceptionHandler
    {
        public override bool ShouldHandle(ExceptionHandlerContext context) => true;

        public override void Handle(ExceptionHandlerContext context)
        {
            var exception = context.Exception;
            var message = exception.Message;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
                message = exception.Message;
            }

            var resposta = new RestResponse
            {
                StatusCode = HttpStatusCode.InternalServerError,
                StatusDescription = "Internal Server Error",
                Content = message
            };

            var retorno = context.Request.CreateResponse
            (
                resposta.StatusCode,
                new RespostaViewModel<string>(resposta)
            );

            context.Result = new ResponseMessageResult(retorno);
        }
    }
}