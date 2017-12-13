using System;
using System.Net.Mail;
using System.Text;

namespace OQTPH
{
    public static class Email
    {
        public static void Enviar(string emailDestino, string usernameDestino)
        {
            try
            {
                using (SmtpClient client = new SmtpClient())
                {
                    using (MailMessage message = new MailMessage())
                    {
                        message.To.Add(new MailAddress(emailDestino));
                        message.SubjectEncoding = Encoding.UTF8;
                        message.Subject = "Cadastro feito com sucesso!";
                        message.BodyEncoding = Encoding.UTF8;
                        message.Body = "Obrigado por se cadastrar no nosso site!\n Nome de Usuário: " + usernameDestino + "\n Email: " + emailDestino + "\n\n\n Grupo Ask4Projekt.";
                        client.Send(message);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível enviar o e-mail de confirmação de criação de conta!");
            }
        }
    }
}