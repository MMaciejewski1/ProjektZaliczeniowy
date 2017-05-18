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
        public List<int> miejca_zarezerwowane(int id)
        {

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT seat_id,row,number FROM seat join seat_reserved on seat.id = seat_reserved.seat_id where screening_id=" + id, cn);
            MySqlDataReader a = cmd.ExecuteReader();

            if (a.HasRows == false)
            {
                return null;
            }
            List<int> zajete = new List<int>();
            //int[][] zajete = new int[a.][];
            while (a.Read())
            {
                zajete.Add(a.GetInt32(1));
                zajete.Add(a.GetInt32(2));
            }



            cn.Close();
            return zajete;
        }
        public void rezerwacja(int screenid, int user_id, int user_id2)
        {
            user_id = 2;
            user_id2 = 2;
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("  Insert into  reservation values (15," + screenid + ",2,1,'test',true,2,false)", cn);
            MySqlDataReader a = cmd.ExecuteReader();

            cn.Close();
        }
        public void rezerwacjamiejsce(int reservation_id, int seatid, int screening_id)
        {

            cn.Open();
            //Set @id = Select max(id) from seat_reserved+1
            MySqlCommand cmd = new MySqlCommand("  Insert into  seat_reserved values (" + seatid + "," + seatid + "," + reservation_id + "," + screening_id + ")", cn);
            cmd.ExecuteNonQuery();

            cn.Close();
        }
        public void czysc()
        {
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("delete from seat_reserved where reservation_id=15", cn);
            cmd.ExecuteNonQuery();

            cn.Close();
        }

    }
}
