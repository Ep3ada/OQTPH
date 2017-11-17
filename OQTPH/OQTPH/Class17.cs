using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public class Class17
    {
        //        if (string.IsNullOrWhiteSpace(usern) || usern.Length > TamanhoMaximoDoUserN)
        //            { throw new Exception("Username inválido!");
        //    }

        //            if (string.IsNullOrWhiteSpace(nome) || nome.Length > TamanhoMaximoDoNome)
        //            { throw new Exception("Nome inválido!");
        //}

        //            if (string.IsNullOrEmpty(senha) || senha.Length > TamanhoMaximoDaSenha)
        //            { throw new Exception("Senha inválida!"); }

        //            int arroba, arroba2, ponto;
        //arroba = email.IndexOf('@');
        //            arroba2 = email.LastIndexOf('@');
        //            ponto = email.LastIndexOf('.');
        //            if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
        //            { throw new Exception("E-mail inválido!"); }

        //            using (SqlConnection conn = Sql.OpenConnection())
        //            {
        //                // Para outros SQL Server
        //                // using (SqlCommand command = new SqlCommand("INSERT INTO tbUsuario (Login, Nome, Password, Token) OUTPUT tbUser.Id VALUES (@login, @nome, @password, '')", conn)) {

        //                // Para o Azure
        //                using (SqlCommand command = new SqlCommand("INSERT INTO USUARIO (Nome, Email, Username, Senha, Token) OUTPUT INSERTED.ID_USUARIO VALUES (@nome, @email, @login, @senha, '')", conn))
        //                {
        //                    command.Parameters.AddWithValue("@nome", nome);
        //                    command.Parameters.AddWithValue("@email", email);
        //                    command.Parameters.AddWithValue("@login", usern);
        //                    command.Parameters.AddWithValue("@senha", PasswordHash.CreateHash(senha));

        //                    int id = (int)command.ExecuteScalar();

        //                    // Como esse usuário acabou de ser criado, ele não está logado, por isso não tem token
        //                    return new UsuarioModelo(id, usern, nome, email, "");
        //                }
        //            }
    }
}