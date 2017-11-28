using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OQTPH.Models;

namespace OQTPH
{
    public class EventoCompleto : EventoBase
    {
        public EventoCompleto(ISalvar salvar, ICarregar carregar) : base(salvar, carregar)
        {

        }

        //public void Salvar()
        //{

        //}

        //public static void Carregar(int idEvento)
        //{
        //    //ServicosEventoCompleto.Carregar(idEvento);
        //}
    }
}