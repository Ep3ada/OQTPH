using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Utils
{
    public class Categoria
    {
        private static string[] _categorias =
        {
             "Ciência/Tecnologia",
            "Show",
            "Infantil",
            "Festa",
            "Teatro",
            "Concerto",
            "Stand-Up",
            "Moda/Beleza",
            "Artes",
            "Business",
            "Dança",
            "Outra"
        };

        public static string[] Categorias
        {
            get
            {
                return _categorias;
            }
        }
        
    }
}