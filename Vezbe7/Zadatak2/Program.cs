using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamousluznaKasa kasa = new SamousluznaKasa();
            Kupac kupac = new Kupac();

            kasa.SkenirajProizvod += kupac.UporediCenu;

            kasa.DodajUKorpu("hleb", 100.00m);
            kasa.DodajUKorpu("mleko", 200.00m);
            kasa.DodajUKorpu("jaja", 150.00m);

            kasa.ProvuciKarticu += delegate (object sender, ProvuciKarticuEventArgs e)
            {
                if (e.UkupnoZaduzenje > e.StanjeNaKartici)
                {
                    Console.WriteLine("Nemate dovoljno sredstava na kartici za plaćanje.");
                }
                else
                {
                    Console.WriteLine("Transakcija je uspešna. Hvala na kupovini!");
                }
            };

            kasa.ProveriStanjeNaKartici(kupac);

            Console.ReadKey();
        }
    }
}
