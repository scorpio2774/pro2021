using LinkToObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObject
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

            //string[] dr = { "Bosna", "Albanija", "Srbija", "Florida", "Washington", "Oregon", "Iowa", "Illinois" };
            ////izpiši vse države, ki se začnejo na I
            //var drzaveNaI = from s in dr
            //                where s.StartsWith("I")
            //                select s;
            //foreach(var d in drzaveNaI)
            //    Console.WriteLine(d);
            //Console.WriteLine("__________________________________________________________________");
            ////izpiši vse džave, ki imajo ime daljše od 5 znakov
            //var x1 = from a in dr
            //         where a.Length > 5
            //         select a;
            //foreach (var d in x1)
            //    Console.WriteLine(d);

            //Console.WriteLine("__________________________________________________________________");

            //var x2 = from a in dr
            //         where a.Length > 5 && a.StartsWith("I")
            //         select a;
            //foreach (var d in x2)
            //    Console.WriteLine(d);

            //Console.WriteLine("__________________________________________________________________");

            //var x3 = from a in dr
            //         orderby a //descending <- za obraten vrstni red
            //         select a;
            //foreach (var d in x3)
            //    Console.WriteLine(d);

            List<Naročilo> naročilaList = setupNaročila();
            var x1 = from n in naročilaList
                     select n;
            foreach (var y in x1) {
                Console.WriteLine(y.NaročiloID + " " + y.Datum);

            }
            Console.WriteLine("__________________________________________________________________");
            var x2 = from n in naročilaList
                     select n.Datum;
            foreach (var y in x2)
            {
                Console.WriteLine(y.ToShortDateString());

            }
            Console.WriteLine("__________________________________________________________________");
            var x3 = from n in naročilaList
                     select new { Dan = n.Datum, ID = n.NaročiloID };
            foreach (var y in x3)
            {
                Console.WriteLine(y.ID + " " + y.Dan);

            }
            Console.WriteLine("__________________________________________________________________");

            var x4 = from n in naročilaList
                     from n1 in n.Elementi
                     select n1;
            foreach (var y in x4)
            {
                Console.WriteLine(y.ElementID+" "+y.ImeIzdelka+" " + y.Količina);

            }
            Console.WriteLine("__________________________________________________________________");

            var x5 = from n in naročilaList
                     where n.NaročiloID==9010
                     select n;
            foreach (var y in x5)
            {
                Console.WriteLine(y.NaročiloID+" "+y.Datum);

            }
            Console.WriteLine("__________________________________________________________________");

            var x6 = from n in naročilaList
                     where n.Elementi.Count()>2
                     select n;
            foreach (var y in x6)
            {
                Console.WriteLine(y.NaročiloID + " " + y.Datum);

            }
            Console.WriteLine("__________________________________________________________________");

            int[] števila = { 46, 24, 79, 35, 12, 57, 80, 68, 46 };
            var izraz = števila.Count();
            Console.WriteLine("Števil je " + izraz);
            var izraz1 = števila.Sum();
            Console.WriteLine("Vsota je " + izraz1);
            var izraz2 = števila.Min();
            Console.WriteLine("Minimmum je " + izraz2);
            var izraz3 = števila.FirstOrDefault();
            Console.WriteLine("Prvo je " + izraz3);
            var izraz4 = števila.Any();
            Console.WriteLine("Ali je polno? " + izraz4);
            var izraz5 = števila.Distinct().Count();
            Console.WriteLine("Različnih je " + izraz5);

            Console.ReadLine();
        }
        private static List<Naročilo> setupNaročila() { 
            List<Naročilo> NaročiloList = new List<Naročilo>(); 
            Naročilo o1 = new Naročilo(); 
            o1.Datum = DateTime.Parse("12.7.2010"); 
            o1.NaročiloID = 9009; 
            PodrobnostiNaročila oi1 = new PodrobnostiNaročila(); 
            oi1.ElementID = 123; oi1.ImeIzdelka = "Mars"; 
            oi1.Količina = 2; o1.Elementi.Add(oi1); 
            PodrobnostiNaročila oi2 = new PodrobnostiNaročila(); 
            oi2.ElementID = 124; oi2.ImeIzdelka = "Kraš"; 
            oi2.Količina = 3; o1.Elementi.Add(oi2); 
            Naročilo o2 = new Naročilo(); 
            o2.Datum = DateTime.Parse("12.1.2011"); 
            o2.NaročiloID = 9010; 
            PodrobnostiNaročila oi3 = new PodrobnostiNaročila(); 
            oi3.ElementID = 125; oi3.ImeIzdelka = "Mars"; 
            oi3.Količina = 1; o2.Elementi.Add(oi3); 
            PodrobnostiNaročila oi4 = new PodrobnostiNaročila(); 
            oi4.ElementID = 126; oi4.ImeIzdelka = "Extreme"; 
            oi4.Količina = 5; o2.Elementi.Add(oi4); 
            PodrobnostiNaročila oi5 = new PodrobnostiNaročila(); 
            oi5.ElementID = 127; oi5.ImeIzdelka = "Bazooka"; 
            oi5.Količina = 1; o2.Elementi.Add(oi5); 
            PodrobnostiNaročila oi6 = new PodrobnostiNaročila(); 
            oi6.ElementID = 128; oi6.ImeIzdelka = "Sadje"; 
            oi6.Količina = 6; o2.Elementi.Add(oi6); 
            NaročiloList.Add(o1); 
            NaročiloList.Add(o2); 
            return NaročiloList; 
        }
    }
}
