using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Models
{
    public class Endereco
    {
        private int id;
        private int numero;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string estado;
        // private SalvarEndereco _salvar;
        // private arregarEndereco _carregar;
        // private ApagarEndereco _apagar;

        //public Endereco(SalvarEndereco salvar, CarregarEndereco carregar, ApagarEndereco apagar)
        //{
        //    _salvar = salvar;
        //    _carregar = carregar;
        //    _apagar = apagar;
        //}

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }
            set
            {
                logradouro = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }
            set
            {
                bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }


        public void Salvar()
        {

        }

        public Endereco Carregar()
        {
            return null;
        }
    }
}