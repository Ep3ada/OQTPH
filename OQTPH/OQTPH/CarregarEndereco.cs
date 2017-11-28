using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Models;
using OQTPH.Utils;

namespace OQTPH
{
    public static class CarregarEndereco
    {
        public static Endereco Carregar(int idEndereco)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT LOGRADOURO, NRO_LOG, BAIRRO, CIDADE, ESTADO" +
                                                       "FROM ENDERECO WHERE COD_ENDERECO = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idEndereco);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            return new Endereco()
                            {
                                Id = idEndereco,
                                Logradouro = reader.GetString(0),
                                Numero = reader.GetInt32(1),
                                Bairro = reader.GetString(2),
                                Cidade = reader.GetString(3),
                                Estado = reader.GetString(4)
                            };
                        }
                        else
                        {
                            throw new DadoNaoEncontradoException("Endereco não encontrado!");
                        }
                    }
                }
            }
        }
    }
}