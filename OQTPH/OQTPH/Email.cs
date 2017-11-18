using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OQTPH.Utils;
using OQTPH.Models;
using System.Text;
using System.Net.Mail;
using System.Net.Mail;
using System.Web.Configuration;
namespace OQTPH
{
    public class Email
    {
       public void Enviar()
        {
           
        }

        //        try
        //            {
        //                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
        //                {

        //                    // EnableSsl ativa a comunicação segura com o servidor
        //                    client.EnableSsl = true;

        //                    // Especifica a credencial utilizada para envio da mensagem
        //                    client.UseDefaultCredentials = false;
        //                    client.Credentials = new System.Net.NetworkCredential("ep3ada@gmail.com", "bandtec20172");

        //                    // Especifia o remetente e o destinatário da mensagem
        //                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(
        //                        new System.Net.Mail.MailAddress("ep3ada@gmail.com", "Grupo Ask4Projekt", Encoding.UTF8),
        //                        new System.Net.Mail.MailAddress(txtEmail.Text.Trim()));

        //        // Preenche o corpo e o assunto da mensagem
        //        message.BodyEncoding = Encoding.UTF8;
        //                    message.Body = "Obrigado por se cadastrar no nosso site!\n Nome de Usuário: " + txtUserN.Text.Trim() + "\n Email: " + txtEmail.Text.Trim() + "\n\n\n Grupo Ask4Projekt.";
        //                    message.SubjectEncoding = Encoding.UTF8;
        //                    message.Subject = "Cadastro feito com sucesso!";

        //                    // Anexos devem ser adicionados através do método
        //                    // message.Attachments.Add()

        //                    // Envia a mensagem
        //                    client.Send(message);
        //                }
        //}
        //            catch (Exception)
        //            {
        //                // Exceções devem ser tratadas aqui!
        //            }

    }
}