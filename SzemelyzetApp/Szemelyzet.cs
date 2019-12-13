using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Szemelyzet
    {

        Szemely fonok;
        
        public Szemelyzet(Szemely fonok)
        {
            this.fonok = fonok;
        }

        public Szemely Keres(string nev, DateTime szuletes)//Az internal a legszükebb beállítást néz, ami még értelmezhető
        {
            //Rekurzív megoldás-> Szemely-ben megírva és csak meghívtuk a fönök keresés függvényét
            return fonok.Keres(nev,szuletes);
        }

        public int Letszam
        {
            get
            {
                return fonok.Letszam;
            }
        }

        public string Listazas()
        {
            return fonok.Listazas;
        }


        public int BeosztottakSzama()
        {
            return fonok.BeosztottakSzama;
        }
    }
}
