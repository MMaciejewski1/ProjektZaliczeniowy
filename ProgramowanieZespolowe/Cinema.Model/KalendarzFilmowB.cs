using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class KalendarzFilmowB
    {
        MySqlConnection cn = new MySqlConnection(@"server=lamp.ii.us.edu.pl;user id=ii302052;persistsecurityinfo=True;database=ii302052;password=123456Op*;");


        public List<String> listaFilmow(String year, String month, String day)
        {
            List<String> tab = new List<String>();
            cn.Open();
            String rok = "YEAR(screening_start) = '"+year+"'";
            String miesiac = "MONTH(screening_start) = '"+ month+"'";
            String dzien = "DAY(screening_start) = '"+day+"'";
            MySqlCommand cmd = new MySqlCommand("select screening_time from screening where " + rok + "and" + miesiac + "and" +dzien
                , cn);
            MySqlDataReader a = cmd.ExecuteReader();
            while (a.Read())
            {
                a.Read();
                tab.Add(a.GetString("screening_time"));
            }
            a.Close();
            cn.Close();
            return tab;
        }
    }

}
