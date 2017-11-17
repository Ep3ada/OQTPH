using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class14
    {
        //        using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    try
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("update filtro set filt = @filt output inserted.filt where id_user = @id ", conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@filt", cat);
        //                            cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                            select = cmd.ExecuteScalar().ToString();
        //    //tem = Convert.ToBoolean((int)cmd.ExecuteNonQuery());

        //}
        //                    }
        //                    catch (Exception)
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("insert into filtro output inserted.filt values(@filt, @id)", conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@filt", cat);
        //                            cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                            select = (string) cmd.ExecuteScalar();

        //                        }


        //                    }

        //                    using (SqlCommand cmd = new SqlCommand("SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat and dt_evento >= @now order by dt_criou desc", conn))
        //                    {
        //                        //antes de mudar pro retorno do scalar tava assim
        //                        //using (SqlCommand cmd = new SqlCommand("SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat and dt_evento >= @now order by dt_criou desc", conn))
        //                        //{
        //                        //antiga query   SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat order by dt_evento desc
        //                        cmd.Parameters.AddWithValue("@cat", select);
        //                        cmd.Parameters.AddWithValue("@now", DateTime.Now);

        //                        using (SqlDataReader reader = cmd.ExecuteReader())
        //                        {
        //                            //EvCat.Controls.Clear();
        //                            if (reader.HasRows)
        //                            {
        //                                _eventosAlerta.Clear();
        //                                while (reader.Read())
        //                                {
        //                                    EventoModelo evento = new EventoModelo() { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2) };
        //_eventosAlerta.Add(evento);

        //                                }

        //                                lblEP.Visible = false;
        //                                divEP.Visible = true;

        //                            }
        //                            else
        //                            {
        //                                //EvCat.Controls.Add(new Label() { Text = "Não há nenhum." });
        //                                divEP.Visible = false;
        //                                lblEP.Visible = true;
        //                            }
        //                        }
        //                    }

        //                }
        //                // }
        //                //catch (Exception)
        //                //{
        //                //}
    }
}