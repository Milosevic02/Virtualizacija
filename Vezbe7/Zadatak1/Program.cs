using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            Student student = new Student();

            alarm.VremeJeZaUstajanje += student.AlarmZvoni;

            alarm.UkljuciAlarm();

            Console.ReadKey();
        }
    }
}
