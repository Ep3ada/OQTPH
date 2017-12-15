using System;
using System.Net.Mail;
using System.Text;
using OQTPH.Utils;
using System.Data.SqlClient;

namespace OQTPH
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("select email from usuario where email = @e", conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows & reader.Read())
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

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
                throw new Exception("Não foi possível enviar o e-mail de boas-vindas!");
            }
        }
    }
}