using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
            Premakni(8, "a", "c", "b");
            Console.WriteLine("Konec");
            Console.ReadLine();
        }

        static void Premakni(int n, string zacetni, string koncni, string pomozni) { 
            if (n==1){
                Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
                return;
            }
            Premakni(n - 1, zacetni, pomozni, koncni); //1. del iz a -> b, pomagaj si s c
            Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
            Premakni(n - 1, pomozni, koncni, zacetni); //2. del iz b -> c, pomagaj si z a

        }


    }
}
