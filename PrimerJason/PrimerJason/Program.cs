using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerJason
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucilnica u = JsonConvert.DeserializeObject<Ucilnica>(
            File.ReadAllText(@"D:\pro2021\PrimerJason\PrimerJason\Ucilnica.json"));
            foreach (var p in u.fuck you) {
                Console.WriteLine(p.name);
                foreach (var a in p.modules) {
                    Console.WriteLine("\t"+a.name);
                }
            }
        }
    }
}
