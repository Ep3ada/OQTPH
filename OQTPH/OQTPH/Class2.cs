using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Models;
using OQTPH.Utils;

namespace OQTPH
{
    public class Class2
    {
//        SqlTransaction trans = null;
//            try
//            {
//                using (SqlConnection conn = Sql.OpenConnection())
//                {
//                    trans = conn.BeginTransaction();

//                    try
//                    {
//                        //variavel que guardará o id do endereco
//                        int idEndereco;

//                        //envia os dados para a tabela endereco
//                        using (SqlCommand command = new SqlCommand("INSERT INTO Endereco (logradouro, nro_log, bairro, cidade, estado)" +
//                            "OUTPUT INSERTED.cod_endereco VALUES (@log, @nlog, @bair, @cid, @est)", conn, trans))
//                        {
//                            //substitui os parametros com arroba(@) pelos valores digitados pelo usuario
//                            command.Parameters.AddWithValue("@log", endereco);
//                            command.Parameters.AddWithValue("@nlog", nroEndereco);
//                            command.Parameters.AddWithValue("@bair", bairro);
//                            command.Parameters.AddWithValue("@cid", cidade);
//                            command.Parameters.AddWithValue("@est", estado);

//                            idEndereco = (int) command.ExecuteScalar();
//    //command.ExecuteScalar();
//}

//                        //envia esses dados para a tabela evento
//                        using (SqlCommand command = new SqlCommand("INSERT INTO EVENTO (Nome_Evento, dt_evento, desc_evento, nro_ingressos," +
//                            "cod_criador, cod_endereco, telefone, valor, catg, dt_criou) OUTPUT Inserted.id_evento VALUES (@nome, @dt, @desc, @nro," +
//                            "@criador, @ender, @fone, @val, @cat, @dtcria)", conn, trans))
//                        {
//                            //substitui os parametros com arroba(@) pelos valores digitados pelo usuario
//                            command.Parameters.AddWithValue("@nome", nome);
//                            command.Parameters.AddWithValue("@dt", data);
//                            command.Parameters.AddWithValue("@desc", descricao);
//                            command.Parameters.AddWithValue("@nro", nroIngressos);

//                            command.Parameters.AddWithValue("@criador", _usuario.Id);
//                            command.Parameters.AddWithValue("@ender", idEndereco);

//                            //tem q validar se é um telefone pq nçao tá validando
//                            command.Parameters.AddWithValue("@fone", telefone);

//                            command.Parameters.AddWithValue("@val", valorDoIngresso);
//                            command.Parameters.AddWithValue("@cat", categoria);

//                            //salva a data da criação do evento no banco de dados
//                            command.Parameters.AddWithValue("@dtcria", DateTime.Now);

//                            int idEvento = (int)command.ExecuteScalar();

//up.SaveAs(Server.MapPath($"~/App_Data/Images/{idEvento}-imagem.jpg"));
//                        }

//                        trans.Commit();
//                        criou = true;
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

//                    if (criou)
//                    {
//                        lblMsg.Text = "Evento criado com sucesso!";

//                        txtNomeEv.Text = "";
//                        txtDescEv.Text = "";
//                        txtValEv.Text = "";
//                        dropCatg.SelectedIndex = 0;
//                        txtfone.Text = "";
//                        txtIngEv.Text = "";
//                        txtEnd.Text = "";
//                        txtNroEnd.Text = "";
//                        txtBairroEnd.Text = "";
//                        txtCid.Text = "";
//                        txtEst.Text = "";

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
        public Evento SalvarEventoCompleto()
        {

        }



    }
}