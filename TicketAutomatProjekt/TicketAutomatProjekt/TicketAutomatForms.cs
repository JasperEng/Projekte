namespace TicketAutomatProjekt
{
    public partial class TicketAutomatForms : Form
    {
        Ticketautomat automat;
        public TicketAutomatForms()
        {
            InitializeComponent();
            automat = new Ticketautomat();
            benoetigtextBox.Text = automat.gibPreis().ToString() + " cent";
        }


        private void button10cent_Click(object sender, EventArgs e)
        {
            automat.geldEinwerfen(10);
            rechner();
        }

        private void button20cent_Click(object sender, EventArgs e)
        {
            automat.geldEinwerfen(20);
            rechner();
        }

        private void button50cent_Click(object sender, EventArgs e)
        {
            automat.geldEinwerfen(50);
            rechner();
        }

        private void button1eur_Click(object sender, EventArgs e)
        {
            automat.geldEinwerfen(100);
            rechner();
        }

        private void button2eur_Click(object sender, EventArgs e)
        {
            automat.geldEinwerfen(200);
            rechner();
        }

        private void buttonDrucken_Click(object sender, EventArgs e)
        {
            
            string auszug = automat.ticketDrucken();
            int geld = automat.wechselgeldAuszahlen();
            rueckgeldtextBox.Text = geld.ToString();
            ticketTextBox.Text = auszug.ToString();
            rechner();

        }

        private void rechner()
        {
            double aktuGeld;

            aktuGeld = automat.gibAnzahlung();
            aktutextBox.Text = aktuGeld.ToString() + " cent";

        }
    }
}