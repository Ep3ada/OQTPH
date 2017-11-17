using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Utils;

namespace OQTPH.Models
{
    public class Evento
    {
        private int id;
        private string nome;
        private string descricao;
        private int nroIngressos;
        private int idCriador;
        private string nomeCriador;
        private DateTime dataCriacao;
        private Endereco endereco;
        private DateTime dataCompra;
        private ICarregar carregarStrategy;
        private ISalvar salvarStrategy;
        private IApagar apagarStrategy;

        public Evento(ICarregar carregar, ISalvar salvar)
        {
            carregarStrategy = carregar;
            salvarStrategy = salvar;
        }

        //public Evento(
        //    int id,
        //    string nome,
        //    string descricao,
        //    int nroIngressos,
        //    int idCriador,
        //    string nomeCriador,
        //    DateTime dataCriacao,
        //    Endereco endereco,
        ////    DateTime dataCompra)
        //{
        //    this.id = id;
        //    this.nome = nome;
        //    this.descricao = descricao;
        //    this.nroIngressos = nroIngressos;
        //    this.idCriador = idCriador;
        //    this.nomeCriador = nomeCriador;
        //    this.dataCriacao = dataCriacao;
        //    this.endereco = endereco;
        //    this.dataCompra = dataCompra;
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

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }
        public int NroIngressos
        {
            get
            {
                return nroIngressos;
            }
            set
            {
                nroIngressos = value;
            }
        }

        public int IdCriador
        {
            get
            {
                return idCriador;
            }
            set
            {
                idCriador = value;
            }
        }
        public string NomeCriador
        {
            get
            {
                return nomeCriador;
            }
            set
            {
                nomeCriador = value;
            }
        }
        public DateTime DataCriacao
        {
            get
            {
                return dataCriacao;
            }
            set
            {
                dataCriacao = value;
            }
        }
        public Endereco Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
        public DateTime DataCompra
        {
            get
            {
                return dataCompra;
            }
            set
            {
                dataCompra = value;
            }
        }

        public ICarregar CarregarStrategy
        {
            set
            {
                carregarStrategy = value;
            }
        }

        public ISalvar SalvarStrategy
        {
            set
            {
                salvarStrategy = value;
            }
        }

        public IApagar APagarStrategy
        {
            set
            {
                apagarStrategy = value;
            }
        }

        public void Salvar()
        {
            salvarStrategy.Salvar();
        }

        public void Carregar()
        {
            // cria uma instacia vazia, usa esse metodo e atribui o retorno pra esse obj
            carregarStrategy.Carregar();
        }

        public void Apagar()
        {
            // cria uma instacia vazia, usa esse metodo e atribui o retorno pra esse obj
           apagarStrategy.Apagar();
        }
    }
}