using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public static class ServicosPerfilFiltro
    {
        public static List<Evento> AtualizarFiltro(string categoria, int id)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                try
                {
                    Atualiza(categoria, conn, id);
                }
                catch (DadoNaoEncontradoException)
                {
                    Insere(categoria, id, conn);
                }
            }

            return CarregarEventos(id, categoria);
        }

        private static void Insere(string cat, int id, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("set nocount on insert into filtro values(@filt, @id)", conn))
            {
                cmd.Parameters.AddWithValue("@filt", cat);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        private static void Atualiza(string categoria, SqlConnection conn, int id)
        {
            using (SqlCommand cmd = new SqlCommand("update filtro set filt = @filt where id_user = @id ", conn))
            {
                cmd.Parameters.AddWithValue("@filt", categoria);
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() <= 0)
                {
                    throw new DadoNaoEncontradoException();
                }
            }
        }

        private static string PegarCategoriaFiltro(int id, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT filt from filtro where id_user = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                //var retorno = cmd.ExecuteScalar() ?? "";
                var retorno = cmd.ExecuteScalar();

                if (retorno == null)
                {
                    throw new DadoNaoEncontradoException("Erro inesperado!");
                }

                return retorno.ToString();
            }
        }

        public static List<Evento> CarregarEventos(int id, string cat)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                if (string.IsNullOrEmpty(cat))
                {
                    cat = PegarCategoriaFiltro(id, conn);
                }

                using (SqlCommand cmd = new SqlCommand("SELECT top 5 id_evento, nome_evento, dt_evento FROM evento where catg = @cat and dt_evento >= @now order by dt_criou desc", conn))
                {
                    List<Evento> lista = null;
                    cmd.Parameters.AddWithValue("@cat", cat);
                    cmd.Parameters.AddWithValue("@now", DateTime.Now);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            lista = new List<Evento>();
                            while (reader.Read())
                            {
                                Evento evento = new Evento() { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2) };
                                lista.Add(evento);
                            }
                        }
                        else
                        {
                            throw new DadoNaoEncontradoException("Não há eventos!");
                        }

                        return lista;
                    }
                }
            }
        }
    }
}