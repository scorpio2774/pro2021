using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    abstract class mutant : Iprikazovalnik
    {
        public string Ime { get; set; }
        public int Stopnja { get; set; }

        public abstract int KvocientNevarnosti();

        public void PrikaziInformacije()
        {
            Console.WriteLine(("**********MUTANT************"));
            Console.WriteLine(Ime);
            Console.WriteLine("Kvocient nevarnosti " + KvocientNevarnosti());
        }
    }
}
