using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Models;

namespace OQTPH
{
    public class EventoCompleto : Evento
    {

        
        public override bool Salvar()
        {
            return false;
        }

        public override bool Apagar()
        {
            return false;
        }

        //public static void Carregar(int idEvento)
        //{
        //    ServicosEventoCompleto.Carregar(idEvento);
        //}
    }
}