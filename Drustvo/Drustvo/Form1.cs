using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drustvo
{
    public partial class Form1 : Form
    {
        string pot = Resource1.pot;
        public Form1()
        {
            InitializeComponent();
            dtpDatum.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Darovi d = new Darovi();

                d.ZapSt = int.Parse(txtZapST.Text);
                d.Datum = dtpDatum.Value;
                d.Namen = txtNamen.Text;
                d.Znesek = decimal.Parse(txtZnesek.Text);



                d.Opombe = txtOpombe.Text;

                //vpiši v datoteko
                //odpri datoteko in dodaj na konec
                FileStream fs = new FileStream(pot, FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, d);
                fs.Close();
                sbStatus.Text = "Zapisano";
                txtZapST.Clear();
                txtZnesek.Clear();
                txtNamen.Clear();
                txtOpombe.Clear();
                txtZapST.Focus();
            }
            catch (FormatException)
            {
                sbStatus.Text = "Napaka";
            }

        }

        private void dtpDatum_Enter(object sender, EventArgs e)
        {
            sbStatus.Text = "Nov";
        }

        private void txtZapST_Leave(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtZapST.Text);
                sbStatus.Text = "Pripravljen";
                button1.Enabled = true;
            }
            catch (FormatException)
            {
                sbStatus.Text = "Napačna zaporedna številka";
                txtZapST.Clear();
                txtZapST.Focus();
                button1.Enabled = false;
            }
        }

        private void txtZnesek_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal d = decimal.Parse(txtZnesek.Text);
                sbStatus.Text = "Pripravljen";
                button1.Enabled = true;
            }
            catch (FormatException)
            {
                sbStatus.Text = "Napačen znesek";

                txtZnesek.Clear();
                txtZnesek.Focus();
                button1.Enabled = false;
            }
        }
    }
}
