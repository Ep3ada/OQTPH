using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Utils
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException()
            : base()
        {
        }

        public ValorInvalidoException(string message)
            : base(message)
        {
        }

        public ValorInvalidoException(string message, Exception inner)
        : base(message, inner)
    {
        }

    }
}