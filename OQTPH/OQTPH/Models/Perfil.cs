using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Models
{
    public class Perfil
    {
        private List<Evento> eventosCriados;
        private List<Evento> eventosComprados;
        private List<Evento> eventosFiltro;

        public List<Evento> EventosCriados
        {
            get
            {
                return eventosCriados;
            }
        }

        public List<Evento> EventosFiltro
        {
            get
            {
                return eventosFiltro;
            }
        }

        public List<Evento> EventosComprados
        {
            get
            {
                return eventosComprados;
            }
        }

        public Perfil()
        {

        }

    }
}