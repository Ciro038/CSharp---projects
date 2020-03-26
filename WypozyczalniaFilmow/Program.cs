using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaFilmow.Classes;

namespace WypozyczalniaFilmow
{
    class Program
    {
        static void Main(string[] args)
        {
            Film h1 = new Film("Efekt Motyla", "J.Mackye Gruber", Enums.FilmGenre.Genre.SF);
            Film h2 = new Film("W głowie się nie mieści", "Pete Docter", Enums.FilmGenre.Genre.DlaDzieci);
            Film h3 = new Film("Ukryte piękno", "David Frankel", Enums.FilmGenre.Genre.Dramat);

            Wypozyczalnia krk = new Wypozyczalnia("Kraków");
            krk.DodajFilm(h1);
            krk.DodajFilm(h2);
            krk.KatalogWypozyczen.Add(h3);
            krk.OddajFilm("Ukryte piękno", "David Frankel");

            Console.WriteLine(krk.ToString());
            Console.ReadKey();
        }
    }
}
