using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgranjeKart
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup kup1 = new Kup();
        Kup kup2 = new Kup();
        public Form1()
        {
            InitializeComponent();
            Ponastavi(1);
            Ponastavi(2);
            Porazdeli(1);
            Porazdeli(2);
        }

        private void Ponastavi(int st){
            if (st == 1)
            {
                kup1 = new Kup(new Karta[] { });
                for (int i = 0; i < 10; i++)
                    kup1.Add(new Karta((Vrednosti)r.Next(1, 14),(Barva)r.Next(1,4)));
                kup1.Sort();
            }
            else
                kup2 = new Kup();
        }

        private void Porazdeli(int st)
        {
            if (st == 1)
            {
                listBox1.Items.Clear();
                foreach (string im in kup1.ImenaKart())
                {
                    listBox1.Items.Add(im);
                }
                label1.Text = "Kup 1";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string im in kup2.ImenaKart())
                {
                    listBox2.Items.Add(im);
                }
                label2.Text = "Kup 2 (" + kup2.Count + " kart)";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //vrednost je naključno število med 1 in 12
            Karta k = new Karta((Vrednosti) r.Next(1, 14), (Barva)r.Next(1, 4));
            MessageBox.Show(k.Ime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rezultat = "";
            List<Karta> kup = new List<Karta>();
            //generiraj 5 naključnih št
            for (int j = 0; j < 5; j++) {
                Karta k = new Karta((Vrednosti)r.Next(1, 14), (Barva)r.Next(1, 4));
                kup.Add(k);
                rezultat += k.Ime + Environment.NewLine;
            }
            //uredi kup kart
            kup.Sort(new Primerjava());
            rezultat += Environment.NewLine;
            rezultat += "Urejen kup" + Environment.NewLine;
            rezultat += Environment.NewLine;
            foreach (Karta x in kup)
            {
                rezultat += x.Ime + Environment.NewLine;
            }
            MessageBox.Show(rezultat);
        }

        private void pon1_Click(object sender, EventArgs e)
        {
            Ponastavi(1);
            Porazdeli(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                if (kup1.Count > 0)
                    kup2.Add(kup1.Deli(listBox1.SelectedIndex));
            Porazdeli(1);
            Porazdeli(2);
        }

        private void mes1_Click(object sender, EventArgs e)
        {
            kup1.Mešaj();
            Porazdeli(1);
        }

        private void pon2_Click(object sender, EventArgs e)
        {
            Ponastavi(2);
            Porazdeli(2);
        }

        private void mes2_Click(object sender, EventArgs e)
        {
            kup2.Mešaj();
            Porazdeli(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)

                if (kup2.Count > 0)
                    kup1.Add(kup2.Deli(listBox2.SelectedIndex));
            Porazdeli(1);
            Porazdeli(2);
        }
    }
}
