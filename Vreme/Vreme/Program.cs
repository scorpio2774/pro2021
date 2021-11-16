using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vreme
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\pro2021\Vreme\Vreme\bilje.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(AGROMET));
            AGROMET a = (AGROMET)xml.Deserialize(fs);
            foreach (AGROMETDATA x in a.DATA) {
                Console.WriteLine(x.Temp2_Max + " " + x.Date);

            }

            Console.ReadLine();
        }
    }
}
