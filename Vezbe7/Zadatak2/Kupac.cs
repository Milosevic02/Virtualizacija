using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class Kupac
    {
        private decimal kartica = 500.0m;
        public decimal Kartica { get { return kartica; } set { kartica = value; } }

        public void UporediCenu(object sender,SkenirajProizvodEventArgs args)
        {
            Console.WriteLine($"Skeniran proizvod: {args.NazivProizvoda};");
            Console.WriteLine($" Cena: {args.CenaProizvoda};");
            Console.WriteLine($"--- Ukupno zaduženje: {args.IznosRacuna}---");
        }
    }
}
