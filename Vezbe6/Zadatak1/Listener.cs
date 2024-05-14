using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Listener
    {
        public void OnRaisedNotification(object sender, EventArgs e)
        {
            Console.WriteLine($"Heard it! Time {DateTime.Now}");
        }
    }
}
