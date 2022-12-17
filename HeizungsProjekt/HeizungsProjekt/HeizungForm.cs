namespace HeizungsProjekt
{
    public partial class HeizungForm : Form
    {
        
        Heizung heizung;
        public HeizungForm()
        {
            InitializeComponent();
            heizung = new Heizung();
        }

        private void ErhoehenButton_Click(object sender, EventArgs e)
        {
            reloadGUI();
            heizung.waermer();
            reloadGUI();
        }

        private void senkenButton_Click(object sender, EventArgs e)
        {
            reloadGUI();
            heizung.kuehler();
            reloadGUI();
        }

        private void reloadGUI()
        {
            temperaturLabel.Text = "Temperatur: " + heizung.gibTemperatur().ToString() + " °C";
        }

        private void setzenButton_Click(object sender, EventArgs e)
        {
            try
            {
                int schrittweite = Convert.ToInt32(schrittweiteTextBox.Text);
                heizung.setzeSchrittweite(schrittweite);
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message,"Fehler");
            }
        }

        
    }
}