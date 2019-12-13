using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Szemely : IComparable<Szemely>//Implementálnunk kell, hogy a személyeket össze lehessen hasonlítani
    {
        //Java: final
        readonly string nev; //A readonly utólag nem változtatható át
        string beosztas;
        readonly DateTime szuletes;

        readonly ISet<Szemely> beosztottak = new SortedSet<Szemely>();

        public Szemely(string nev, string beosztas, DateTime szuletes)
        {
            this.nev = nev;
            this.beosztas = beosztas;
            this.szuletes = szuletes;
        }

        public void Hozzaad(Szemely sz)
        {
            beosztottak.Add(sz);
        }

        public Szemely Keres(string nev, DateTime szuletes)//Az internal a legszükebb beállítást néz, ami még értelmezhető
        {
            //Rekurzív megoldás
            if (this.nev.Equals(nev) && this.szuletes.Equals(szuletes))
            {
                return this;
            }
            foreach (var b in beosztottak)
            {
                var keresett = b.Keres(nev, szuletes);
                if (keresett!=null)
                {
                    return keresett;
                }
            }
            return null;
        }

        public string Nev => nev;
        public DateTime Szuletes => szuletes;
        public string Beosztas { get => beosztas; set => beosztas = value; }


        //ICompare-re alt+enter és implementáltuk az interface-t
        public int CompareTo(Szemely other)
        {

            int i = this.nev.CompareTo(other.nev);
            if (i != 0)//Ha nem egyezik
            {
                return i;
            }
            return this.szuletes.CompareTo(other.szuletes);
            
        }

        public override string ToString()
        {
            return nev + " " + szuletes;
        }

        public int Letszam
        {
            get
            {
                var l = 1;
                foreach (var b in beosztottak)
                {
                    l += b.Letszam;
                }
                return l;
            }
        }

        public string Listazas
        {
           get
           {
                string nev = this.nev;
                foreach (var i in beosztottak)
                {
                    nev += "\n"+i.Listazas;
                }
                return nev;
           }
        }
        //Aktuális elemmel megvizsgálni az értéket és kombinálni a rekurzív értékkel
        public int BeosztottakSzama
        {
            get
            {
                int letszam = 0;
                if (beosztottak.Count > 0)
                {
                    foreach (var a in beosztottak)
                    {
                        letszam += a.BeosztottakSzama;
                    }
                }
                else
                {
                    letszam = 1;
                }

                return letszam;
            }
        }

       


    }
}
