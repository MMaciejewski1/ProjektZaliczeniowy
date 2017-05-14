using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Cinema.Model
{
    public class UzytkownikB
    {

        MySqlConnection cn = new MySqlConnection(@"server=lamp.ii.us.edu.pl;user id=ii302052;persistsecurityinfo=True;database=ii302052;password=123456Op*;");
        public bool operacjeNaBazie(string login, string haslo)
        {
            bool test=false;
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select username from user where username='" + login + "'", cn);
            MySqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                a.Close();
                cmd.CommandText = "select password from user where username = '" + login + "'";
                a = cmd.ExecuteReader();
                a.Read();
                if (haslo == a.GetString("password")) test = true; 
            }
            else  test = false;
            cn.Close();
            return test;


        }
        public String getUserPositionB(String login)
        {
            String position = "null";
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select position from user where username='" + login + "'", cn);
            MySqlDataReader a = cmd.ExecuteReader();
            if (a.Read())
            {
                a.Read();
                position = a.GetString("position");
                a.Close();
            }
            return position;
        }
    }
}
