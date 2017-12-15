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
        //private int idCriador;
        private DateTime data;
        private string telefone;
        private double valor;
        private int categoria;
        //private string nomeCriador;
        private DateTime dataCriacao;
        private Endereco endereco;
        private Usuario criador;
        private DateTime dataCompra;
        private ServicosEvento servicos;

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

        // public int IdCriador
        // {
        //     get
        //     {
        //         return idCriador;
        //     }
        //     set
        //     {
        //         idCriador = value;
        //     }
        // }

        // public string NomeCriador
        // {
        //     get
        //     {
        //         return nomeCriador;
        //     }
        //     set
        //     {
        //         nomeCriador = value;
        //     }
        // }

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

        public Usuario Criador
        {
            get
            {
                return criador;
            }
            set
            {
                criador = value;
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

        public ServicosEvento Servicos
        {
            get
            {
                return servicos;
            }
            set
            {
                servicos = value;
            }

        }

        public void Salvar()
        {
            servicos.Salvar();
        }

        public void Apagar()
        {
            servicos.Apagar();
        }

        public static Evento Carregar(string tipo, int id)
        {
            ServicosEvento.CarregarEvento(tipo);
            return null;
        }

        public static List<Evento> CarregarEventos(string tipo, string catg, int id)
        {
            return ServicosEvento.CarregarEventos(tipo, catg, id);
        }

    }
}