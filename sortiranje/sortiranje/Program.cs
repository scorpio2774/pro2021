using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortiranje
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50000;
            int[] tab = new int[n];
            Random r = new Random();

            for(int k = 0; k < n; k++){
                tab[k] = r.Next();
            }

            DateTime d = DateTime.Now;
            Vstavljanje(tab);
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
            Console.WriteLine("Čas za vstavljanje " + ts.TotalMilliseconds + "ms");

            for (int k = 0; k < n; k++)
            {
                tab[k] = r.Next();
            }

             d = DateTime.Now;
            Izbiranje(tab);
             d1 = DateTime.Now;
             ts = d1 - d;
            Console.WriteLine("Čas za izbiranje " + ts.TotalMilliseconds + "ms");

            //Console.WriteLine("Neurejena");
            //Izpis(tab);
            ////Izbiranje(tab);
            //Vstavljanje(tab);
            //Console.WriteLine("Urejeno");
            //Izpis(tab);
            Console.ReadLine();
        }

        static void Izbiranje(int[] a) {
            for (int k = 0; k < a.Length-1; k++) {
                int min = a[k];
                int minIndex = k;
                for (int j = k; j < a.Length; j++) {
                    if (a[j] < min) {
                        min = a[j];
                        minIndex = j;
                    }
                }
                int temp = a[k];
                a[k] = a[minIndex];
                a[minIndex] = temp;
                //Izpis(a);
            }
        }

        static void Vstavljanje(int[] a) {
            for (int k = 1; k < a.Length; k++) {
                int j = k;
                int temp = a[k];
                while (j > 0 && a[j - 1] > temp) {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                //Izpis(a);
            }
        }

        static void Izpis(int[] a) {
            for (int k = 0; k < a.Length; k++) {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }
    }
}
