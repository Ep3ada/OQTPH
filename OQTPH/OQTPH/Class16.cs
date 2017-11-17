using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class16
    {
        //SqlTransaction trans = null;
        //        try
        //        {
        //            using (SqlConnection conn = Sql.OpenConnection())
        //            {
        //                trans = conn.BeginTransaction();
        //                try
        //                {
        //                    using (SqlCommand cmd = new SqlCommand("delete from compra where cod_evento = @id", conn, trans))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", cod);
        //                        cmd.ExecuteNonQuery();
        //                    }


        //                    using (SqlCommand cmd = new SqlCommand("delete from evento where id_evento = @id", conn, trans))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", cod);
        //                        cmd.ExecuteNonQuery();
        //                    }

        //                    using (SqlCommand cmd = new SqlCommand("select cod_endereco from evento where id_evento = @id", conn, trans))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", cod);
        //                        using (SqlDataReader reader = cmd.ExecuteReader())
        //                        {
        //                            if (reader.Read())
        //                            {
        //                                end = reader.GetInt32(0);
        //                            }
        //                        }
        //                    }

        //                    if (end > 0)
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("delete from endereco where cod_endereco = @end", conn, trans))
        //                        {
        //                            cmd.Parameters.AddWithValue("@end", end);
        //                            cmd.ExecuteNonQuery();
        //                        }
        //                    }


        //                    trans.Commit();
        //                    apagou = true;
        //                }
        //                catch (Exception)
        //                {
        //                    if (trans != null)
        //                    {
        //                        trans.Rollback();
        //                    }
        //                }
        //                finally
        //                {
        //                    if (trans != null)
        //                    {
        //                        trans.Dispose();
        //                    }

        //                }

        //                if (apagou)
        //                {
        //                    Response.Redirect("~/Perfil.aspx");
        //                }

        //            }
        //        }
        //        catch (Exception)
        //        {

        //        }
    }
}