using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Psiho : mutant
    {
        public int IQ { get; set; }
        public int SteviloUporabeMoci { get; set; }

        public override int KvocientNevarnosti()
        {
            int kn = Stopnja * IQ * SteviloUporabeMoci;
            return kn;
        }
    }
}
