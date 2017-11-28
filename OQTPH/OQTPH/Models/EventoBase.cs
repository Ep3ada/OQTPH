using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Utils;

namespace OQTPH.Models
{
    public abstract class EventoBase
    {
        private int id;
        private string nome;
        private string descricao;
        private int nroIngressos;
        private int idCriador;
        private DateTime data;
        private string telefone;
        private double valor;
        private int categoria;
        private string nomeCriador;
        private DateTime dataCriacao;
        private Endereco endereco;
        private DateTime dataCompra;
        public ICarregar carregarStrategy;
        public ISalvar salvarStrategy;
        public IApagar apagarStartegy;

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

        public EventoBase(ISalvar salvar, ICarregar carregar)
        {
            salvarStrategy = salvar;
            carregarStrategy = carregar;
        }

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

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public int Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        public void SetCarregarStrategy(ICarregar strategy)
        {
            carregarStrategy = strategy;
        }

        public void SetSalvarStrategy(ISalvar strategy)
        {
            salvarStrategy = strategy;
        }

        public EventoBase Carregar(int idEvento)
        {
            return carregarStrategy.Carregar(idEvento);
        }

        public bool Salvar()
        {
            return salvarStrategy.Salvar(this);
        }
    }
}