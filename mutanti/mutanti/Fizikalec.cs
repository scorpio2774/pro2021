using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Fizikalec : mutant
    {
        public int IQ { get; set; }
        public int Moc { get; set; }
        public override int KvocientNevarnosti()
        {
            int kn = Stopnja * IQ * Moc;
            return kn;
        }
    }
}
