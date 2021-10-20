using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vssmobil
{
    class Kupec60:Kupec
    {
        private int visjaTarifaPorabljeno;//koliko od 60 minut je že v uporabi
        public override void BeleziKlic(int minute, int tip) {
            switch (tip) {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2: //prvih 60 minut po 0.05, vse ostalo po 0.01
                    int vMinute, nMinute;
                    int seVminute = (visjaTarifaPorabljeno < 60) ? 60 - visjaTarifaPorabljeno : 0;
                    if (minute > seVminute)
                    {
                        vMinute = seVminute;
                        nMinute = minute - vMinute;
                    }
                    else {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.05m + nMinute * 0.01m;
                    visjaTarifaPorabljeno += vMinute;
                    break;
        }
        }
    }
}
