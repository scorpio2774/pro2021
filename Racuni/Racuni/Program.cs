using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Racuni
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\pro2021\Racuni\Racuni\racun.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni rac = (IzdaniRacunEnostavni)xml.Deserialize(fs);
            foreach (var x in rac.Racun.PostavkeRacuna){
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1 + " " + x.KolicinaArtikla.Kolicina + " " + x.ZneskiPostavke.ZnesekPostavke);
            }


            Console.ReadLine();
        }
    }
}
