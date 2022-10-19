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

            material = comboBox1.Text;
            quer = Convert.ToDouble(textBox1);
            laenge = Convert.ToDouble(textBox2.Text);

            if (material == "Aluminium");
            {
                mKonstante = 35;
            }
            
                else if (material = "Konstantan")
                  {  
                        mKonstante = 2.01;
                  }
                    
                   else if  (material == "Kupfer")
                      {
                          mKonstante = 56;
                      }
                      
                     else 
                          {
                            mKonstante = 7,7;
                          }


            rLeiter = Auswertung.Wiederstand(länge, mKonstante, quer);
            label4.Text = Auswertung.Ausgabe(rLeiter);
        }


       
        }

    }
