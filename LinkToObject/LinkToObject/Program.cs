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
