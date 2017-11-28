using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public class CarregarEventoCompleto
    {
        public EventoBase Carregar(int idEvento)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ev.nome_evento, ev.desc_evento, ev.dt_evento, ev.nro_ingressos, ev.telefone," +
                                                       "ev.valor, ev.catg, ev.cod_criador, ev.cod_endereco" +
                                                       "FROM evento ev WHERE id_evento = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEvento);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //strategys aqui
                            EventoBase evento = new EventoCompleto()
                            {
                                Id = idEvento,
                                Nome = reader.GetString(0),
                                Descricao = reader.GetString(1),
                                Data = reader.GetDateTime(2),
                                NroIngressos = reader.GetInt32(3),
                                Telefone = reader.GetString(4),
                                Valor = reader.GetDouble(5),
                                Categoria = reader.GetInt32(6),
                                IdCriador = reader.GetInt32(7),
                                Endereco = new Endereco() { Id = reader.GetInt32(8)}
                            };

                            return evento;
                        }
                        else
                        {
                            throw new DadoNaoEncontradoException("Evento não encontrado!");
                        }
                    }
                }
            }
        }
    }
}