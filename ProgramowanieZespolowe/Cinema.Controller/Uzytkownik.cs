using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Cinema.Controller

   
{
    public class Uzytkownik
    {
        public bool walidacja(string a, string b)
        {
            Regex rgxlog = new Regex(@"^[a-z0-9_-]{3,16}$");
            Regex rgxpas = new Regex(@"^[a-z0-9_-]{6,18}$");
          return rgxlog.IsMatch(a) && rgxpas.IsMatch(b) ? true : false;
        }
        public bool logowanie(string login, string haslo)
        {
            //string pobranelogin = "funkcja z bazy";
           // string pobranehaslo = "funkcja z bazy";
            if (walidacja(login, haslo))
                return true;
            else
                return false;
        }
      
    }
}
