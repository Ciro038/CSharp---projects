using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Podrecznik
    {
        private string tytul;
        public enum EnumDziedzina { fizyka, informatyka, matematyka, astronomia}
        private EnumDziedzina dziedzina;
        private int liczbaStron;
        private bool okladkaTwarda;
        private double cena;
        private string ssbn;
        private static int licznik;

        public string Tytul { get => tytul; set => tytul = value; }
        
        public int LiczbaStron { get => liczbaStron; set => liczbaStron = value; }
        public bool OkladkaTwarda { get => okladkaTwarda; set => okladkaTwarda = value; }
        public double Cena { get => cena; set => cena = value; }
        public string Ssbn { get => ssbn; set => ssbn = value; }
        public static int Licznik { get => licznik; set => licznik = value; }
        internal EnumDziedzina Dziedzina { get => dziedzina; set => dziedzina = value; }

        static Podrecznik()
        {
            licznik = 200;
        }
        public Podrecznik(string t, EnumDziedzina eD, int lS, bool oT, double c)
        {
            ++licznik;
            this.tytul = t;
            this.Dziedzina = eD;
            this.LiczbaStron = lS;
            this.okladkaTwarda = oT;
            this.cena = c;
            this.ssbn = $"{licznik}-{DateTime.Now.Year}-1998-{liczbaStron}";
        }

        public override string ToString()
        {
            if (this.okladkaTwarda)
            {
                return $"\"{this.tytul}\"/{this.ssbn}/{liczbaStron:F0} stron/twarda okładka";
            }
            else
            {
                return $"\"{this.tytul}\"/{this.ssbn}/{liczbaStron:F0} stron/miękka okładka";
            }
        }
    }
}
