using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Models;
using OQTPH.Utils;

namespace OQTPH
{
    public class CarregarEndereco
    {
        public Endereco Carregar(int idEndereco)
        {
            Endereco endereco = new Endereco();
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT LOGRADOURO, NRO_LOG, BAIRRO, CIDADE, ESTADO, COD_ENDERECO" +
                                                       "FROM ENDERECO WHERE COD_ENDERECO = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idEndereco);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            
                        }
                    }
                }
            }

            return null;
        }
    }
}