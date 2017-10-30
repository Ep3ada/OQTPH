using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH.Utils
{
    public static class Categoria
    {

        public enum _categorias {
            Selecione,
            Show,

        };
        public static Dictionary<int, string> GetDictionaryFromEnum<T>()
        {

            string[] names = Enum.GetNames(typeof(T));

            Array keysTemp = Enum.GetValues(typeof(T));
            var keys = keysTemp.Cast<int>();

            var dictionary = keys.Zip(names, (k, v) => new
            {
                Key = k,
                Value = v
            }).ToDictionary(x => x.Key, x => x.Value);

            return dictionary;
            //return null;
        }

        //public static class Enumeration
        //{
            public static IDictionary<int, string> GetAll<TEnum>() where TEnum : struct
            {
                var enumerationType = typeof(TEnum);

                if (!enumerationType.IsEnum)
                    throw new ArgumentException("Enumeration type is expected.");

                var dictionary = new Dictionary<int, string>();

                foreach (int value in Enum.GetValues(enumerationType))
                {
                    var name = Enum.GetName(enumerationType, value);
                    dictionary.Add(value, name);
                }

                return dictionary;
            }
        //}


        public static bool VerificarValor(string valor, string texto)
        {
            

            return false;
        }
    }
}