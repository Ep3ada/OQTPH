using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class19
    {
        //        using (SqlConnection conn = Sql.OpenConnection())
        //            {
        //                using (SqlCommand command = new SqlCommand("SELECT Id_usuario, senha FROM Usuario WHERE username = @login", conn))
        //                {
        //                    command.Parameters.AddWithValue("@login", login);

        //                    using (SqlDataReader reader = command.ExecuteReader())
        //                    {
        //                        if (reader.Read() == false)
        //                        { return null; }

        //id = reader.GetInt32(0); hash = reader.GetString(1);
        //                    }
        //                }

        //                if (PasswordHash.ValidatePassword(password, hash))
        //                {
        //                    using (SqlCommand command = new SqlCommand("UPDATE Usuario SET Token = @token WHERE Id_usuario = @id", conn))
        //                    {
        //                        string token = Guid.NewGuid().ToString("N");
        //command.Parameters.AddWithValue("@token", token);
        //                        command.Parameters.AddWithValue("@id", id);

        //                        command.ExecuteNonQuery();
        //                        // Tanto o nome quanto o login não interessam para enviar para o cliente
        //                        UsuarioModelo usuario = new UsuarioModelo(id, "", "", "", token);
        //                        return usuario.EnviarParaCliente();
        //                    }
        //                }
        //            }

    }
}