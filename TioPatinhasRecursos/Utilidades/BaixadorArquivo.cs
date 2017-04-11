using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TioPatinhasRecursos.Utilidades
{
    public static class BaixadorArquivo
    {
        public static HttpResponseMessage Baixar(string pasta, string arquivo, bool apagar = false)
        {
            var caminhoCompleto = pasta + arquivo;
            if (!File.Exists(caminhoCompleto))
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }

            var fileStream = new FileStream(caminhoCompleto, FileMode.Open);
            var bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, Convert.ToInt32(fileStream.Length));
            fileStream.Close();

            if (apagar)
            {
                File.Delete(caminhoCompleto);
            }

            var resultado = new HttpResponseMessage
            {
                Content = new ByteArrayContent(bytes)
            };
            resultado.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            resultado.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = arquivo
            };

            return resultado;
        }
    }
}