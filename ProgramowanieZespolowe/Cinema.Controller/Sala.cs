using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Model;

namespace Cinema.Controller
{
    public class Sala
    {

        Model.SalaB salaB = new SalaB();

        public byte[][] sala(int id)
        {
            //1 bo nie ma innej w baze
            id = 1;
            //2 wartosci z bazy
            int[] wielkosc = salaB.wielkosc(id);
            //utworzenie tablicy byte[row][number] wypełninej 0
            byte[][] sala = new byte[wielkosc[0]][];
            for (int i = 0; i < sala.Length; i++)
            {
                sala[i] = new byte[wielkosc[1]];
            }
            for (int i = 0; i < sala.Length; i++)
            {
                for (int j = 0; j < sala[i].Length; j++)
                {
                    sala[i][j] = 0;
                }
            }
            List<int> zajete = salaB.miejca_zarezerwowane(1);
            if (zajete == null)
            {
                return sala;
            }
            for (int i = 0; i < zajete.Count - 1; i = i + 2)//zajete.Length
            {
                sala[zajete.ElementAt(i) - 1][zajete.ElementAt(i + 1) - 1] = 1;
            }




            return sala;
        }


        public void rezerwacja_nowa()
        {

        }

        public void rezerwacjamiejsce(int row, int number)//int ilosc miejcs w rzedzie dl tablicy
        {

            salaB.rezerwacjamiejsce(15, ((row - 1) * 7) + number, 1);
        }
        public void czysc()
        {
            salaB.czysc();
        }
    }
}
