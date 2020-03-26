using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaFilmow.Enums;

namespace WypozyczalniaFilmow.Classes
{
    class Film
    {
        string tytuł;
        string rezyser;
        string iD;
        FilmGenre.Genre gatunek;
        static double cenaPodstawowa = 1.35;
        static int numer;

        public string Tytuł { get => tytuł; set => tytuł = value; }
        public string Rezyser { get => rezyser; set => rezyser = value; }
        public string ID { get => iD; set => iD = value; }
        internal FilmGenre.Genre Gatunek { get => gatunek; set => gatunek = value; }


        public static int Numer { get => numer; set => numer = value; }
        public static double CenaPodstawowa { get => cenaPodstawowa; set => cenaPodstawowa = value; }

        static Film()
        {
            Numer = 0;
        }
        public Film(string t, string r, Enums.FilmGenre.Genre g)
        {
            this.Tytuł = t;
            this.Rezyser = r;
            this.Gatunek = g;
            this.ID = $"{numer++}/{DateTime.Now.Month}/{DateTime.Now.Year}";
        }

        public bool Znizka()
        {
            if (ObliczCene() >3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ObliczCene()
        {
            if (this.gatunek.Equals(Enums.FilmGenre.Genre.DlaDzieci))
            {
                return cenaPodstawowa * 0.78;
            }
            else if (this.gatunek.Equals(Enums.FilmGenre.Genre.Dramat))
            {
                return cenaPodstawowa * 1.5;
            }
            else if (this.gatunek.Equals(Enums.FilmGenre.Genre.Komedia) || this.gatunek.Equals(Enums.FilmGenre.Genre.SF) || this.gatunek.Equals(Enums.FilmGenre.Genre.Akcja))
            {
                return cenaPodstawowa * 2.6;
            }
            else if (this.gatunek.Equals(Enums.FilmGenre.Genre.Horror))
            {
                return cenaPodstawowa * 3.1;
            }
            else
            {
                return cenaPodstawowa * 0.75;
            }

        }
        public override string ToString()
        {
            return $"{this.iD}, Tytuł: {this.tytuł}, reż. {this.rezyser}, Gatunek: {this.gatunek} Cena: {ObliczCene():N2} zł.";
        }

    }
}
