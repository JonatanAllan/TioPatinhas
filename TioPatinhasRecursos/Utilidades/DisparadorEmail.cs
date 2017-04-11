using System.Net;
using System.Net.Mail;

namespace TioPatinhasRecursos.Utilidades
{
    public static class DisparadorEmail
    {
        public static void Enviar(string assunto, string corpoEmail, string destinatarios, bool contemHtml = false)
        {
            var mensagem = new MailMessage
            {
                From = new MailAddress("exemplo@exemplo.com"),
                To = { new MailAddress(destinatarios) },
                Subject = assunto,
                Body = corpoEmail
            };

            var client = new SmtpClient
            {
                Host = "smtp.exemplo.com",
                Port = 587,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("exemplo@exemplo.com", "password")
            };

            mensagem.IsBodyHtml = contemHtml;
            client.Send(mensagem);
        }
    }
}