using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Utils
{
    public class DadoNaoEncontradoException : Exception
    {
        public DadoNaoEncontradoException()
            : base()
        {
        }

        public DadoNaoEncontradoException(string message)
            : base(message)
        {
        }

        public DadoNaoEncontradoException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}