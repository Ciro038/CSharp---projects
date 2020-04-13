using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class KsiegarniaNaukowa
    {
        string nazwa;
        string telefon;
        List<Podrecznik> podreczniki;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                try
                {
                    if (!checkTELEFON(value))
                    {
                        throw new wrongTELEFONExcepition();
                    }
                    telefon = value;

                }
                catch (wrongTELEFONExcepition e)
                {
                    Console.WriteLine(e.Message);
                    telefon = new String('0', 9);
                }
            }
        }
        internal List<Podrecznik> Podreczniki { get => podreczniki; set => podreczniki = value; }

        public KsiegarniaNaukowa(string n, string t)
        {
            this.nazwa = n;
            this.telefon = t;
            this.podreczniki = new List<Podrecznik>();


        }
        public override string ToString()
        {
            int tel =int.Parse(this.telefon);
            StringBuilder sb = new StringBuilder();
            foreach (Podrecznik item in podreczniki)
            {
                sb.AppendLine(item.ToString());
            }
            return $"{this.nazwa} {tel:(##) ### ## ##} \n{sb}";
        }

        public bool checkTELEFON(string p)
        {
            if (p.Length != 9) return false;
            return true;
        }

        public class wrongTELEFONExcepition : Exception
        {
            public wrongTELEFONExcepition() : base()
            {
                Console.WriteLine(" Niepoprawny numer telefonu ! ");
            }
        }
    }
}
