using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastneIzjeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoren_Click(object sender, EventArgs e)
        {
            try
            {
                int stevilo = int.Parse(textBox1.Text);
                if (stevilo < 0)
                {
                    throw new NegativnoException();
                }

                double koren = Math.Sqrt(stevilo);
                textBox2.Text = koren + "";
            }
            catch (NegativnoException neg)
            {
                MessageBox.Show(neg.Message);
            }
            catch (FormatException) {
                MessageBox.Show("Ni bilo vneseno število");
            }
        }
    }
}
