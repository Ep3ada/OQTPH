using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Utils;
using OQTPH.Models;

namespace OQTPH
{
    public static class ServicosUsuario
    {
        public static string FazerLogin(string login, string password)
        {
            Usuario usuario = Login(login, password);
            return CookieHandler.EnviarParaCliente(usuario.Id, usuario.Token);
        }

        public static Usuario CriarUsuario(string nome, string email, string usern, string senha)
        {
            return Criar(nome, email, usern, senha);
        }

        public static void FazerLogout(int id)
        {
            Logout(id);
            CookieHandler.RemoverDoCliente();
        }

        public static Usuario ValidarUsuario()
        {
            string[] values = CookieHandler.PegarDoCliente();

            if (values == null)
            {
                return null;
            }

            return Validar(values);
        }

        private static Usuario Criar(string nome, string email, string usern, string senha)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO USUARIO (Nome, Email, Username, Senha, Token) OUTPUT INSERTED.ID_USUARIO VALUES (@nome, @email, @login, @senha, '')", conn))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@login", usern);
                    command.Parameters.AddWithValue("@senha", PasswordHash.CreateHash(senha));

                    int id = (int)command.ExecuteScalar();

                    // Como esse usuário acabou de ser criado, ele não está logado, por isso não tem token
                    return new Usuario(id, usern, nome, email, "");
                }
            }
        }

        private static Usuario Login(string login, string password)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                int id;
                string hash;
                string token = Guid.NewGuid().ToString("N");

                using (SqlCommand command = new SqlCommand("SELECT Id_usuario, senha FROM Usuario WHERE username = @login", conn))
                {
                    command.Parameters.AddWithValue("@login", login);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() == false)
                        { return null; }

                        id = reader.GetInt32(0); hash = reader.GetString(1);
                    }
                }

                if (PasswordHash.ValidatePassword(password, hash))
                {
                    using (SqlCommand command = new SqlCommand("UPDATE Usuario SET Token = @token WHERE Id_usuario = @id", conn))
                    {
                        command.Parameters.AddWithValue("@token", token);
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                        // Tanto o nome quanto o login não interessam para enviar para o cliente

                    }
                }

                return new Usuario(id, "", "", "", token);
                //return usuario.EnviarParaCliente();
            }
        }

        private static void Logout(int id)
        {
            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("UPDATE Usuario SET Token = '' WHERE Id_usuario = @id", conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        private static Usuario Validar(string[] values)
        {
            try
            {
                using (SqlConnection conn = Sql.OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand("SELECT username, Nome, Email, Token FROM Usuario WHERE Id_usuario = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(values[0]));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() == false ||
                                string.IsNullOrWhiteSpace(values[1]) ||
                                string.Equals(values[1], reader.GetString(3), StringComparison.Ordinal) == false)
                            {
                                return null;
                            }

                            return new Usuario(int.Parse(values[0]), reader.GetString(0), reader.GetString(1), reader.GetString(2), values[1]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}