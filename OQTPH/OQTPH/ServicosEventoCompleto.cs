using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public class ServicosEventoCompleto : ServicosEvento
    {
        public override void Apagar()
        {

        }


        private bool ValidarEvento(Evento evento)
        {
            //DAR TRIM QUNAOD INICIAILZAR OBJETO
            //USar replace em valor



            string descricao, categoria, telefone, bairro, cidade, estado, endereco;
            int nroIngressos, nroEndereco;
            float valorDoIngresso;
            DateTime dtaEv, hra, data;

            //*****************Parte do evento
            if (string.IsNullOrWhiteSpace(evento.Nome) || evento.Nome.Length > 80)
            {
                throw new ValorInvalidoException("Nome inválido!");
            }

            if (string.IsNullOrWhiteSpace(evento.Descricao) || evento.Descricao.Length > 700)
            {
                throw new ValorInvalidoException("Descrição inválida!");
            }

            if (float.TryParse(evento.Valor.ToString(), System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out valorDoIngresso) == false || valorDoIngresso < 0)
            {
                throw new ValorInvalidoException("Digite um valor válido!");
            }

            if (dropCatg.SelectedItem.Value == "0")
            { lblMsg.Text = "Selecione Categoria!"; return; }
            categoria = dropCatg.SelectedItem.Value;

            if (int.TryParse(txtIngEv.Text.Trim(), out nroIngressos) == false || nroIngressos <= 0)
            { lblMsg.Text = "Digite número de ingressos válidos!"; return; }

            Regex reg1 = new Regex(@"^\(\d{2}\) \d{4}-\d{5}$", RegexOptions.None);
            Regex reg2 = new Regex(@"^\(\d{2}\) \d{4}-\d{4}$", RegexOptions.None);


            if (string.IsNullOrWhiteSpace(txtfone.Text.Trim()) == true || (reg1.IsMatch(txtfone.Text.Trim()) == false && reg2.IsMatch(txtfone.Text.Trim()) == false))
            {
                lblMsg.Text = "Telefone inválido!";
                return;
            }
            telefone = txtfone.Text.Trim();

            //******************Parte do endereco
            if (string.IsNullOrWhiteSpace(txtEnd.Text.Trim()))
            { lblMsg.Text = "Logradouro inválido!"; return; }
            endereco = txtEnd.Text;

            if (int.TryParse(txtNroEnd.Text.Trim(), out nroEndereco) == false && nroEndereco <= 0)
            { lblMsg.Text = "Número de endereço inválido!"; return; }

            if (string.IsNullOrWhiteSpace(txtBairroEnd.Text.Trim()))
            { lblMsg.Text = "Bairro inválido!"; return; }
            bairro = txtBairroEnd.Text;

            if (string.IsNullOrWhiteSpace(txtCid.Text.Trim()))
            { lblMsg.Text = "Cidade inválida!"; return; }
            cidade = txtCid.Text;

            if (string.IsNullOrWhiteSpace(txtEst.Text.Trim()))
            { lblMsg.Text = "Estado inválido!"; return; }
            estado = txtEst.Text;

            if (DateTime.TryParse(txtDT.Text.Trim(), System.Globalization.CultureInfo.GetCultureInfo("pt-br"), System.Globalization.DateTimeStyles.None, out dtaEv) == false || (DateTime.Compare(dtaEv.Date, DateTime.Now.Date) < 0))
            { lblMsg.Text = "Data inválida"; return; }

            if (DateTime.TryParse(txtHR.Text.Trim(), System.Globalization.CultureInfo.InvariantCulture /* change if appropriate */, System.Globalization.DateTimeStyles.None, out hra) == false)
            { lblMsg.Text = "Hora inválida!"; return; }

            data = new DateTime(dtaEv.Year, dtaEv.Month, dtaEv.Day, hra.Hour, hra.Minute, hra.Second);

            if (DateTime.Compare(data.Date, DateTime.Now.Date) == 0)
            {
                if (TimeSpan.Compare(data.TimeOfDay, DateTime.Now.TimeOfDay) < 0)
                {
                    lblMsg.Text = "Hora inválida!";
                    return;
                }
            }

            //********************Parte da imagem
            if (!up.HasFile)
            { lblMsg.Text = "Selecione uma foto!"; return; }

            if (up.PostedFile.ContentType != "image/png" && up.PostedFile.ContentType != "image/jpg" && up.PostedFile.ContentType != "image/jpeg")
            { lblMsg.Text = "Selecione um arquivo do tipo imagem!"; return; }


        }

        public override void Salvar(Evento evento)
        {

            SqlTransaction trans = null;
            try
            {
                using (SqlConnection conn = Sql.OpenConnection())
                {
                    trans = conn.BeginTransaction();

                    try
                    {
                        //variavel que guardará o id do endereco
                        int idEndereco;

                        //envia os dados para a tabela endereco
                        using (SqlCommand command = new SqlCommand("INSERT INTO Endereco (logradouro, nro_log, bairro, cidade, estado)" +
                            "OUTPUT INSERTED.cod_endereco VALUES (@log, @nlog, @bair, @cid, @est)", conn, trans))
                        {
                            //substitui os parametros com arroba(@) pelos valores digitados pelo usuario
                            command.Parameters.AddWithValue("@log", endereco);
                            command.Parameters.AddWithValue("@nlog", nroEndereco);
                            command.Parameters.AddWithValue("@bair", bairro);
                            command.Parameters.AddWithValue("@cid", cidade);
                            command.Parameters.AddWithValue("@est", estado);

                            idEndereco = (int)command.ExecuteScalar();
                            //command.ExecuteScalar();
                        }

                        //envia esses dados para a tabela evento
                        using (SqlCommand command = new SqlCommand("INSERT INTO EVENTO (Nome_Evento, dt_evento, desc_evento, nro_ingressos," +
                            "cod_criador, cod_endereco, telefone, valor, catg, dt_criou) OUTPUT Inserted.id_evento VALUES (@nome, @dt, @desc, @nro," +
                            "@criador, @ender, @fone, @val, @cat, @dtcria)", conn, trans))
                        {
                            //substitui os parametros com arroba(@) pelos valores digitados pelo usuario
                            command.Parameters.AddWithValue("@nome", nome);
                            command.Parameters.AddWithValue("@dt", data);
                            command.Parameters.AddWithValue("@desc", descricao);
                            command.Parameters.AddWithValue("@nro", nroIngressos);

                            command.Parameters.AddWithValue("@criador", _usuario.Id);
                            command.Parameters.AddWithValue("@ender", idEndereco);

                            //tem q validar se é um telefone pq nçao tá validando
                            command.Parameters.AddWithValue("@fone", telefone);

                            command.Parameters.AddWithValue("@val", valorDoIngresso);
                            command.Parameters.AddWithValue("@cat", categoria);

                            //salva a data da criação do evento no banco de dados
                            command.Parameters.AddWithValue("@dtcria", DateTime.Now);

                            int idEvento = (int)command.ExecuteScalar();
                        }

                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        if (trans != null)
                            trans.Rollback();
                    }
                    finally
                    {
                        if (trans != null)
                            trans.Dispose();
                    }

                }

            }
            catch (Exception)
            {
                lblMsg.Text = "Erro de conexão inesperado!";
            }
        }
    }
}