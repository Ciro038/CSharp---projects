using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;

namespace Polak
{
    public class KsięgarniaNaukowa
    {
        private string nazwa;
        private string telefon;
        List<Podręcznik> podręczniki;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                try
                {
                    if (!CheckTELEFON(value))
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
        public bool CheckTELEFON(string p)
        {
            if (p.Length != 9) return false;
            return true;
        }

        public List<Podręcznik> Podręczniki { get => podręczniki; set => podręczniki = value; }

        public KsięgarniaNaukowa()
        {

        }


        public KsięgarniaNaukowa(string n, string tel)
        {
            podręczniki = new List<Podręcznik>();
            this.nazwa = n;
            this.Telefon = tel;


        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Księgarnia: "+this.nazwa);
            str.Append($"Telefon: {int.Parse(this.Telefon):### ## ## ##} \n");
            str.AppendLine("Lista Podręczników: ");
            foreach (Podręcznik a in podręczniki)
            {
                str.AppendLine(a.ToString());
            }
            return str.ToString();
        }

        public void DodajPodręcznik(Podręcznik p)
        {
            Podręczniki.Add(p);
        }

        public void UsunPodrecznik(string ssbn)
        {
            foreach (Podręcznik a in podręczniki)
            {
                if (a.Ssbn == ssbn)
                {
                    Podręczniki.Remove(a);
                }
            }
        }

        public Podręcznik Szukaj(string ssbn)
        {
            foreach  (Podręcznik a in podręczniki)
            {
                if(a.Ssbn==ssbn)
                {
                    return a;
                }
            }
            return null;


        }

        public List<Podręcznik> Szukaj(dziedzina dz, bool okladka)
        {
            List<Podręcznik> L = new List<Podręcznik>();
            foreach (Podręcznik a in podręczniki)
            {
                dziedzina test;
                if (dz.Equals("fizyka"))
                {
                    test = dziedzina.fizyka;
                }
                else if (dz.Equals("informatyka"))
                {
                    test = dziedzina.informatyka;
                }
                else if (dz.Equals("matematyka"))
                {
                    test = dziedzina.matematyka;
                }
                else if (dz.Equals("astronomia"))
                {
                    test = dziedzina.astronomia;
                }
                else
                {
                    return L;
                }
                if (a.EnumDziedzina == test && a.OkladkaTwarda == okladka)
                {
                    L.Add(a);
                }
            }
            return L;

        }

        public List<Podręcznik> SzukajDziedzina(dziedzina dz)
        {
            List<Podręcznik> L = new List<Podręcznik>();
            foreach (Podręcznik a in podręczniki)
            {
                dziedzina test;
                if (dz.Equals("fizyka"))
                {
                    test = dziedzina.fizyka;
                }
                else if (dz.Equals("informatyka"))
                {
                    test = dziedzina.informatyka;
                }
                else if (dz.Equals("matematyka"))
                {
                    test = dziedzina.matematyka;
                }
                else if (dz.Equals("astronomia"))
                {
                    test = dziedzina.astronomia;
                }
                else
                {
                    return L;
                }
                if (a.EnumDziedzina == test)
                {
                    L.Add(a);
                }
            }
            return L;

        }
        public void ZapiszJakoXML(string fname)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(KsięgarniaNaukowa));
            StreamWriter sw = new StreamWriter(fname);
            serializer.Serialize(sw, this.nazwa);
            sw.Close();
        }
        public KsięgarniaNaukowa OdczytajZPlikuXML(string fname)
        {
            KsięgarniaNaukowa nowy = new KsięgarniaNaukowa();
            TextReader tr = new StreamReader(fname);
            XmlSerializer serializer = new XmlSerializer(typeof(KsięgarniaNaukowa));
            nowy = (KsięgarniaNaukowa)serializer.Deserialize(tr);
            tr.Close();
            return nowy;
        }






    }
    public class wrongTELEFONExcepition : Exception
    {
        public wrongTELEFONExcepition() : base()
        {
            Console.WriteLine(" Niepoprawny numer telefonu ! ");
        }
    }



}
