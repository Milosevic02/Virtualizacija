using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class AlarmGenerator
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler AlarmRingEvent;

        public void StartAlarm()
        {
            if(AlarmRingEvent != null)
            {
                GenerateAlarms();
            }
        }

        public void GenerateAlarms()
        {
            int numberOfAlarms = GetNumberOfAlarms();
            if(numberOfAlarms > 0)
            {
                Console.WriteLine("Alarm started");
                for(int count = 0; count < numberOfAlarms; count++)
                {
                    AlarmRingEvent(this,EventArgs.Empty);
                    Thread.Sleep(3000);
                }
                Console.WriteLine("Alarm stopped");
            }
        }


        public int GetNumberOfAlarms()
        {
            string numberOfAlarmsString = ConfigurationManager.AppSettings["numberOfAlarms"];
            if(int.TryParse(numberOfAlarmsString, out int numberOfAlarms))
            {
                return numberOfAlarms;
            }
            return 0;
        }
    }
}
