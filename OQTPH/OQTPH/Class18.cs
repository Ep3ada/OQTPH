using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class18
    {
        //        try
        //            {
        //                using (SqlConnection conn = Sql.OpenConnection())
        //                {
        //                    using (SqlCommand command = new SqlCommand("SELECT username, Nome, Email, Token FROM Usuario WHERE Id_usuario = @id", conn))
        //                    {
        //                        command.Parameters.AddWithValue("@id", usuario.Id);

        //                        using (SqlDataReader reader = command.ExecuteReader())
        //                        {

        //                            if (reader.Read() == false ||
        //                                string.IsNullOrWhiteSpace(usuario.Token) ||
        //                                string.Equals(usuario.Token, reader.GetString(3), StringComparison.Ordinal) == false)
        //                            {

        //                                return null;
        //                            }

        //                            usuario.UserN = reader.GetString(0); usuario.Nome = reader.GetString(1); usuario.Email = reader.GetString(2);
        //                        }
        //}
        //                }
        //            }
        //            catch (Exception) { return null; }

    }
}