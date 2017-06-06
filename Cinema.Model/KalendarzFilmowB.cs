﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class KalendarzFilmowB
    {

        MySqlConnection connection = new MySqlConnection(@"server=lamp.ii.us.edu.pl;user id=ii302052;persistsecurityinfo=True;database=ii302052;password=123456Op*;");

        public List<String> godziny(int idFilmu,String year, String month, String day)        {
            InfoOFilmieB b = new InfoOFilmieB();
            List<String> tab = new List<String>();
            connection.Open();
            //nie sprawdzało daty 
            //MySqlCommand cmd = new MySqlCommand("  SELECT TIME(screening_start) as aa FROM screening where movie_id ="+ idFilmu, cn);
            String rok = " YEAR(screening_start) = '" + year + "'";
            String miesiac = " MONTH(screening_start) = '" + month + "'";
            String dzien = " DAY(screening_start) = '" + day + "'";
            MySqlCommand cmd = new MySqlCommand("  SELECT TIME(screening_start) as aa FROM screening where movie_id = " + idFilmu+ " and " + rok + "and" + miesiac + "and" +dzien, connection);
            MySqlDataReader a = cmd.ExecuteReader();
            while (a.Read())
            {
                tab.Add(a.GetString(0));
            }
            a.Close();
            connection.Close();
            return tab;
        }

        public List<String> listaFilmow(String year, String month, String day)
        {
            InfoOFilmieB b = new InfoOFilmieB();
            List<String> tab = new List<String>();
            connection.Open();
            String rok = "YEAR(screening_start) = '"+year+"'";
            String miesiac = " MONTH(screening_start) = '"+ month+"'";
            String dzien = " DAY(screening_start) = '"+day+"'";
            MySqlCommand cmd = new MySqlCommand("select movie_id from screening where " + rok + "and" + miesiac + "and" +dzien, connection);
            MySqlDataReader a = cmd.ExecuteReader();
            while (a.Read())
            {
                tab.Add(b.FilmPoDacie(a.GetInt32("movie_id")));
            }
            a.Close();
            connection.Close();
            return tab;
        }

        public List<int> GetAllFilmsId(String year, String month, String day) {
            List<int> filmsId = new List<int>();
            connection.Open();
            String rok = "YEAR(screening_start) = '" + year + "'";
            String miesiac = " MONTH(screening_start) = '" + month + "'";
            String dzien = " DAY(screening_start) = '" + day + "'";
            MySqlCommand cmd = new MySqlCommand("select movie_id from screening where " + rok + "and" + miesiac + "and" + dzien, connection);
            MySqlDataReader a = cmd.ExecuteReader();
            while (a.Read()) {
                int filmId = a.GetInt32("movie_id");
                filmsId.Add(filmId);
            }
            a.Close();
            connection.Close();
            return filmsId;
        }

        public int screening_id(int idFilmu, string godzina,string data)
        {
            InfoOFilmieB b = new InfoOFilmieB();
            int screening_id = 1;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id  FROM screening where screening_start='" +data+" "+ godzina + "' and movie_id="+ idFilmu,connection);
            MySqlDataReader a = cmd.ExecuteReader();
            if(a.HasRows)
            while (a.Read())
            {
                screening_id = a.GetInt32(0);
            }
            a.Close();
            connection.Close();
            return screening_id;
        }

    }

}
