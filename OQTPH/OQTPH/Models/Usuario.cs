using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Web;
using OQTPH.Utils;

namespace OQTPH.Models
{
    public class Usuario
    {
        public const int TamanhoMaximoDoUserN = 15;
        public const int TamanhoMaximoDoNome = 30;
        public const int TamanhoMaximoDaSenha = 100;

        private int id;
        private string username;
        private string nome;
        private string email;
        private string token;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }
        }

        public Usuario(int id, string usern, string nome, string email, string token)
        {
            this.id = id;
            username = usern;
            this.nome = nome;
            this.email = email;
            this.token = token;
        }

        //public Usuario(int id, string token)
        //{
        //    this.id = id;
        //    this.token = token;
        //}

        public Usuario(string nome, int id)
        {
            this.id = id;
            this.nome = nome;
        }

        public static Usuario Criar(string nome, string email, string usern, string senha)
        {
            if (string.IsNullOrWhiteSpace(usern) || usern.Length > TamanhoMaximoDoUserN)
            {
                throw new ValorInvalidoException("Username inválido!");
            }

            if (string.IsNullOrWhiteSpace(nome) || nome.Length > TamanhoMaximoDoNome)
            {
                throw new ValorInvalidoException("Nome inválido!");
            }

            if (string.IsNullOrEmpty(senha) || senha.Length > TamanhoMaximoDaSenha)
            {
                throw new ValorInvalidoException("Senha inválida!");
            }

            int arroba, arroba2, ponto;
            arroba = email.IndexOf('@');
            arroba2 = email.LastIndexOf('@');
            ponto = email.LastIndexOf('.');
            if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
            {
                throw new ValorInvalidoException("E-mail inválido!");
            }

            return ServicosUsuario.CriarUsuario(nome, email, usern, senha);
        }

        public static Usuario Validar()
        {
            return ServicosUsuario.ValidarUsuario();
        }

        //public static Usuario ValidarException()
        //{
        //    Usuario usuario = Validar();
        //    if (usuario == null)
        //    { throw new Exception("Usuário inválido ou não conectado"); }

        //    return usuario;
        //}

        public static string FazerLogin(string login, string password)
        {
            return ServicosUsuario.FazerLogin(login, password);
        }

        public void FazerLogout()
        {
            ServicosUsuario.FazerLogout(id);
        }
    }
}