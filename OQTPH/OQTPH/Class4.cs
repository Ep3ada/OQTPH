using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class4
    {
        //        SqlTransaction trans = null;
        //            try
        //            {
        //                using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    trans = conn.BeginTransaction();
        //                    try
        //                    {
        //                        if (string.IsNullOrWhiteSpace(txtNomeEv.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Nome!";
        //                            throw new Exception();
        //    }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update evento set nome_evento = @p where id_evento = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtNomeEv.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtDescEv.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Descrição!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update evento set desc_evento = @p where id_evento = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtDescEv.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtValEv.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Valor!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            float v;
        //                            if (float.TryParse(txtValEv.Text.Trim(), out v) == false || v< 0.0)
        //                            {
        //                                msg = "Valor do evento inválido!";
        //                                throw new Exception();
        //                            }
        //                            else
        //                            {
        //                                using (SqlCommand cmd = new SqlCommand("update evento set valor = @p where id_evento = @id", conn, trans))
        //                                {
        //                                    cmd.Parameters.AddWithValue("@p", v);
        //                                    cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                    cmd.ExecuteNonQuery();
        //                                }
        //                            }
        //                        }

        //                        if (dropCatg.SelectedIndex != 0)
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update evento set catg = @p where id_evento = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", dropCatg.SelectedItem.Value);
        //                                cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        Regex reg1 = new Regex(@"^\(\d{2}\) \d{4}-\d{5}$", RegexOptions.None);
        //Regex reg2 = new Regex(@"^\(\d{2}\) \d{4}-\d{4}$", RegexOptions.None);

        //                        if (string.IsNullOrWhiteSpace(txtfone.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Telefone!";
        //                            throw new Exception();
        //                        }
        //                        else if (reg1.IsMatch(txtfone.Text.Trim()) == false && reg2.IsMatch(txtfone.Text.Trim()) == false)
        //                        {
        //                            msg = "Telefone inválido!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update evento set telefone = @p where id_evento = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtfone.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtIngEv.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Nro de Ingressos!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            int v;
        //                            if (int.TryParse(txtIngEv.Text.Trim(), out v) == false || v< 0)
        //                            {
        //                                msg = "Nro de ingressos inválido!";
        //                                throw new Exception();
        //                            }
        //                            else
        //                            {
        //                                using (SqlCommand cmd = new SqlCommand("update evento set nro_ingressos = @p where id_evento = @id", conn, trans))
        //                                {
        //                                    cmd.Parameters.AddWithValue("@p", v);
        //                                    cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                    cmd.ExecuteNonQuery();
        //                                }
        //                            }
        //                        }

        //                        DateTime dtEv, timeEv, dataEv;
        //                        if (string.IsNullOrWhiteSpace(txtDT.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Data!";
        //                            throw new Exception();
        //                        }
        //                        else if (DateTime.TryParse(txtDT.Text.Trim(), System.Globalization.CultureInfo.GetCultureInfo("pt-br"), System.Globalization.DateTimeStyles.None, out dataEv) == false || (DateTime.Compare(dataEv.Date, DateTime.Now.Date) < 0))
        //                        {
        //                            msg = "Data inválida!";
        //                            throw new Exception();
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtHR.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Hora!";
        //                            throw new Exception();
        //                        }
        //                        else if (DateTime.TryParse(txtHR.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture /* change if appropriate */, System.Globalization.DateTimeStyles.None, out timeEv) == false)
        //                        {
        //                            msg = "Hora inválida!";
        //                            throw new Exception();
        //                        }

        //                        dtEv = new DateTime(dataEv.Year, dataEv.Month, dataEv.Day, timeEv.Hour, timeEv.Minute, timeEv.Second);

        //                        if (DateTime.Compare(dtEv, DateTime.Now) < 0)
        //                        {
        //                            msg = "Hora inválida!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update evento set dt_evento = @p where id_evento = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", dtEv);
        //                                cmd.Parameters.AddWithValue("@id", _idEvento);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtEnd.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Logradouro!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update endereco set logradouro = @p where cod_endereco = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtEnd.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEndereco);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtNroEnd.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Número!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            int n;
        //                            if (int.TryParse(txtNroEnd.Text.Trim(), out n) == false || n< 0)
        //                            {
        //                                msg = "Digite um número de endereco válido!";
        //                                throw new Exception();
        //                            }
        //                            else
        //                            {
        //                                using (SqlCommand cmd = new SqlCommand("update endereco set nro_log = @p where cod_endereco = @id", conn, trans))
        //                                {
        //                                    cmd.Parameters.AddWithValue("@p", n);
        //                                    cmd.Parameters.AddWithValue("@id", _idEndereco);
        //                                    cmd.ExecuteNonQuery();
        //                                }
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtBairroEnd.Text.Trim()))
        //                        {
        //                            msg = "Preencha o campo Bairro!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update endereco set bairro = @p where cod_endereco = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtBairroEnd.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEndereco);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtCid.Text.Trim()))
        //                        {
        //                            msg = "Preecnha o campo Cidade!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update endereco set cidade = @p where cod_endereco = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtCid.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEndereco);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (string.IsNullOrWhiteSpace(txtEst.Text.Trim()))
        //                        {
        //                            msg = "Preecnha o campo Estado!";
        //                            throw new Exception();
        //                        }
        //                        else
        //                        {
        //                            using (SqlCommand cmd = new SqlCommand("update endereco set estado = @p where cod_endereco = @id", conn, trans))
        //                            {
        //                                cmd.Parameters.AddWithValue("@p", txtEst.Text.Trim());
        //                                cmd.Parameters.AddWithValue("@id", _idEndereco);
        //                                cmd.ExecuteNonQuery();
        //                            }
        //                        }

        //                        if (up.HasFile)
        //                        {
        //                            if (up.PostedFile.ContentType == "image/png" || up.PostedFile.ContentType == "image/jpg" || up.PostedFile.ContentType == "image/jpeg")
        //                            {
        //                                up.SaveAs(Server.MapPath($"~/App_Data/Images/{_idEvento}-imagem.jpg"));
        //                            }
        //                            else
        //                            {
        //                                msg = "Selecione um arquivo do tipo imagem!";
        //                                throw new Exception();
        //                            }
        //                        }

        //                        trans.Commit();
        //                        atualizou = true;

        //                    }
        //                    catch (Exception)
        //                    {
        //                        if (trans != null)
        //                            trans.Rollback();
        //                    }
        //                    finally
        //                    {
        //                        if (trans != null)
        //                            trans.Dispose();
        //                    }

        //                    if (atualizou)
        //                    {
        //                        Response.Redirect($"~/Evento.aspx?evento={_idEvento}");
        //                    }
        //                    else if (msg != "")
        //                    {
        //                        lblMsg.Text = msg;
        //                    }
        //                    else
        //                    {
        //                        lblMsg.Text = "Não foi possível concluir a operação!";
        //                    }
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                lblMsg.Text = "Erro de conexão inesperado!";
        //            }
        //        }
    }
}