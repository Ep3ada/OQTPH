using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Utils;

namespace OQTPH
{
    public abstract class EventoSimples
    {
        private int id;
        private string nome;
        private DateTime data;
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

        public void Salvar(){
            servicos.Salvar(this);
        }

    }
}