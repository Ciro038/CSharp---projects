using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaFilmow
{
    interface IWypozyczalny
    {
        void Wypozycz(string t, string r);
        void Zwroc(string t, string r);
    }
}
