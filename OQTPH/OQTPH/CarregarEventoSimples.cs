using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public class CarregarEventoSimples
    {
        public List<Evento> CarregarEventosCriados(int id)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                List<Evento> lista = new List<Evento>();

                using (SqlCommand cmd = new SqlCommand("select e.id_evento, e.nome_evento, e.dt_evento from evento where cod_criador = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read() == true)
                            {
                                Evento evento = new Evento { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2) };

                                lista.Add(evento);
                            }
                        }
                        else
                        {
                            throw new DadoNaoEncontradoException("Não há eventos!");
                        }
                    }
                }
                return lista;
            }
        }

        public static List<Evento> CarregarEventosComprados(int id)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                List<Evento> lista = new List<Evento>();
                using (SqlCommand cmd = new SqlCommand("SELECT e.id_evento, e.nome_evento, e.dt_evento, c.dt_compra FROM EVENTO AS e join COMPRA AS c on (e.id_evento = c.cod_evento) where c.cod_pessoa = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read() == true)
                            {
                                Evento evento = new Evento { Id = reader.GetInt32(0), Nome = reader.GetString(1), Data = reader.GetDateTime(2), DataCompra = reader.GetDateTime(3) };
                                lista.Add(evento);
                            }
                        }
                        else
                        {
                            throw new DadoNaoEncontradoException("Não ha eventos!");
                        }
                    }
                }
                return lista;
            }
        }
    }
}