using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Models;
using OQTPH.Utils;

namespace OQTPH
{
    public class ServicosEndereco
    {
        public Endereco CarregarEndereco()
        {
            return null;
            //using (SqlConnection conn = Sql.OpenConnection())
            //{
            //    using (SqlCommand cmd = new SqlCommand("select en.logradouro, en.nro_log, en.bairro, en.cidade, en.estado, en.cod_endereco from" +
            //        "endereco en where cod_endereco = @id", conn))
            //    {
            //        cmd.Parameters.AddWithValue("@id", idEndereco);

            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {

        }

        //public bool SalvarEndereco(Endereco endereco)
        //{

        //}

        //public bool ApagarEndereco()
        //{

        //}
    }
}