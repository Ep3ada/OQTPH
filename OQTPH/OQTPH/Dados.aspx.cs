using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OQTPH.Models;

namespace OQTPH
{
    public partial class Dados : System.Web.UI.Page
    {
        Usuario _usuario;
        public string user;

        protected void Page_Load(object sender, EventArgs e)
        {
            _usuario = Usuario.Validar();
            if (_usuario != null)
            {
                PHin.Visible = false;
                PHout.Visible = true;
            }
            else
            {
                PHin.Visible = true;
                PHout.Visible = false;
            }

            if (_usuario != null)
            {

                //if (reader.Read())
                //{
                //    lblNome.Text = reader.GetString(0);
                //    lblEmail.Text = reader.GetString(1);
                //    lblUserN.Text = reader.GetString(2);
                //    user = reader.GetString(2);

                //    btn.Visible = false;
                //    ph1.Visible = ph2.Visible = ph3.Visible = btnUp.Visible = true;
                //    Page.Title = "Atualizar Perfil - OQTPH";
                //}
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Email.ValidarEmail(txtEmail.Text.Trim());

            //if ((string.IsNullOrWhiteSpace(txtUserN.Text.Trim()) == false || txtUserN.Text.Trim().Length < 15) && (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == false))
            //{
            bool temUn = false;
            bool temEm = false;
            try
            {

                //if (reader.HasRows)
                //{
                //    lblMsg.Text = "Username já utilizado!";
                //    temUn = true;
                //    throw new Exception();
                //}



                //if (reader.HasRows)
                //{
                //    lblMsg.Text = "E-mail já utilizado!";
                //    temEm = true;
                //    throw new Exception();
                //}


            }
            catch (Exception)
            {
                if (temEm || temUn)
                {
                    return;
                }
                else
                {
                    lblMsg.Text = "Erro de conexão inesperado!";
                    return;
                }


                //}
            }


            try
            {
                _usuario = Usuario.Criar(txtNome.Text.Trim(), txtEmail.Text.Trim(), txtUserN.Text.Trim(), txtSenha.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                return;
            }

            if (_usuario == null)
            {
                lblMsg.Text = "Não foi possível criar usuário!";
                txtSenha.Text = "";
                return;
            }

            lblMsg.Text = "Conta criada com sucesso!";

            Email.Enviar(_usuario.Email, _usuario.Username);

            Response.Redirect("~/Login.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            if (_usuario != null)
            {
                Response.Redirect("~/Perfil.aspx");
            }
            else
            {
                //ao clicar no botão voltar volta para a pagina default
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void aOUT_Click(object sender, EventArgs e)
        {
            //ao apertar logout chama metdo fazerlogout q apaga cookie e token do banco de dados
            //recarrega a pagina paracompletar a operação
            //Usuario u = Usuario.Validar();
            _usuario.FazerLogout();
            Response.Redirect("~/Default.aspx");
        }

    }
}