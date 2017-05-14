using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cinema.Model
{
    public class SalaB
    {
        MySqlConnection cn = new MySqlConnection(@"server=lamp.ii.us.edu.pl;user id=ii302052;persistsecurityinfo=True;database=ii302052;password=123456Op*;");

        public int[] wielkosc(int id)
        {
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT max(row),max(number) from seat where auditorium_id=" + id, cn);
            MySqlDataReader a = cmd.ExecuteReader();
            int[] wartosci = new int[2];
            while (a.Read())
            {
                wartosci[0] = a.GetInt32(0);
                wartosci[1] = a.GetInt32(1);
            }
            cn.Close();
            return wartosci;

        }
        public int[][] miejca_zarezerwowane(int id)
        {
            int[][] zajete = new int[35][];
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT seat_id,row,number FROM seat join seat_reserved where screening_id=" + id, cn);
            MySqlDataReader a = cmd.ExecuteReader();
            int i = 0;
            if (a.HasRows == false)
            {
                return null;
            }
            while (a.Read())
            {
                zajete[i] = new int[] { a.GetInt32(1), a.GetInt32(2) };
                i++;
            }



            cn.Close();
            return zajete;
        }


    }
}
