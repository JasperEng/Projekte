using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAutomatProjekt
{
    public class Ticketautomat
    {
        // Der Preis eines Tickets dieses Automaten
        private int preis;

        // Der Betrag, der bisher vom Automatenbenutzer eingeworfen wurde
        private int anzahlung;

        // Die Geldsumme, die bisher von diesem Automaten durch Ticketverkäufe eingenommen wurde
        private int bestand;

        // Erzeuge einen Automaten, der Tickets zum angegebenen Preis (in Cent) ausgibt
        public Ticketautomat(int ticketpreis)
        {
            preis = ticketpreis;
            anzahlung = 0;
            bestand = 0;
        }

        public Ticketautomat()
        {
            preis = 700;
            anzahlung = 0;
            bestand = 0;
        }

        // Liefere den Preis eines Tickets dieses Automaten (in Cent)
        public int gibPreis()
        {
            return preis;
        }

        // Liefere die Höhe des Betrags, der für das nächste Ticket bereits eingeworfen wurde
        public int gibAnzahlung()
        {
            return anzahlung;
        }

        // Nimm den angegebenen Betrag (in Cent) als Anzahlung für das nächste Ticket
        public void geldEinwerfen(int betrag)
        {
            if (betrag > 0)
            {
                anzahlung = anzahlung + betrag;
            }
        }

        // Drucke ein Ticket, wenn genügend Geld eingeworfen wurde, bzw.
        // gib eine Fehlermeldung aus, falls noch Geld für ein Ticket fehlt
        public String ticketDrucken()
        {
            String ticket;
            if (anzahlung >= preis)
            {
                // Den Ausdruck eines Tickets simulieren
                ticket = "Ticket für die BlueJ-Linie ... Ticketpreis: " + " --> " + preis + " Cent.";

                // Die Geldsumme, die bisher von diesem Automaten eingenommen wurde um den Ticketpreis erhöhen
                bestand = bestand + preis;

                // Den Preis von der bisherigen Bezahlung abziehen
                anzahlung = anzahlung - preis;
            }
            else
            {
                int restgeld = preis - anzahlung;
                ticket = "Sie müssen noch " + restgeld + " Cent einwerfen!";
            }
            return ticket;
        }

        // Gib das Wechselgeld bzw. den bisher gezahlten Betrag zurück
        public int wechselgeldAuszahlen()
        {
            int wechselgeld;
            wechselgeld = anzahlung;
            anzahlung = 0;
            return wechselgeld;
            //return anzahlung;
            //anzahlung = 0;
        }

        public int gibBestand()
        {
            return bestand;
        }

        public void setzePreis(int neuerTicketPreis)
        {
            preis = neuerTicketPreis;
        }

        public int leeren()
        {
            int entleer = bestand;
            bestand = 0;
            return entleer;
        }
    }
}
