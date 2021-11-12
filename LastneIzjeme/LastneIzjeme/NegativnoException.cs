using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastneIzjeme
{
    class NegativnoException:Exception
    {
        public NegativnoException():
            base("Ni dovoljeno računanje korena negativnih števil")
        {
            
        }

        public NegativnoException(string s):
            base("Izjema"+s)
        {

        }
    }
}
