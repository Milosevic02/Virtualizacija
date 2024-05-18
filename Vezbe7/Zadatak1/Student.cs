using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Student
    {
        public void AlarmZvoni(Alarm alarm,EventArgs e)
        {
            Console.WriteLine("Da li zelite da odložite alarm? (da/ne)");
            string odgovor = Console.ReadLine();

            switch (odgovor.ToLower())
            {
                case "ne":
                    alarm.Odbaci(this);
                    break;
                case "da":
                    alarm.Odlozi();
                    break;
                default:
                    break;

            }
        }
    }
}
