using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public static class CarregarEventoCompleto
    {
        public static Evento Carregar(int idEvento)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ev.nome_evento, ev.desc_evento, ev.dt_evento, ev.nro_ingressos, " +
                                "ev.telefone, ev.valor, ev.catg, en.cod_endereco, en.logradouro, en.nro_log, en.bairro, en.cidade," +
                                "en.estado, u.nome, ev.cod_criador  FROM Evento ev join endereco en on(ev.cod_endereco = en.cod_endereco) join usuario u on" +
                                "(ev.cod_criador = u.id_usuario) where ev.id_evento = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEvento);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Endereco endereco = new Endereco()
                            {
                                Id = reader.GetInt32(7),
                                Logradouro = reader.GetString(8),
                                Numero = reader.GetInt32(9),
                                Bairro = reader.GetString(10),
                                Cidade = reader.GetString(11),
                                Estado = reader.GetString(12)
                            };

                            Usuario criador = new Usuario(reader.GetString(13), reader.GetInt32(14));

                            Evento evento = new EventoCompleto()
                            {
                                Id = idEvento,
                                Nome = reader.GetString(0),
                                Descricao = reader.GetString(1),
                                Data = reader.GetDateTime(2),
                                NroIngressos = reader.GetInt32(3),
                                Telefone = reader.GetString(4),
                                Valor = reader.GetDouble(5),
                                Categoria = reader.GetInt32(6),
                                Endereco = endereco,
                                Criador = criador
                            };

                            return evento;
                            //return null;
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