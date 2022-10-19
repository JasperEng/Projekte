using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kapitalrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Kapital,mKapital ,Zeitj, jKapital, dKapital,Zinsen,Zeit;

            try
            {

                Kapital = Convert.ToDouble(textBox1.Text);
                Zinsen = Convert.ToDouble(comboBox1.Text);
                Zeit = Convert.ToDouble(comboBox2.Text);

                mKapital = Kapital * 2;
                Zeitj = 0;
                dKapital = Kapital;
                jKapital = Kapital;

                while (dKapital <= mKapital)
                {


                    if (Zeit > Zeitj)
                    {
                        jKapital = jKapital + (jKapital / 100 * Zinsen);
                        dKapital = dKapital + (dKapital / 100 * Zinsen);
                        Zeitj++;
                    }
                    else {
                        dKapital = dKapital + (dKapital / 100 * Zinsen);
                        Zeitj++;
                    }
                    
                }

                label5.Text = jKapital.ToString() + "€";
                MessageBox.Show("kapitalverdopplung nach: "+Zeitj.ToString() + "Jahren", "Information");
            }
            catch (Exception error) {
                MessageBox.Show(error.Message + " Überprüfen Sie ihre eingaben!", "Error");
            }
        }
    }
}
