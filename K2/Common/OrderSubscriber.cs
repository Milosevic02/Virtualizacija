using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class OrderSubscriber
    {
        public void OnFeeChanged(object sender, DeliveryEventArgs e)
        {
            Console.WriteLine($"Order with ID:{e.Id}  Tips is {e.Tips}");
        }
    }
}
