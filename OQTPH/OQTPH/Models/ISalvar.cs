using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Models
{
    public interface ISalvar
    {
        bool Salvar(EventoBase evento);
    }
}