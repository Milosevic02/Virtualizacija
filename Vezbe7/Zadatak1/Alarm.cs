using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Alarm
    {
        public event Action<Alarm, EventArgs> VremeJeZaUstajanje;

        private int brojSekundiDoZvona = 5;

        public int BrojSekundiDoZvona
        {
            get { return brojSekundiDoZvona; }
        }

        public void UkljuciAlarm()
        {
            if(VremeJeZaUstajanje != null)
            {
                Console.WriteLine($"Alarm ce se ukljuciti za {brojSekundiDoZvona} sekundi");
                Thread.Sleep(brojSekundiDoZvona * 1000);
                VremeJeZaUstajanje(this,EventArgs.Empty);
            }
        }

        public void Odlozi()
        {
            Console.WriteLine($"Alarm je odlozen za {brojSekundiDoZvona * 2} sekundi");
            Thread.Sleep(brojSekundiDoZvona * 2 * 1000);
            VremeJeZaUstajanje?.Invoke(this, EventArgs.Empty);
        }

        public void Odbaci(Student s)
        {
            VremeJeZaUstajanje -= s.AlarmZvoni;            Console.WriteLine("Alarm je ugasen");
            Console.WriteLine("Alarm je ugasen");

        }
    }
}
