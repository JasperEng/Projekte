using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeizungsProjekt
{
    public class Heizung
    {
        // Instanzvariablen - ersetzen Sie das folgende Beispiel mit Ihren Variablen
        private int temperatur;
        private int min;
        private int max;
        private int schrittweite;


        /**
         * Konstruktor für Objekte der Klasse Heizung
         */
        public Heizung()
        {
            temperatur = 0;
            min = 0;
            max = 30;
            schrittweite = 5;

        }

        public Heizung(int neuetemperatur, int neuemin, int neuemax, int neueschrittweite)
        {
            temperatur = neuetemperatur;
            min = neuemin;
            max = neuemax;
            schrittweite = neueschrittweite;

        }

        public int gibTemperatur()
        {
            return temperatur;
        }

        public int gibSchrittweite()
        {
            return schrittweite;
        }

        public void waermer()
        {
            if (temperatur < max)
            {
                temperatur = temperatur + schrittweite;
            }
            if (temperatur >= max)
            {
                temperatur = max;
            }
        }

        public void kuehler()
        {
            if (temperatur > min)
            {
                temperatur = temperatur - schrittweite;
            }
            if (temperatur <= min)
            {
                temperatur = min;
            }
        }

        public void setzeSchrittweite(int neueSchritweite)
        {
            schrittweite = neueSchritweite;
            if (schrittweite < 0)
            {
                schrittweite = 1;
            }
        }

    }
}
