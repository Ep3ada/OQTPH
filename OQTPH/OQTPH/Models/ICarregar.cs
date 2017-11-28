using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OQTPH.Models
{
    public interface ICarregar
    {
        EventoBase Carregar(int id);
    }
}
