using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drustvo
{ [Serializable]
    public class Darovi
    {
        public int ZapSt { get; set; }
        public DateTime Datum { get; set; }
        public string Namen { get; set; }
        public decimal Znesek { get; set; }
        public string Opombe { get; set; }

        //zaradi serializacije mora biti konstruktor brez parametru

        public Darovi()
        {

        }
    }
}
