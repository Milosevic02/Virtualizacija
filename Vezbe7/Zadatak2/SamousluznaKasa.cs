using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class SamousluznaKasa
    {
        public delegate void SkenirajProizvodHandler(object sender, SkenirajProizvodEventArgs args);
        public delegate void ProvuciKarticuHandler(object sender, ProvuciKarticuEventArgs args);

        public event SkenirajProizvodHandler SkenirajProizvod;
        public event ProvuciKarticuHandler ProvuciKarticu;

        private decimal trenutnaCena = 0;

        public decimal TrenutnaCena { get { return trenutnaCena; } set { trenutnaCena = value; } }

        public void DodajUKorpu(string proizvod,decimal cena)
        {
            if(SkenirajProizvod != null)
            {
                TrenutnaCena += cena;
                SkenirajProizvod(this,new SkenirajProizvodEventArgs(TrenutnaCena,proizvod,cena));

            }
        }

        public void ProveriStanjeNaKartici(Kupac kupac)
        {
            if(ProvuciKarticu != null)
            {
                ProvuciKarticu(this, new ProvuciKarticuEventArgs(TrenutnaCena, kupac.Kartica));
            }
        }

    }
}
