using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class8
    {
        //    bool mudouEmail = false;
        //    bool atualizou = false;
        //    string msg = "";
        //    SqlTransaction trans = null;

        //        try
        //        {

        //            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()) &&
        //                string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) &&
        //                string.IsNullOrWhiteSpace(txtSenha.Text.Trim()) &&
        //                string.IsNullOrWhiteSpace(txtUserN.Text.Trim()))
        //            {
        //                throw new Exception();
        //}

        //            using (SqlConnection conn = Sql.OpenConnection())
        //            {
        //                trans = conn.BeginTransaction();

        //                try
        //                {
        //                    if (!string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
        //                    {
        //                        if (txtNome.Text.Trim().Length< 30)
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("Update usuario set nome = @nome where id_usuario = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                                cmd.ExecuteNonQuery();
        //                            }

        //                        }
        //                        else
        //                        {
        //                            msg = "Campo Nome deve ter até 30 caracteres!";
        //                            throw new Exception();
        //                        }
        //                    }


        //                    if (!string.IsNullOrWhiteSpace(txtUserN.Text.Trim()))
        //                    {
        //                        if (txtUserN.Text.Trim().Length< 15)
        //                        {
        //                            bool temUn = false;
        //                            using (SqlCommand cmd = new SqlCommand("select username from usuario where username = @u", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@u", txtUserN.Text.Trim());
        //                                using (SqlDataReader reader = cmd.ExecuteReader())
        //                                {
        //                                    if (reader.HasRows)
        //                                    {
        //                                        msg = "Username já utilizado!";
        //                                        temUn = true;
        //                                        throw new Exception();
        //                                    }
        //                                }
        //                            }

        //                            if (temUn == false)
        //                            {
        //                                using (SqlCommand cmd = new SqlCommand("Update usuario set username = @usern where id_usuario = @id", conn, trans))
        //                                {
        //                                    cmd.Parameters.AddWithValue("@usern", txtUserN.Text.Trim());
        //                                    cmd.Parameters.AddWithValue("@id", _usuario.Id);
        //                                    cmd.ExecuteNonQuery();
        //                                    user = txtUserN.Text.Trim();
        //                                }
        //                            }

        //                        }
        //                        else
        //                        {
        //                            msg = "Campo Username deve ter até 15 caracteres!";
        //                            throw new Exception();
        //                        }

        //                    }

        //                    if (!string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
        //                    {
        //                        bool temEm = false;
        //                        using (SqlCommand cmd = new SqlCommand("select email from usuario where email = @e", conn, trans))
        //                        {
        //                            cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                if (reader.HasRows)
        //                                {
        //                                    msg = "E-mail já utilizado!";
        //                                    temEm = true;
        //                                    throw new Exception();
        //                                }
        //                            }
        //                        }

        //                        if (temEm == false)
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("Update usuario set email = @email where id_usuario = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _usuario.Id);
        //                                cmd.ExecuteNonQuery();

        //                                mudouEmail = true;
        //                            }
        //                        }
        //                    }

        //                    if (!string.IsNullOrWhiteSpace(txtSenha.Text.Trim()))
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("Update usuario set senha = @senha where id_usuario = @id", conn, trans))
        //                        {
        //                            cmd.Parameters.AddWithValue("@senha", PasswordHash.CreateHash(txtSenha.Text.Trim()));
        //                            cmd.Parameters.AddWithValue("@id", _usuario.Id);
        //                            cmd.ExecuteNonQuery();
        //                        }
        //                    }

        //                    trans.Commit();
        //                    atualizou = true;
        //                }
        //                catch (Exception)
        //                {
        //                    if (trans != null)
        //                        trans.Rollback();
        //                }
        //                finally
        //                {
        //                    if (trans != null)
        //                        trans.Dispose();
        //                }

    }
}