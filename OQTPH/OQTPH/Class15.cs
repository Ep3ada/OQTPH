using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class15
    {
        //try
        //    {
        //        bool apagou = false;
        //List<int> end = new List<int>();
        //bool tem = false;
        //SqlTransaction trans = null;
        //        using (SqlConnection conn = Sql.OpenConnection())
        //        {
        //            trans = conn.BeginTransaction();
        //            try
        //            {
        //                using (SqlCommand cmd = new SqlCommand("delete from filtro where id_user = @id", conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                    cmd.ExecuteNonQuery();
        //                }

        //                using (SqlCommand cmd = new SqlCommand("delete from compra where cod_pessoa = @id", conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                    cmd.ExecuteNonQuery();
        //                }

        //                using (SqlCommand cmd = new SqlCommand("select cod_endereco from evento where cod_criador = @id", conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);
        //                    using (SqlDataReader reader = cmd.ExecuteReader())
        //                    {
        //                        if (reader.HasRows)
        //                        {
        //                            while (reader.Read())
        //                            {
        //                                end.Add(reader.GetInt32(0));
        //                            }
        //                            tem = true;
        //                        }
        //                    }
        //                }

        //                using (SqlCommand cmd = new SqlCommand("delete from evento where cod_criador = @id", conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);
        //                    cmd.ExecuteNonQuery();
        //                }

        //                if (tem)
        //                {
        //                    for (int i = 0; i<end.Count; i++)
        //                    {
        //                        using (SqlCommand cmd2 = new SqlCommand("delete from endereco where cod_endereco = @cod", conn, trans))
        //                        {
        //                            cmd2.Parameters.AddWithValue("@cod", end[i]);
        //                            cmd2.ExecuteNonQuery();
        //                        }
        //                    }
        //                }

        //                using (SqlCommand cmd = new SqlCommand("delete from usuario where id_usuario = @id", conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                    cmd.ExecuteNonQuery();
        //                }

        //                trans.Commit();
        //                apagou = true;
        //            }
        //            catch (Exception)
        //            {
        //                if (trans != null)
        //                {
        //                    trans.Rollback();
        //                }
        //            }
        //            finally
        //            {
        //                if (trans != null)
        //                {
        //                    trans.Dispose();
        //                }
        //            }

        //            if (apagou)
        //            {
        //                Response.Redirect("~/Default.aspx");
        //            }
        //            else
        //            {
        //                lblMsg.Visible = true;
        //                lblMsg.Text = "Não foi possível concluir a operação!";
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        lblMsg.Visible = true;
        //        lblMsg.Text = "Erro de conexão inesperado!";
        //    }
    }
}