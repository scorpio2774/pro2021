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
            double[] tab = new double[n];
            //int[] tab = {6,24,4,80,19,1,84,10,13,7};
            Random r = new Random();

            for(int k = 0; k < n; k++){
                tab[k] = r.NextDouble();
            }

            //DateTime d = DateTime.Now;
            //Vstavljanje(tab);
            //DateTime d1 = DateTime.Now;
            //TimeSpan ts = d1 - d;
            //Console.WriteLine("Čas za vstavljanje " + ts.TotalMilliseconds + "ms");

            //for (int k = 0; k < n; k++)
            //{
            //    tab[k] = r.Next();
            //}

            // d = DateTime.Now;
            //Izbiranje(tab);
            // d1 = DateTime.Now;
            // ts = d1 - d;
            //Console.WriteLine("Čas za izbiranje " + ts.TotalMilliseconds + "ms");

            //Console.WriteLine("Neurejena");
            //Izpis(tab);
            ////Izbiranje(tab);
            //Vstavljanje(tab);
            //Console.WriteLine("Urejeno");

            //Console.WriteLine("Neurejena");
            //Izpis(tab);
            //Console.WriteLine("");
            
            //d = DateTime.Now;
            //QuickSort(0, tab.Length - 1, tab);
            //d1 = DateTime.Now;
            //ts = d1 - d;
            //Console.WriteLine("Čas za quicksort " + ts.TotalMilliseconds + "ms");
            //Console.WriteLine("");
            //Console.WriteLine("Urejeno");
            IzpisDouble(tab);
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

        static int Pivot(int zac, int konec, double[] tab) {
            double p = tab[zac];
            int m = zac;
            int n = konec + 1;

            //poišči z m prvega, ki je večji od p
            do
            {
                m = m + 1;
            } while (tab[m] <= p & m < konec);
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            //tab[m] je večji od p
            //tab od n je manjši od p
            //zamenjaj jih
            while (m < n)
            {
                double temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do { m = m + 1; } while (tab[m] <= p);
                do { n = n - 1; } while (tab[n] > p);

            }

            // zamenjaj pivotni element z elementom tab[n]
            double temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //Izpis(tab);
            return n;

        }

        static void QuickSort(int zac, int konc, double[] tab) {
            if (zac >= konc) {
                
                return; 
            }
            
            int a = Pivot(zac, konc, tab);
            
            QuickSort(zac, a - 1, tab);//levi del
            QuickSort(a + 1, konc, tab);
        }


        static void Izpis(int[] a) {
            for (int k = 0; k < a.Length; k++) {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }

        static void IzpisDouble(double[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }
    }
}
