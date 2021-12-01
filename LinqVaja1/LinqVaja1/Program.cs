using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqVaja1
{
    class Program
    {
        static void Main(string[] args)
        {
            var kupci = new[]{
                 new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
                 new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
                 new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
                 new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
                 new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
                 new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
                 new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
                 new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
                 new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
                 new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
                 };
            var podjetja = new[] {
                 new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
                 new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
                 new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
                 new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"},
            };


            //1. napiši LINQ stavek s katerim izbereš in izpišeš vsa imena kupcev
            var x1 = from a in kupci
                     select a.Ime;

            foreach (var y in x1)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("___________________________________________");
            //2. napiši LINQ stavek katerim izbereš in izpišeš imena in priimke kupcev
            var x2 = from a in kupci
                     select new {ime= a.Ime,prii= a.Priimek };

            foreach (var y in x2)
            {
                Console.WriteLine(y.ime + " " + y.prii);
            }
            Console.WriteLine("___________________________________________");
            //3. izberi in izpiši vsa imena podjetji iz Slovenije
            var x3 = from a in podjetja
                     where a.Država=="Slovenija"
                     select a.ImePodjetja;

            foreach (var y in x3)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("___________________________________________");
            //4. Izpiši imena podjetji urejena po abecedi
            var x4 = from a in podjetja
                     orderby a.ImePodjetja
                     select a.ImePodjetja;

            foreach (var y in x4)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("___________________________________________");
            //5. izpiši koliko je različnih podjetji
            var x5 = from a in podjetja
                     select a.ImePodjetja.Distinct();

            Console.WriteLine("Podjetij je " + x5.Count());
            Console.WriteLine("___________________________________________");

            //6. izpiši koliko podjetij je iz Italije
            var x6 = from a in podjetja
                     where a.Država == "Italija"
                     select a;
            Console.WriteLine("Podjetij iz Italije je " + x6.Count());
            Console.WriteLine("___________________________________________");
            //7. izpiši iz koliko različnih držav imamo podjetja
            var x7 = from a in podjetja
                     select a.Država;
            Console.WriteLine("Podjetij je iz " + x7.Distinct().Count() + " različnih držav.");
            Console.WriteLine("___________________________________________");
            //8. Izpiši imena in priimke kupcev po podjetju
            var x8 = from a in kupci
                     group a by a.Podjetje into b
                     select b;
            foreach (var y in x8)
            {
                Console.WriteLine("Podjetje: " + y.Key);
                foreach (var x in y) {
                    Console.WriteLine("\t"+x.Ime+" "+x.Priimek);
                }
            }
            Console.WriteLine("___________________________________________");
            Console.ReadLine();
        }
    }
}
