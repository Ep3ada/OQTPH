using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class10
    {
        //        try
        //            {
        //                using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    using (SqlCommand cmd = new SqlCommand("SELECT ev.nome_evento, ev.desc_evento, ev.nro_ingressos, ev.dt_evento," +
        //                        "ev.telefone, ev.catg, ev.valor, en.logradouro, en.nro_log, en.bairro, en.cidade," +
        //                        "en.estado, u.nome, ev.cod_criador FROM Evento ev join endereco en on(ev.cod_endereco = en.cod_endereco) join usuario u on" +
        //                        "(ev.cod_criador = u.id_usuario) where ev.id_evento = @id", conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@id", idEv);
        //                        using (SqlDataReader reader = cmd.ExecuteReader())
        //                        {
        //                            if (reader.Read())
        //                            {
        //                                img.Src = string.Format("~/Img.ashx?idimgev={0}", idEv);
        //        lblNome.Text = reader.GetString(0);

        //                                string desc = reader.GetString(1);
        //        desc = desc.Replace("\n", "<br />");
        //                                lblDesc.Text = desc;

        //                                lblIngres.Text = reader.GetInt32(2).ToString();

        //        ing = reader.GetInt32(2);
        //                                temIng = ing > 0;

        //                                lblDT.Text = reader.GetDateTime(3).Date.ToString("d");
        //                                lblHora.Text = reader.GetDateTime(3).ToString("HH:mm");
        //        lblFone.Text = reader.GetString(4);

        //                                //idEnd = reader.GetInt32(6);
        //                                lblCat.Text = reader.GetString(5);
        //                                lblVal.Text = string.Format("{0:C}", reader.GetDouble(6));

        //                                lblLocal.Text = reader.GetString(7);
        //                                lblLocal.Text += ", " + reader.GetInt32(8);
        //                                lblLocal.Text += ", " + reader.GetString(9);
        //                                lblLocal.Text += ", " + reader.GetString(10);
        //                                lblLocal.Text += " - " + reader.GetString(11);

        //                                lblCriador.Text = reader.GetString(12);

        //                                if (u != null)
        //                                {
        //                                    ehMeu = reader.GetInt32(13) == u.Id;
        //                                }
        //}
        //                            else
        //                            {
        //                                div1.Visible = false;
        //                                div2.Visible = false;
        //                                lblMsg.Text = "Este evento não existe! Vá para home.";
        //                                return;
        //                            }
        //                        }
        //                    }

        //                    if (!temIng)
        //                    {
        //                        btn.Visible = false;
        //                        lblMsg.Text = "Este evento não tem mais ingressos!";
        //                    }
        //                    else
        //                    {
        //                        if (u != null && ehMeu == true)
        //                        {
        //                            //btn.Text = "Editar";
        //                            btn.Visible = false;
        //                            btnEdit.Visible = true;
        //                        }
        //                        else if (u != null && ehMeu == false)
        //                        {
        //                            try
        //                            {
        //                                using (SqlCommand cmd = new SqlCommand("SELECT cod_compra from compra where cod_evento = @ev and cod_pessoa = @pes", conn))
        //                                {
        //                                    cmd.Parameters.AddWithValue("@ev", idEv);
        //                                    cmd.Parameters.AddWithValue("@pes", u.Id);
        //                                    using (SqlDataReader reader = cmd.ExecuteReader())
        //                                    {
        //                                        if (reader.Read())
        //                                        {
        //                                            //btnCompra.Text = "Não quero mais!";
        //                                            //btn.Text = "Devolver Ingresso!";
        //                                            btn.Visible = false;
        //                                            btnD.Visible = true;
        //                                            jaComprei = true;
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                            catch (Exception)
        //                            {
        //                                btn.Visible = true;
        //                                //btn.Text = "Adquirir Ingresso";
        //                                //jaComprei = false;
        //                            }
        //                        }
        //                    }
        //                }

        //            }
        //            catch (Exception)
        //            {
        //                div1.Visible = div2.Visible = false;
        //                lblMsg.Text = "Não foi possível concluir a operação!";
        //                return;
        //            }
    }
}