using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polak
{
    public enum dziedzina { fizyka, informatyka, matematyka, astronomia}
    public class Podręcznik
    {
        private string tytuł;
        private dziedzina enumDziedzina;
        private int liczbaStron;
        private bool okladkaTwarda;
        private double cena;
        private string ssbn;
        private static int licznik = 200;

        public string Tytuł { get => tytuł; set => tytuł = value; }
        public dziedzina EnumDziedzina { get => enumDziedzina; set => enumDziedzina = value; }
        public int LiczbaStron { get => liczbaStron; set => liczbaStron = value; }
        public bool OkladkaTwarda { get => okladkaTwarda; set => okladkaTwarda = value; }
        public double Cena { get => cena; set => cena = value; }
        public string Ssbn { get => ssbn; set => ssbn = value; }
        public static int Licznik { get => licznik; set => licznik = value; }

        static Podręcznik()
        {
            ++licznik;
        }

        public Podręcznik(string t, dziedzina eD, bool oT, double c, int lS)
        {
            licznik++;
            this.tytuł = t;
            this.enumDziedzina = eD;
            this.okladkaTwarda = oT;
            this.liczbaStron = lS;
            this.cena = c;
            this.ssbn = licznik + "-2020-1998-" + this.liczbaStron;


        }

        public override string ToString()
        {
            if (this.okladkaTwarda==true)
            {
                return this.tytuł + "/" + this.ssbn + "/" + this.cena + " zł/" + this.liczbaStron + " stron/okładka twarda";
            }
            else
            {
                return this.tytuł + "/" + this.ssbn + "/" + this.cena + " zł/" + this.liczbaStron + " stron/okładka miękka";
            }

        }

    }
}
