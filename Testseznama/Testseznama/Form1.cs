using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testseznama
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtVnos.Text);
            txtKonzola.Text = "Dodan k seznamu nov element " + txtVnos.Text;
            txtVnos.Text = "";
            txtVnos.Focus();

        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Elementi seznama:" + Environment.NewLine;
            //for (int k = 0; k < a.Count; k++) {
            //    txtKonzola.Text += a[k] + Environment.NewLine;
            //}

            foreach (string x in a) {
                txtKonzola.Text += x + Environment.NewLine;
            }
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            a.Remove(txtVnos.Text);
            txtKonzola.Text = "Odstranjen element " + txtVnos.Text;
            txtVnos.Text = "";
            txtVnos.Focus();
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Prvi element v seznamu je " + a[0];
        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Zadnji element v seznamu je " + a[a.Count-1];
        }

        private void btnPrazen_Click(object sender, EventArgs e)
        {
            if (a.Count == 0)
            {
                txtKonzola.Text = "Seznam je prazen";
            }
            else { txtKonzola.Text = "Seznam ni prazen"; }
        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Indeks niza je " + a.IndexOf(txtVnos.Text);
            txtVnos.Text = "";
            txtVnos.Focus();
        }

        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            bool b = a.Contains(txtVnos.Text);
            if (b == true)
            {
                txtKonzola.Text = "Seznam vsebuje " + txtVnos.Text;
            }
            else { txtKonzola.Text = "Seznam ne vsebuje " + txtVnos.Text; }
            txtVnos.Text = "";
            txtVnos.Focus();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            a.TrimToSize();
            txtKonzola.Text = "Seznam je skrajšan";
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Velikost seznama je " + a.Count + Environment.NewLine + "Kapaciteta seznama je " + a.Capacity;

        }
    }
}
