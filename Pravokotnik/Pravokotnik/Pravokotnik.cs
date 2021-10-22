using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    class Pravokotnik
    {
        private double Širina;
        private double Višina;

        public Pravokotnik() {
            Širina = 0;
            Višina = 0;
        }

        public Pravokotnik(double a, double b) {
            Širina = a;
            Višina = b;
        }



        public double Višina1 { get => Višina; set => Višina = value; }
        public double Širina1 { get => Širina; set => Širina = value; }

        public double Ploščina { get => Širina * Višina; }

        public static bool operator ==(Pravokotnik a, Pravokotnik b) {
            return a.Ploščina == b.Ploščina;
        }
        public static bool operator !=(Pravokotnik a, Pravokotnik b) {
           return a.Ploščina != b.Ploščina;
        }

        public static bool operator >(Pravokotnik a, Pravokotnik b) {
            return a.Ploščina > b.Ploščina;
        }

        public static bool operator <(Pravokotnik a, Pravokotnik b)
        {
            return a.Ploščina < b.Ploščina;
        }
        public override string ToString()
        {
            return "Višina je " + Višina + ", Širina je " + Širina;
        }

    }
}
