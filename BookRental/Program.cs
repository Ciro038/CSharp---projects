using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Podrecznik h1 = new Podrecznik("EloBolo", Podrecznik.EnumDziedzina.astronomia, 200, true, 198);
            Podrecznik h2 = new Podrecznik("EloBolo2", Podrecznik.EnumDziedzina.astronomia, 200, true, 198);
            Podrecznik h3 = new Podrecznik("EloBolo3", Podrecznik.EnumDziedzina.astronomia, 200, false, 198);
            Podrecznik h4 = new Podrecznik("EloBolo4", Podrecznik.EnumDziedzina.astronomia, 200, true, 198);
            KsiegarniaNaukowa ks = new KsiegarniaNaukowa("Biblioteka Naukowa", "124192138");
            ks.Podreczniki.Add(h1);
            ks.Podreczniki.Add(h2);
            ks.Podreczniki.Add(h3);
            ks.Podreczniki.Add(h4);
            Console.WriteLine(ks.ToString());
            Console.ReadKey();
        }
    }
}

