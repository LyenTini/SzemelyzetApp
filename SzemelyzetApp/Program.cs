using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fonok = new Szemely("Szultán", "Szultán", new DateTime(854,11,1)); 

            var szemelyzet = new Szemelyzet(fonok);
            var sz1 = new Szemely("Jázmin","Hercegnő",new DateTime(880,5,12));
            var sz2 = new Szemely("Jafar","Főtanácsadó",new DateTime(856,12,5));
            var sz3 = new Szemely("Iago","Papagáj",new DateTime(881,1,1));
            
            fonok.Hozzaad(sz1);
            fonok.Hozzaad(sz2);
            sz2.Hozzaad(sz3);

            Szemely keresett = szemelyzet.Keres("Jafar", new DateTime(856, 12, 5));
            //Console.WriteLine(keresett);
            //Console.WriteLine(szemelyzet.Letszam);


             /* 
             - Személyzet.Listázás() - konzolra kiírja a teljes személyzetet, soronként elválasztva 
             - Személyzet.BeosztottakSzama: int(getter) - megszámolja, hogy hány olyan személy dolgozik, akinek nincs beosztottja
             */






            Console.ReadLine();
        }
    }
}
