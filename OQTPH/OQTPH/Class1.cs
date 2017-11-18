using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public class Class1
    {
        public Evento CarregarEventos(int idUsuario, int idEvento)
        {
            //using (SqlConnection conn = Sql.OpenConnection())
            //{
            //    using (SqlCommand cmd = new SqlCommand("select ev.nome_evento, ev.dt_evento, ev.desc_evento, ev.nro_ingressos, " +
            //        "ev.telefone, ev.valor, ev.catg, en.logradouro, en.nro_log, en.bairro, en.cidade, en.estado, en.cod_endereco from evento ev join " +
            //        "endereco en on(ev.cod_endereco = en.cod_endereco) where cod_criador = @id and id_evento = @ev", conn))
            //    {
            //        cmd.Parameters.AddWithValue("@id", _usuario.Id);
            //        cmd.Parameters.AddWithValue("@ev", _idEvento);

            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                //DataDB = reader.GetDateTime(1);
            //                _idEndereco = reader.GetInt32(12);

            //                _ehMeu = true;

            //                placeholderEvento.Visible = true;
            //                btnCriar.Visible = false;
            //                btnAtualiza.Visible = true;

            //                if (!IsPostBack)
            //                {
            //                    img.Src = string.Format("~/Img.ashx?idimgev={0}", _idEvento);
            //                    txtfone.Text = reader.GetString(4);
            //                    txtNomeEv.Text = reader.GetString(0);
            //                    txtDescEv.Text = reader.GetString(2);
            //                    txtIngEv.Text = reader.GetInt32(3).ToString();
            //                    txtDT.Text = reader.GetDateTime(1).Date.ToString("d");
            //                    txtHR.Text = reader.GetDateTime(1).ToString("HH:mm");
            //                    txtEnd.Text = reader.GetString(7);
            //                    txtNroEnd.Text = reader.GetInt32(8).ToString();
            //                    txtBairroEnd.Text = reader.GetString(9);
            //                    txtCid.Text = reader.GetString(10);
            //                    txtEst.Text = reader.GetString(11);
            //                    string valor = reader.GetDouble(5).ToString();
            //                    txtValEv.Text = valor.Replace(".", ",");

            //                    for (int i = 0; i < dropCatg.Items.Count; i++)
            //                    {
            //                        if (reader.GetString(6) == null)
            //                        {
            //                            i = dropCatg.Items.Count - 1;
            //                        }
            //                        if (dropCatg.Items[i].Value == reader.GetString(6))
            //                        {
            //                            dropCatg.SelectedIndex = i;
            //                            i = dropCatg.Items.Count - 1;
            //                        }
            //                    }
            //                }

            //                Page.Title = "Atualizar Evento - OQTPH";
            //            }
            //        }
            //    }
            //}

            Evento evento;
            Endereco endereco;

            // aqui chama metodo pra pegar o endereco


            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("select ev.nome_evento, ev.dt_evento, ev.desc_evento, ev.nro_ingressos, " +
                    "ev.telefone, ev.valor, ev.catg, en.logradouro, en.nro_log, en.bairro, en.cidade, en.estado, en.cod_endereco from evento ev join " +
                    "endereco en on(ev.cod_endereco = en.cod_endereco) where cod_criador = @id and id_evento = @ev", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.Parameters.AddWithValue("@ev", idEvento);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //DataDB = reader.GetDateTime(1);
                            // _idEndereco = reader.GetInt32(12);



                            /*img.Src = string.Format("~/Img.ashx?idimgev={0}", _idEvento);
                            txtfone.Text = reader.GetString(4);
                            txtNomeEv.Text = reader.GetString(0);
                            txtDescEv.Text = reader.GetString(2);
                            txtIngEv.Text = reader.GetInt32(3).ToString();
                            txtDT.Text = reader.GetDateTime(1).Date.ToString("d");
                            txtHR.Text = reader.GetDateTime(1).ToString("HH:mm");
                            txtEnd.Text = reader.GetString(7);
                            txtNroEnd.Text = reader.GetInt32(8).ToString();
                            txtBairroEnd.Text = reader.GetString(9);
                            txtCid.Text = reader.GetString(10);
                            txtEst.Text = reader.GetString(11);
                            string valor = reader.GetDouble(5).ToString();
                            txtValEv.Text = valor.Replace(".", ",");*/

                            //for (int i = 0; i < dropCatg.Items.Count; i++)
                            //{
                            //    if (reader.GetString(6) == null)
                            //    {
                            //        i = dropCatg.Items.Count - 1;
                            //    }
                            //    if (dropCatg.Items[i].Value == reader.GetString(6))
                            //    {
                            //        dropCatg.SelectedIndex = i;
                            //        i = dropCatg.Items.Count - 1;
                            //    }
                            //}
                        }
                    }
                }
            }


            return null;
        }
    }
}