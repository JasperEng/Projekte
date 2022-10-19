using System;
using System.Collections.Generic;
using System.Text;

namespace Leiterwiderstand
{
    class Auswertung
    {

        public static double Widerstand(double l, double k, double a) {

            double wid;

            wid = l / (k * a);
            return wid;
        
        }

        public static string Ausgabe(double r) {

            string ausgabe;

            ausgabe = ("Der Leiterwiederstand beträgt: " + r.ToString("F2") + " Ohm");

            return ausgabe;
        }
    }
}
