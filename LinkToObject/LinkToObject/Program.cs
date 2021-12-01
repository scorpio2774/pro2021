using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var prvo = 5;
            //Console.WriteLine("Podatkovni tip je " + prvo.GetType());
            //var drugo = "Dobro jutro";
            //Console.WriteLine("Podatkovni tip je " + drugo.GetType());
            //var tretje = drugo;
            //Console.WriteLine("Podatkovni tip je " + tretje.GetType());

            string[] dr = { "Bosna", "Albanija", "Srbija", "Florida", "Washington", "Oregon", "Iowa", "Illinois" };
            //izpiši vse države, ki se začnejo na I
            var drzaveNaI = from s in dr
                            where s.StartsWith("I")
                            select s;
            foreach(var d in drzaveNaI)
                Console.WriteLine(d);
            Console.WriteLine("__________________________________________________________________");
            //izpiši vse džave, ki imajo ime daljše od 5 znakov
            var x1 = from a in dr
                     where a.Length > 5
                     select a;
            foreach (var d in x1)
                Console.WriteLine(d);

            Console.WriteLine("__________________________________________________________________");

            var x2 = from a in dr
                     where a.Length > 5 && a.StartsWith("I")
                     select a;
            foreach (var d in x2)
                Console.WriteLine(d);

            Console.WriteLine("__________________________________________________________________");

            var x3 = from a in dr
                     orderby a //descending <- za obraten vrstni red
                     select a;
            foreach (var d in x3)
                Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
