using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class SkenirajProizvodEventArgs
    {
        private decimal iznosRacuna;
        private string nazivProizvoda;
        private decimal cenaProizvoda;
        public decimal IznosRacuna { get { return iznosRacuna; } set { iznosRacuna = value; } }
        public string NazivProizvoda { get { return nazivProizvoda; } set { nazivProizvoda = value; } }
        public decimal CenaProizvoda { get { return cenaProizvoda; } set { cenaProizvoda = value; } }

        public SkenirajProizvodEventArgs(decimal iznosRacuna, string nazivProizvoda, decimal cenaProizvoda)
        {
            this.IznosRacuna = iznosRacuna;
            this.NazivProizvoda = nazivProizvoda;
            this.cenaProizvoda = cenaProizvoda;
        }
    }
}
