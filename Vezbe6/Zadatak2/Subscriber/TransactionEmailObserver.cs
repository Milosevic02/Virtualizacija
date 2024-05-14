using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Subscriber
{
    public class TransactionEmailObserver
    {
        public void HandleTransaction(object sender, PaymentEventArgs e)
        {
            Console.WriteLine($"New email recieved >> Message: {e.Message}, Amount: {e.Amount}");
        }
    }
}
