using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmGenerator alarmGenerator = new AlarmGenerator();
            Listener listener = new Listener();

            alarmGenerator.AlarmRingEvent += listener.OnRaisedNotification;

            var alarmThread = new Thread(alarmGenerator.StartAlarm);
            alarmThread.Start();

            Console.ReadKey();
        }
    }
}
