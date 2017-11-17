using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class7
    {
        //        if ((string.IsNullOrWhiteSpace(txtUserN.Text.Trim()) == false || txtUserN.Text.Trim().Length< 15) && (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == false))
        //            {
        //                bool temUn = false;
        //        bool temEm = false;
        //                try
        //                {
        //                    using (SqlConnection conn = Sql.OpenConnection())
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("select username from usuario where username = @u", conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@u", txtUserN.Text.Trim());
        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                if (reader.HasRows)
        //                                {
        //                                    lblMsg.Text = "Username já utilizado!";
        //                                    temUn = true;
        //                                    throw new Exception();
        //    }
        //}
        //                        }

        //                        using (SqlCommand cmd = new SqlCommand("select email from usuario where email = @e", conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                if (reader.HasRows)
        //                                {
        //                                    lblMsg.Text = "E-mail já utilizado!";
        //                                    temEm = true;
        //                                    throw new Exception();
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //                catch (Exception)
        //                {
        //                    if (temEm || temUn)
        //                    {
        //                        return;
        //                    }
        //                    else
        //                    {
        //                        lblMsg.Text = "Erro de conexão inesperado!";
        //                        return;
        //                    }

        //                }
        //            }


        //            try
        //            {
        //                _usuario = UsuarioModelo.Criar(txtNome.Text.Trim(), txtEmail.Text.Trim(), txtUserN.Text.Trim(), txtSenha.Text.Trim());
        //            }
        //            catch (Exception ex)
        //            {
        //                lblMsg.Text = ex.Message;
        //                return;
        //            }

        //            if (_usuario == null)
        //            {
        //                lblMsg.Text = "Não foi possível criar usuário!";
        //                txtSenha.Text = "";
        //                return;
        //            }

        //            lblMsg.Text = "Conta criada com sucesso!";

    }
}