﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Model;
using MySql.Data.MySqlClient;

namespace Cinema.Controller
{
    public class KalendarzFilmow
    {

        Model.KalendarzFilmowB kfb = new KalendarzFilmowB();
        public List<String> getlistaFilmow(String year, String month, String day)
        {
            return kfb.listaFilmow(year, month,day);
        }
        public List<String> getGodziny(int idfilmu,string data)
        {
            return kfb.godziny(idfilmu,data);
        }
        public int id_screening_wybranego(int idfilmu,string godzina,string data)
        {
            return kfb.screening_id(idfilmu,godzina, data);
        }
    }
}
