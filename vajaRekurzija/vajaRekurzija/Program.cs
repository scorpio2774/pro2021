using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaRekurzija
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Vnesi katero fibbonacijevo število po vrsti bi rad/a izvedel/a ");
            int vnos = int.Parse(Console.ReadLine());
            Console.WriteLine("Iterativno "+ potencaIterativno(10));
            Console.WriteLine("Rekurzija " + potencaRekurzivno(10));
            Console.WriteLine(vnos+". fibonaccijevo število je " + fibonacciStevilo(vnos));
            */
            Console.WriteLine("Naloga 3");
            int vnos1 = int.Parse(Console.ReadLine());

            Console.WriteLine(nal3(vnos1));

            Console.WriteLine("Naloga 4");
            int vnos2 = int.Parse(Console.ReadLine());

            Console.WriteLine(nal4(vnos2));

            Console.WriteLine("Naloga 5");
            int vnos3 = int.Parse(Console.ReadLine());

            Console.WriteLine(nal5(vnos3));

            Console.ReadLine();
        }

        static int potencaIterativno(int n) {
            int potenca = 1;
            for (int i = 1; i <= n; i++) {
                potenca = potenca * 2;
            }
            return potenca;
        }

        static int potencaRekurzivno(int n) {
            if (n == 0)
            {
                return 1;
            }
            return 2 * potencaRekurzivno(n - 1);
        }

        static int fibonacciStevilo(int n) {
            if (n == 1 || n == 2) {
                return 1;
            }
            return fibonacciStevilo(n - 1) + fibonacciStevilo(n - 2);
        }


        /*      Podano je zaporedje: 2, 2, 3, 5, 14, 69, 965, ...
                a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
                b.Napišite sled izvajanja programa za klic test.clen(2) in test.clen(5)!
                Upoštevajte, da je zaporedje definirano:
                a1 = 2
                a2 = 2
                a(n) = a(n-2)*a(n-1) – 1*/


        static int nal3(int n) {
            if (n == 1 || n==2) { 
                return 2; 
            }
            return (nal3(n - 2) * nal3(n - 1)-1);
        }


                /*4. Podano je zaporedje: 2, 8, 26, 80, 242, ...
                a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
                b.Napišite sled izvajanja programa za klic test.clen(2) in test.clen(5).
                Upoštevajte, da je zaporedje definirano:
                a1 = 2
                a(n) = 3 * a(n-1) + 2
                */

        static int nal4(int n) {
            if (n == 1) { 
                return 2; 
            }
            return 3 * nal4(n - 1) + 2;
        }

        /*
                5. Podano je zaporedje:: 1, 2, 5, 12, 29, …
                a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
                Upoštevajte, da je zaporedje definirano:
                a1 = 1
                a2 = 2
                a(n) = a(n-1)*2 + a(n-2)
        */


        static int nal5(int n)
        {
            if (n == 1){
                return 1;
            }
            if (n == 2) {
                return 2;
            }
            return (nal5(n - 1) * 2 + nal5(n - 2));
        }


    }
}
