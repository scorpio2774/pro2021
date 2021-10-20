using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Elementarec : mutant
    {
        public int podrocje { get; set; }

        public override int KvocientNevarnosti()
        {
            int kn = Stopnja * podrocje;
            return kn;
        }
    }
}
