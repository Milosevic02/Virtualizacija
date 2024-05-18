using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class ProvuciKarticuEventArgs:EventArgs
    {
        private decimal stanjeNaKartici;
        private decimal ukupnoZaduzenje;

        public decimal StanjeNaKartici { get { return stanjeNaKartici; } set { stanjeNaKartici = value; } }
        public decimal UkupnoZaduzenje { get { return ukupnoZaduzenje; } set { ukupnoZaduzenje = value; } }

        public ProvuciKarticuEventArgs(decimal ukupnoZaduzenje, decimal stanjeNaKartici)
        {
            this.StanjeNaKartici = stanjeNaKartici;
            this.UkupnoZaduzenje = ukupnoZaduzenje;
        }
    }
}
