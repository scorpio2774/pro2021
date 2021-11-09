using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgranjeKart
{
    class Karta
    {
        public Vrednosti Vrednost { get; set; }
        public Barva Barva { get; set; }
        public string Ime { 
            get { return Vrednost + " " + Barva; } 
        }

        public Karta(Vrednosti v, Barva b) {
            Vrednost = v;
            Barva = b;
        }

    }
}
