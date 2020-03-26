using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFilmow.Classes
{
    class Wypozyczalnia : IWypozyczalny
    {
        string nazwa;
        List<Film> katalogFilmow;
        List<Film> katalogWypozyczen;



        public string Nazwa { get => nazwa; set => nazwa = value; }
        internal List<Film> KatalogFilmow { get => katalogFilmow; set => katalogFilmow = value; }
        internal List<Film> KatalogWypozyczen { get => katalogWypozyczen; set => katalogWypozyczen = value; }

        public Wypozyczalnia(string n)
        {
            this.Nazwa = n;
            this.KatalogFilmow = new List<Film>();
            this.KatalogWypozyczen = new List<Film>();
        }

        public void DodajFilm(Film a)
        {
            katalogFilmow.Add(a);
        }

        public void UsunFilm(string t, string r) //usunięcie filmu z katalogu filmów o podanym tytule i reżyserze 
        {
            foreach (Film item in katalogFilmow)
            {
                if (item.Tytuł.Equals(t) && item.Rezyser.Equals(r))
                {
                    katalogFilmow.RemoveAt(katalogFilmow.IndexOf(item));
                }
                break;
            }
        }

        public void OddajFilm(string t, string r) //przenosi film z katalogu wypozyczonych do katalogu filmow
        {
            foreach (Film a in katalogWypozyczen)
            {
                if (a.Tytuł.Equals(t) && a.Rezyser.Equals(r))
                {
                    katalogWypozyczen.RemoveAt(katalogWypozyczen.IndexOf(a));

                    katalogFilmow.Add(a);
                }
                break;
            }
        }

        public void Wypozycz(string t, string r)
        {
            foreach (Film b in katalogFilmow)
            {

                if (b.Tytuł.Equals(t) && b.Rezyser.Equals(r))
                {
                    katalogFilmow.RemoveAt(katalogFilmow.IndexOf(b));

                    katalogWypozyczen.Add(b);
                }
                break;

            }
        }
        public void Zwroc(string t, string r)
        {
            foreach (Film item in katalogWypozyczen)
            {

                if (item.Tytuł.Equals(t) && item.Rezyser.Equals(r))
                {
                    katalogWypozyczen.RemoveAt(katalogWypozyczen.IndexOf(item));

                    katalogFilmow.Add(item);
                }
                break;

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Wypożyczalnia: \"{this.nazwa}\"");
            if (katalogFilmow.Count > 0)
            {
                sb.AppendLine("Dostępne filmy: ");
                foreach (Film item in katalogFilmow)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            if (katalogWypozyczen.Count > 0)
            {
                sb.AppendLine("Filmy wypożyczone: ");
                foreach (Film item in katalogWypozyczen)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
