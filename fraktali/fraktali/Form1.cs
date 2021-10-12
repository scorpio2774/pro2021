using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraktali
{
    public partial class Form1 : Form
    {
        private double x; //pozicija
        private double y;
        private double alfa; //kot glede na os x
        public Form1()
        {
            InitializeComponent();
        }

        private int risaniX(double xr) {
            return (int)Math.Round(this.Width * xr);
        }

        private int risaniY(double yr) {
            return (int)Math.Round(this.Height - this.Height * yr);
        }

        public void obratLevo(double kot) {
            alfa = alfa + kot;
        }

        //public void premik(double d, Graphics g) {
        //    double stariX = x;
        //    double stariY = y;
        //    x = x + d * Math.Cos(alfa * Math.PI / 180);
        //    y = y + d * Math.Sin(alfa * Math.PI / 180);
        //    int x1 = risaniX(stariX);
        //    int y1 = risaniY(stariY);
        //    int x2 = risaniX(x);
        //    int y2 = risaniY(y);

        //    g.DrawLine(new Pen(Color.Black, 3), x1, y1, x2, y2);

        //}

        //public void koch(int n, double korak, Graphics g) {
        //    if (n == 0) {
        //        premik(korak, g);
        //        return;
        //    }
        //    koch(n - 1, korak, g);
        //    obratLevo(60);
        //    koch(n - 1, korak, g);
        //    obratLevo(-120);
        //    koch(n - 1, korak, g);
        //    obratLevo(60);
        //    koch(n - 1, korak, g);
        //}

        public void drevo(int n, double x, double y, double a, double dolzina, Graphics g) {
            int kot = 30;
            double pojemek = 0.65;
            int kotUpogiba=5;
            double cx = x + dolzina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolzina * Math.Sin(a * Math.PI / 180);
            int x1 = risaniX(cx);
            int y1 = risaniY(cy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(150)); ;
            Pen p = new Pen(c);
            g.DrawLine(p, x1, y1, x2, y2);

            if (n == 0) 
                return;
            drevo(n - 1, cx, cy, a + kotUpogiba - kot, dolzina * pojemek, g);
            drevo(n - 1, cx, cy, a + kotUpogiba + kot, dolzina * pojemek, g);
            drevo(n - 1, cx, cy, a + kotUpogiba, dolzina * (1 - pojemek), g);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*x = 0.5;
            y = 0.1;
            alfa = 0;

            for (int i = 0; i < 6; i++) {
                double korak = 0.3;
                premik(korak, g);
                obratLevo(360 / 6);
            }*/
            /*Random r = new Random();
            x = 0.5;
            y = 0.5;
            alfa = 0;
            for (int i = 0; i < 10000; i++) { 
                 obratLevo(r.Next(360));
                premik(0.01, g);
            }*/

            /*x = 0.3;
            y = 0.2;
            alfa = 0;
            int n = 3;

            for (int i = 0; i < 6; i++)
            {
                double korak = 0.3;
                koch(n, 0.4 / Math.Pow(3, n), g);
                obratLevo(360 / 6);
            }*/

            int n = 15;
            drevo(n, 0.3, -0.5, 90, 0.5, g);

        }
    }
}
