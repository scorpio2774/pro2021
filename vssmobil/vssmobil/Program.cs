﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vssmobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeleziKlic(10, 1);
            Console.WriteLine(janez.ToString() + "EUR");
            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Alenka Prinčič";
            alenka.BeleziKlic(70, 2);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje + "EUR");
            Console.WriteLine("Metoda GetType " + alenka.GetType());
            Console.WriteLine("Metoda ToString " + alenka.ToString());

            Kupec[] vsi = new Kupec[3]; //tabela treh kupcev tipa kupec
            vsi[0] = new Kupec();


            Console.ReadLine();

        }


    }
}