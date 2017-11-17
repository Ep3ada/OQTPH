using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class13
    {
        //        using (SqlConnection conn = Sql.OpenConnection())
        //            {
        //                bool temDados = false;
        //                using (SqlCommand cmd = new SqlCommand("SELECT nome, email, username FROM Usuario where id_usuario = @id", conn))
        //                {
        //                    //substitui os parametros com arroba na query
        //                    cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                    using (SqlDataReader reader = cmd.ExecuteReader())
        //                    {
        //                        if (reader.Read() && reader.HasRows)
        //                        {
        //                            lblNome.Text = reader.GetString(0);
        //                            lblEmail.Text = reader.GetString(1);
        //                            lblUserN.Text = reader.GetString(2);
        //                            temDados = true;
        //                        }
        //                    }
        //                }

        //                if (temDados)
        //                {
        //                    using (SqlCommand cmd = new SqlCommand("SELECT id_evento, nome_evento, dt_evento FROM Evento where cod_criador = @id", conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                        using (SqlDataReader reader = cmd.ExecuteReader())
        //                        {
        //                            if (reader.HasRows)
        //                            {
        //                                dropEC.Items.Clear();
        //                                while (reader.Read() == true)
        //                                {

        //                                    ListItem item = new ListItem(reader.GetString(1), reader.GetInt32(0).ToString());
        //dropEC.Items.Add(item);

        //                                    EventoModelo evento = new EventoModelo { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2) };

        //_eventosCriados.Add(evento);

        //                                }
        //                                lblEC.Visible = false;
        //                            }
        //                            else
        //                            {
        //                                //se não retornar valor escreve isso na div
        //                                //EvCriou.Controls.Add(new Label() { Text = "Não há nenhum." });
        //                                lblEC.Visible = true;
        //                                EvCriou.Visible = false;
        //                            }

        //                        }
        //                    }

        //                    using (SqlCommand cmd = new SqlCommand("SELECT e.id_evento, e.nome_evento, e.dt_evento, c.dt_compra FROM EVENTO AS e join COMPRA AS c on (e.id_evento = c.cod_evento) where c.cod_pessoa = @id", conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                        using (SqlDataReader reader = cmd.ExecuteReader())
        //                        {
        //                            if (reader.HasRows)
        //                            {
        //                                while (reader.Read() == true)
        //                                {

        //                                    EventoModelo evento = new EventoModelo { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2), DataCompra = reader.GetDateTime(3) };

        //_eventosAdquiridos.Add(evento);
        //                                }
        //                                lblIA.Visible = false;
        //                            }
        //                            else
        //                            {
        //                                //se não retornar valor escreve isso na div
        //                                //EvComprou.Controls.Add(new Label() { Text = "Não há nenhum." });
        //                                lblIA.Visible = true;
        //                            }
        //                        }
        //                    }

        //                    string select = "";
        //bool tem;
        //                    try
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("SELECT filt from filtro where id_user = @id", conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@id", _usuario.Id);

        //                            select = cmd.ExecuteScalar().ToString();
        //tem = true;
        //                        }
        //                    }
        //                    catch (Exception)
        //                    {
        //                        //EvCat.Controls.Add(new Label() { Text = "Não há nenhum." });
        //                        divEP.Visible = false;
        //                        lblEP.Visible = true;
        //                        tem = false;
        //                    }


        //                    if (tem)
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand("SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat and dt_evento >= @now order by dt_criou desc", conn))
        //                        {
        //                            //antes de mudar pro retorno do scalar tava assim
        //                            //using (SqlCommand cmd = new SqlCommand("SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat and dt_evento >= @now order by dt_criou desc", conn))
        //                            //{
        //                            //antiga query   SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat order by dt_evento desc
        //                            cmd.Parameters.AddWithValue("@cat", select);
        //                            cmd.Parameters.AddWithValue("@now", DateTime.Now);

        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                //EvCat.Controls.Clear();
        //                                if (reader.HasRows)
        //                                {
        //                                    _eventosAlerta.Clear();
        //                                    while (reader.Read())
        //                                    {


        //                                        EventoModelo evento = new EventoModelo() { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2) };
        //_eventosAlerta.Add(evento);
        //                                    }

        //                                    lblEP.Visible = false;
        //                                    divEP.Visible = true;

        //                                }
        //                                else
        //                                {
        //                                    //EvCat.Controls.Add(new Label() { Text = "Não há nenhum." });
        //                                    divEP.Visible = false;
        //                                    lblEP.Visible = true;
        //                                }
        //                            }
        //                        }
        //                    }


        //                }
        //            }
        //            //}
        //            //catch (Exception)
        //            //{
        //            //faz alguma coisa, escreve na tela ou algo  do tipo
        //            //ouredireciona pra login por alguma razão
        //            //}
    }
}