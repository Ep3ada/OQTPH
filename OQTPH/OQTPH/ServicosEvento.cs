using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OQTPH.Models;

namespace OQTPH
{
    public abstract class ServicosEvento
    {
        public abstract void Salvar(Evento evento);

        public abstract void Apagar(int id);

        public static Evento CarregarEvento(string tipo, int id)
        {
            if (tipo.Equals("simples"))
            {
                //CarregarEventoSimples();

            }

            return null;
        }

        public static List<Evento> CarregarEventos(string tipo, string catg, int id)
        {
            if (tipo.Equals("simples") && catg.Equals("criados"))
            {
                //return CarregarEventoSimples(id)
            }

            return null;

        }

    }
}
