using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polak
{
    class Program
    {
        static void Main(string[] args)
        {
            Podręcznik h1 = new Podręcznik("Podstawy astronomii", dziedzina.astronomia, true, 130, 30);
            Podręcznik h2 = new Podręcznik("Podstawy wszechświata", dziedzina.astronomia, true, 250, 150);
            Podręcznik h3 = new Podręcznik("Analiza fizyczna", dziedzina.fizyka, false, 50, 50);
            Podręcznik h4 = new Podręcznik("Rachunek Prawdopodobieństwa", dziedzina.matematyka, false, 45, 101);

            KsięgarniaNaukowa a1 = new KsięgarniaNaukowa("TOPBOOK", "889136848");
            KsięgarniaNaukowa a2 = new KsięgarniaNaukowa("Pod Globusem", "185472689");
            KsięgarniaNaukowa a3 = new KsięgarniaNaukowa("Wydziałowa", "254123558");
            KsięgarniaNaukowa a4 = new KsięgarniaNaukowa("Biblioteka AGH", "742517589");

            a1.DodajPodręcznik(h1);
            a1.DodajPodręcznik(h2);
            a1.DodajPodręcznik(h3);
            a1.DodajPodręcznik(h4);
            Console.WriteLine(  a1.ToString());

            Console.ReadKey();
        }
    }
}
