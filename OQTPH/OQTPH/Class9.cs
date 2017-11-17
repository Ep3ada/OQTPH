using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class9
    {
        //        if (filtro == "Todas" || filtro == null)
        //            {

        //                //dá select count, peg ao resultado e divide pelo numero de intenns por pagina, dai pega esse outro result e cria os links
        //                //offset numero de itenpopag * pagenum-1 fetch itensporpag rows only
        //                //  try
        //                //{
        //                using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    using (SqlCommand cmd = new SqlCommand("SELECT Count(id_evento) FROM Evento", conn))
        //                    {
        //                        numDeEvs = (int) cmd.ExecuteScalar();
        //    }

        //    // maxpages recebe calculo pra definir numero máximo de páginas
        //    //verifica se o numero passado na query string é maior q o numero maximo de paginas
        //    //se for maior, atribui o maxpages q representa a ultima pagina, para não fazer busca por pagina inexistente
        //    maxpages = (int) Math.Ceiling((double) numDeEvs / (double) itemPPage);

        //                    if (maxpages == 0)
        //                    {
        //                        numpage = 1;
        //                    }
        //                    else if (maxpages<numpage)
        //                    {
        //                        numpage = maxpages;
        //                    }

        //                    // verifica se há itens para se mostrar, caso não haja deve mostrar em um label q não tem ou uma imagem
        //                    if (numDeEvs > 0)
        //                    {
        //                        //faz busca por nome e id do evento na tabela evento por eventos q ainda tenham ingresso
        //                        using (SqlCommand cmd = new SqlCommand("SELECT Nome_evento, id_evento FROM Evento where nro_ingressos > 0 order by nome_evento offset @nItens * (@page - 1) rows fetch next @nItens rows only", conn))
        //                        {
        //                            //substitui os parametros com arroba na query pelo numero da pagina e pelo numero de itens por pagina
        //                            cmd.Parameters.AddWithValue("@page", numpage);
        //                            cmd.Parameters.AddWithValue("@nItens", itemPPage);

        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                // Tenta obter o registro
        //                                while (reader.Read() == true)
        //                                {

        //                                    string nomeEv = reader.GetString(0);
        //int idEv = reader.GetInt32(1);

        //EventoModelo evento = new EventoModelo() { Id = idEv, Nome = nomeEv };
        //lista.Add(evento);
        //                                }
        //                            }
        //                        }
        //                    }
        //                    //else{ coloca uma mensagem dizendo q não tem eventos ou uma imagem

        //                }
        //                //  }
        //                //catch (Exception)
        //                //{
        //                //lblMsg.Text = "Erro na conexão!";
        //                //}

        //                //pega numero total e divide pelo tanto de itens por pagina
        //                //faz assim int maxpages = (int)Math.ceiling((double)num, (double)nitems);
        //                //*****int maxpages = (int)Math.Ceiling((double)numDeEvs / (double)itemPPage);
        //                ant = numpage - 1;
        //                prox = numpage + 1;

        //                if (numpage< 2)
        //                {
        //                    lbCur.Text = "1";
        //                }
        //                else
        //                {
        //                    lbCur.Text = numpage.ToString();
        //                }

        //                //se o numero da pagina é maior q 1 e menor q maxpages
        //                //atribui as tags <a> da pagina anterior e da proxima com o valor da pagina atual menos 1 para a anterior e da atual mais 1 para a proxima
        //                if (numpage > 1 && numpage<maxpages)
        //                {
        //                    Aant.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, ant));
        //                    Aprox.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, prox));

        //                }
        //                else
        //                {
        //                    //caso seja igual a 1 link anterior é desativada e prox é pagina atual mais 1
        //                    //caso seja igual a maxpages pro´xima é desativada e ant é atual menos 1
        //                    if (numpage == 1)
        //                    {
        //                        Aant.Disabled = true;
        //                        Aprox.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, prox));
        //                    }
        //                    else if (numpage == maxpages)
        //                    {
        //                        Aprox.Disabled = true;
        //                        Aant.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, ant));
        //                    }
        //                }

        //            }
        //            else
        //            {

        //                //dá select count, peg ao resultado e divide pelo numero de intenns por pagina, dai pega esse outro result e cria os links
        //                //offset numero de itenpopag * pagenum-1 fetch itensporpag rows only
        //                //  try
        //                //{
        //                using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    using (SqlCommand cmd = new SqlCommand("SELECT Count(id_evento) FROM Evento where catg = @cat", conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@cat", filtro);

        //                        numDeEvs = (int) cmd.ExecuteScalar();
        //                    }

        //                    // maxpages recebe calculo pra definir numero máximo de páginas
        //                    //verifica se o numero passado na query string é maior q o numero maximo de paginas
        //                    //se for maior, atribui o maxpages q representa a ultima pagina, para não fazer busca por pagina inexistente
        //                    maxpages = (int) Math.Ceiling((double) numDeEvs / (double) itemPPage);

        //                    if (maxpages<numpage)
        //                    {
        //                        numpage = maxpages;
        //                    }

        //                    // verifica se há itens para se mostrar, caso não haja deve mostrar em um label q não tem ou uma imagem
        //                    if (numDeEvs > 0 && maxpages > 0)
        //                    {
        //                        //faz busca por nome e id do evento na tabela evento por eventos q ainda tenham ingresso
        //                        using (SqlCommand cmd = new SqlCommand("SELECT Nome_evento, id_evento FROM Evento where nro_ingressos > 0 and catg = @cat order by nome_evento offset @nItens * (@page - 1) rows fetch next @nItens rows only", conn))
        //                        {
        //                            //substitui os parametros com arroba na query pelo numero da pagina e pelo numero de itens por pagina
        //                            cmd.Parameters.AddWithValue("@cat", filtro);
        //                            cmd.Parameters.AddWithValue("@page", numpage);
        //                            cmd.Parameters.AddWithValue("@nItens", itemPPage);

        //                            using (SqlDataReader reader = cmd.ExecuteReader())
        //                            {
        //                                // Tenta obter o registro
        //                                while (reader.Read() == true)
        //                                {
        //                                    string nomeEv = reader.GetString(0);
        //int idEv = reader.GetInt32(1);

        //EventoModelo evento = new EventoModelo() { Id = idEv, Nome = nomeEv };
        //lista.Add(evento);
        //                                }
        //                            }
        //                        }
        //                    }
        //                    //else{ coloca uma mensagem dizendo q não tem eventos ou uma imagem

        //                }
        //                //  }
        //                //catch (Exception)
        //                //{
        //                //lblMsg.Text = "Erro na conexão!";
        //                //}

        //                //pega numero total e divide pelo tanto de itens por pagina
        //                //faz assim int maxpages = (int)Math.ceiling((double)num, (double)nitems);
        //                //*****int maxpages = (int)Math.Ceiling((double)numDeEvs / (double)itemPPage);
        //                ant = numpage - 1;
        //                prox = numpage + 1;

        //                if (numpage< 2)
        //                {
        //                    lbCur.Text = "1";
        //                }
        //                else
        //                {
        //                    lbCur.Text = numpage.ToString();
        //                }

        //                //se for igual a um disabilita prox e ant
        //                //se o numero da pagina é maior q 1 e menor q maxpages
        //                //atribui as tags <a> da pagina anterior e da proxima com o valor da pagina atual menos 1 para a anterior e da atual mais 1 para a proxima

        //                if (maxpages == 0)
        //                {
        //                    Aprox.Disabled = true;
        //                    Aant.Disabled = true;
        //                }
        //                else if (numpage > 1 && numpage<maxpages)
        //                {
        //                    Aant.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, ant));
        //                    Aprox.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, prox));
        //                }
        //                else
        //                {
        //                    //caso seja igual a 1 link anterior é desativada e prox é pagina atual mais 1
        //                    //caso seja igual a maxpages pro´xima é desativada e ant é atual menos 1
        //                    if (numpage == 1)
        //                    {
        //                        if (numpage == maxpages)
        //                        {
        //                            Aprox.Disabled = true;
        //                            Aant.Disabled = true;
        //                        }
        //                        else
        //                        {
        //                            Aant.Disabled = true;
        //                            Aprox.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, prox));
        //                        }
        //                    }
        //                    else if (numpage == maxpages)
        //                    {
        //                        Aprox.Disabled = true;
        //                        Aant.Attributes.Add("href", string.Format("~/Default.aspx?filter={0}&page={1}", filtro, ant));
        //                    }
        //                }
        //            }
    }
}