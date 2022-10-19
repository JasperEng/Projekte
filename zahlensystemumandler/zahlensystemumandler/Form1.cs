using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zahlensystemumandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Dezw, er, erg;
            int[] zahlen = new int[10];
            string Ausgabe;

            try
            {

                Dezw = Convert.ToInt32(numericUpDown1.Text);

                Ausgabe= "";


   

               
                for (er = 0; er < 10; er++) {

                    erg = Dezw % 2;
                    Dezw = Dezw / 2;

                    zahlen[er] = erg;

                    Ausgabe = zahlen[er].ToString()+ Ausgabe;
                }

                label2.Text = Ausgabe;
            }catch (Exception error) {
                MessageBox.Show(error.Message + " Bitte geben Sie nur Ganze Zahlen ein! Keine leeren Eingaben oder Kommazahlen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
