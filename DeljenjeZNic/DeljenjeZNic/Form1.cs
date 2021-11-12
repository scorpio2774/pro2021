using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeljenjeZNic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            
            int kolicnik =0;

            try
            {
                int deljenec = int.Parse(textBox1.Text);
                int delitelj = int.Parse(textBox2.Text);
                kolicnik = deljenec / delitelj;
                label3.Text = kolicnik + "";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Poskus deljenja z 0");
            }
            catch (FormatException) {
                MessageBox.Show("Vneseni morata biti 2 celi števili");
            }

        }
    }
}
