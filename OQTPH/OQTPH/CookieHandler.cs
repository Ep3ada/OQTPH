using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OQTPH
{
    public static class CookieHandler
    {
        public static string EnviarParaCliente(int id, string token)
        {
            string value = id + "|" + token;

            HttpCookie cookie = new HttpCookie("user", value);

            cookie.Expires = DateTime.UtcNow.AddYears(1);

            HttpContext.Current.Response.SetCookie(cookie);

            return "user=" + value + ";";
        }

        public static void RemoverDoCliente()
        {
            HttpCookie cookie = new HttpCookie("user", "");

            cookie.Expires = DateTime.UtcNow.AddYears(-1);

            HttpContext.Current.Response.SetCookie(cookie);
        }

        public static string[] PegarDoCliente()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["user"];
            if (cookie == null)
            {
                return null;
            }

            string[] values = cookie.Value.Split('|');
            if (values.Length != 2)
            {
                return null;
            }

            return values;
        }
    }
}