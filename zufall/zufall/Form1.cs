using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zufall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z1, zs;
            try
            {
                z1 = Convert.ToInt16(textBox1.Text);
                zs = Spiel.zufall();
                label1.Text = zs.ToString();
            }
            catch (Exception ausnahme)
            {
                MessageBox.Show(ausnahme.Message, "Fehler");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z2, zs;
            try
            {
            z2 = Convert.ToInt16(textBox1.Text);
            zs = Spiel.zufall();
            label2.Text = zs.ToString();
            }
            catch (Exception ausnahme)
            {
                MessageBox.Show(ausnahme.Message, "Fehler");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z3, zs;
            try{
            z3 = Convert.ToInt16(textBox1.Text);
            zs = Spiel.zufall();
            label3.Text = zs.ToString();
             }
            catch (Exception ausnahme)
            {
                MessageBox.Show(ausnahme.Message, "Fehler");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int z1,z2,z3,a1,a2,a3;
            string erg;
            try{
            z1 = Convert.ToInt16(textBox1.Text);
            z2 = Convert.ToInt16(textBox2.Text);
            z3 = Convert.ToInt16(textBox3.Text);
            a1 = Convert.ToInt16(label1.Text);
            a2 = Convert.ToInt16(label2.Text);
            a3 = Convert.ToInt16(label3.Text);

            erg = Spiel.gewinn(z1, z2, z3, a1, a2, a3);
            MessageBox.Show(erg.ToString());
             }
            catch (Exception ausnahme)
            {
                MessageBox.Show(ausnahme.Message, "Fehler");
            }
            

        }
    }
}
