using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Leiterwiderstand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string material;
            double rLeiter, quer, laenge, mKonstante;

            try
            {

            material = comboBox1.Text;
            quer = Convert.ToDouble(textBox1.Text);
            laenge = Convert.ToDouble(textBox2.Text);

            
                if (material == "Aluminium")
                {
                    mKonstante = 35;
                    rLeiter = Auswertung.Widerstand(laenge, mKonstante, quer);
                    label4.Text = Auswertung.Ausgabe(rLeiter);
                }

                else if (material == "Konstantan")
                {
                    mKonstante = 2.01;
                    rLeiter = Auswertung.Widerstand(laenge, mKonstante, quer);
                    label4.Text = Auswertung.Ausgabe(rLeiter);
                }

                else if (material == "Kupfer")
                {
                    mKonstante = 56;
                    rLeiter = Auswertung.Widerstand(laenge, mKonstante, quer);
                    label4.Text = Auswertung.Ausgabe(rLeiter);
                }

                else
                {
                    switch (MessageBox.Show("Fehler bitte wählen sie ein material aus!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {

                        case DialogResult.OK: break;

                    }
                }
            }
            catch(Exception fehler){

                MessageBox.Show(fehler.Message + " Bitte überprüfen S^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ie ihre Eingaben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }


       
        }

    }
